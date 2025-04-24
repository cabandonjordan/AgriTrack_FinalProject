using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class SalesOverview : UserControl
    {
        OleDbConnection? myConn;
        public SalesOverview()
        {
            InitializeComponent();
            EnsureDataBase();
            LoadCartesianPlot();
            LoadPieChart();
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private void LoadPieChart()
        {
            try
            {
                myConn.Open();

                string query = @"  
               SELECT   
                   Crops.CropsName,   
                   SUM(Purchase.QuantityBought) AS TotalQuantity  
               FROM   
                   Purchase   
                   INNER JOIN Crops ON Purchase.CropID = Crops.CropID  
               WHERE   
                   Purchase.Status = 'Confirmed'  
               GROUP BY   
                   Crops.CropsName";

                OleDbCommand cmd = new OleDbCommand(query, myConn);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    var pieSeries = new List<PieSeries<double>>();

                    while (reader.Read())
                    {
                        string cropName = reader["CropsName"].ToString();
                        double totalQuantity = Convert.ToDouble(reader["TotalQuantity"]);

                        pieSeries.Add(new PieSeries<double>
                        {
                            Values = new[] { totalQuantity },
                            Name = cropName,
                            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                            DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                            DataLabelsFormatter = point => $"{point.Context.Series.Name}: {point.Coordinate.PrimaryValue:N0}"
                        });
                    }

                    if (pieSeries.Count > 0)
                    {
                        UpdateChart(pieSeries);
                    }
                    else
                    {
                        MessageBox.Show("No confirmed sales found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pie chart: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
        private void UpdateChart(List<PieSeries<double>> pieSeries)
        {
            salesReport.Series = pieSeries;
            salesReport.Width = 600;
            salesReport.Height = 400;
            salesReport.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            salesReport.Top = 10;
            salesReport.Left = 10;
        }
        private void LoadFilteredData(DateTime startDate, DateTime endDate)
        {
            try
            {
                myConn.Open();

                string query = @"
        SELECT 
            Crops.CropsName,
            Purchase.QuantityBought,
            Purchase.TotalPrices,
            Purchase.SaleDate
        FROM 
            Purchase
            INNER JOIN Crops ON Purchase.CropID = Crops.CropID
        WHERE 
            Purchase.Status = 'Confirmed' AND
            Purchase.SaleDate BETWEEN ? AND ?
        ORDER BY 
            Purchase.SaleDate";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", startDate);
                cmd.Parameters.AddWithValue("?", endDate);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    var seriesDict = new Dictionary<string, List<double>>();
                    var xAxisLabels = new List<string>();

                    while (reader.Read())
                    {
                        string cropName = reader["CropsName"]?.ToString() ?? "Unknown";
                        double quantityBought = reader["QuantityBought"] != DBNull.Value ? Convert.ToDouble(reader["QuantityBought"]) : 0;
                        double totalPrice = reader["TotalPrices"] != DBNull.Value ? Convert.ToDouble(reader["TotalPrices"]) : 0;
                        DateTime saleDate = Convert.ToDateTime(reader["SaleDate"]);
                        string label = $"{cropName}\n{saleDate:MMM dd}";

                        xAxisLabels.Add(label);

                        if (!seriesDict.ContainsKey("Quantity (kg)"))
                            seriesDict["Quantity (kg)"] = new List<double>();
                        if (!seriesDict.ContainsKey("Sales (₱)"))
                            seriesDict["Sales (₱)"] = new List<double>();

                        seriesDict["Quantity (kg)"].Add(quantityBought);
                        seriesDict["Sales (₱)"].Add(totalPrice);
                    }

                    var seriesCollection = new List<ColumnSeries<double>>();

                    foreach (var kvp in seriesDict)
                    {
                        seriesCollection.Add(new ColumnSeries<double>
                        {
                            Name = kvp.Key,
                            Values = kvp.Value,
                            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                            DataLabelsFormatter = point =>
                                kvp.Key.Contains("₱") ?
                                $"₱{point.Coordinate.PrimaryValue:N2}" :
                                $"{point.Coordinate.PrimaryValue:N2} kg"
                        });
                    }

                    if (seriesCollection.Count > 0)
                    {
                        UpdateCartesianPlot(seriesCollection, xAxisLabels);
                    }
                    else
                    {
                        MessageBox.Show("No sales data found for the selected date range.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading filtered data: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
        private void LoadCartesianPlot()
        {
            try
            {
                myConn.Open();

                // Query to fetch data for all farmers (no UserID filtering)
                string query = @"
            SELECT  
                Crops.CropsName,  
                Purchase.QuantityBought,  
                Purchase.TotalPrices,  
                Purchase.SaleDate  
            FROM  
                Purchase  
                INNER JOIN Crops ON Purchase.CropID = Crops.CropID  
            WHERE  
                Purchase.Status = 'Confirmed'  
            ORDER BY  
                Purchase.SaleDate";

                OleDbCommand cmd = new OleDbCommand(query, myConn);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    var seriesCollection = new List<ColumnSeries<double>>();
                    var xAxisLabels = new List<string>();

                    while (reader.Read())
                    {
                        string cropName = reader["CropsName"]?.ToString() ?? "Unknown";
                        double quantityBought = reader["QuantityBought"] != DBNull.Value ? Convert.ToDouble(reader["QuantityBought"]) : 0;
                        double totalPrice = reader["TotalPrices"] != DBNull.Value ? Convert.ToDouble(reader["TotalPrices"]) : 0;
                        DateTime saleDate = reader["SaleDate"] != DBNull.Value ? Convert.ToDateTime(reader["SaleDate"]) : DateTime.MinValue;

                        string label = $"{cropName}\n{saleDate:MMM dd, yyyy}";
                        xAxisLabels.Add(label);

                        seriesCollection.Add(new ColumnSeries<double>
                        {
                            Values = new[] { quantityBought },
                            Name = $"{cropName} - ₱{totalPrice:N2}",
                            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                            DataLabelsFormatter = point => $"{point.Coordinate.PrimaryValue:N2} kg"
                        });
                    }

                    if (seriesCollection.Count > 0)
                    {
                        UpdateCartesianPlot(seriesCollection, xAxisLabels);
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cartesian plot: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
        private void UpdateCartesianPlot(List<ColumnSeries<double>> seriesCollection, List<string> xAxisLabels)
        {
            cartesianSales.Series = seriesCollection;
            cartesianSales.XAxes = new[]
            {
                      new LiveChartsCore.SkiaSharpView.Axis
                      {
                          Labels = xAxisLabels,
                          LabelsRotation = 15,
                          TextSize = 12
                      }
                  };
            cartesianSales.YAxes = new[]
            {
                      new LiveChartsCore.SkiaSharpView.Axis
                      {
                          Labeler = value => $"kg{value:N2}",
                          TextSize = 12
                      }
                  };
            cartesianSales.Width = 800;
            cartesianSales.Height = 500;
            cartesianSales.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            cartesianSales.Top = 420;
            cartesianSales.Left = 10;
        }

        private void daily_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            MessageBox.Show("Filtering for: " + today.ToString("yyyy-MM-dd"));
            LoadFilteredData(today, today);
        }

        private void weekly_Click(object sender, EventArgs e)
        {
            DateTime startOfWeek = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);
            LoadFilteredData(startOfWeek, endOfWeek);
        }

        private void monthly_Click(object sender, EventArgs e)
        {
            DateTime startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            LoadFilteredData(startOfMonth, endOfMonth);
        }

        private void Yearly_Click(object sender, EventArgs e)
        {
            DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
            LoadFilteredData(startOfYear, endOfYear);
        }
    }
}
