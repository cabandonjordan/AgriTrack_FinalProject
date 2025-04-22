using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
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
    public partial class FarmerSale : UserControl
    {
        private OleDbConnection myConn;
        public int UserID { get; set; }

        public FarmerSale(int userID)
        {
            InitializeComponent();
            UserID = userID;
            EnsureDataBase();
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

                string fullNameQuery = "SELECT FullName FROM Users WHERE UserID = ?";
                OleDbCommand nameCmd = new OleDbCommand(fullNameQuery, myConn);
                nameCmd.Parameters.AddWithValue("?", UserID);

                string farmerName = string.Empty;
                using (OleDbDataReader reader = nameCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        farmerName = reader["FullName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No farmer found with the given UserID.");
                        return;
                    }
                }

                string query = @"
        SELECT 
            Crops.CropsName, 
            SUM(Purchase.QuantityBought) AS TotalQuantity,
            SUM(Purchase.TotalPrices) AS TotalSales
        FROM 
            Purchase 
            INNER JOIN Crops ON Purchase.CropID = Crops.CropID
        WHERE 
            Purchase.Status = 'Confirmed' AND 
            Purchase.FarmersName = ? 
        GROUP BY 
            Crops.CropsName";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", farmerName);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    var pieSeries = new List<PieSeries<double>>();
                    double overallTotalSales = 0;

                    while (reader.Read())
                    {
                        string cropName = reader["CropsName"].ToString();
                        double totalSales = Convert.ToDouble(reader["TotalSales"]);
                        overallTotalSales += totalSales;

                        pieSeries.Add(new PieSeries<double>
                        {
                            Values = new[] { totalSales },
                            Name = cropName,
                            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                            DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                            DataLabelsFormatter = point => $"{point.Context.Series.Name}: ₱{point.Coordinate.PrimaryValue:N2}"
                        });
                    }

                    if (pieSeries.Count > 0)
                    {
                        UpdateChart(pieSeries);
                        totalAmount.Text = $"Total Sales: ₱{overallTotalSales:N2}";
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified farmer.");
                        totalAmount.Text = "Total Sales: ₱0.00";
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
    }
}
