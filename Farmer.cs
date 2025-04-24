using Newtonsoft.Json.Linq;
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
    public partial class Farmer : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        private FarmerHome? farmerHomeUC;
        private FarmerCrops? farmerCropsUC;//INITIALIZE PARA IG INSTANTIATE KAY USA RA KA OBJECT MABUTANG

        private WebBrowser weatherWebView;
        public Farmer()
        {
            InitializeComponent();
            EnsureDataBase();

            weatherWebView = new WebBrowser();
            weatherWebView.Dock = DockStyle.Fill;
            this.Controls.Add(weatherWebView);

            Task.Run(() => FetchWeatherAsync());
        }
        private void EnsureDataBase()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \"C:\\Users\\Jordan\\Desktop\\BSCPE\\2ND YEAR\\2ND SEM\\CPE262\\FINAL PROJECT\\AgtriTrack_Database\\AgtriTrack_Database.accdb\"");
        }
        private async Task FetchWeatherAsync()
        {
            string apiKey = "9f43fccf047ca7cec99e07c549baa0b5";
            string city = "Cebu";
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city},ph&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error: {response.StatusCode}, Details: {errorResponse}");
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        JObject weatherData = JObject.Parse(responseBody);
                        string weatherDescription = weatherData["weather"][0]["description"].ToString();
                        double temperature = Convert.ToDouble(weatherData["main"]["temp"]);
                        double humidity = Convert.ToDouble(weatherData["main"]["humidity"]);

                        UpdateWeatherPanel(weatherDescription, temperature, humidity);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching weather data: {ex.Message}");
                }
            }
        }

        private void UpdateWeatherPanel(string description, double temperatures, double humidity)
        {
            if (statusWeather.InvokeRequired)
            {
                statusWeather.Invoke(new Action(() =>
                {
                    statusWeather.Text = $"Weather: {description}";
                    temperature.Text = $"Temperature: {temperatures}°C";
                    weatherImage.Image = Image.FromFile(GetWeatherIconPath(description));
                }));
            }
            else
            {
                statusWeather.Text = $"Weather: {description}";
                temperature.Text = $"Temperature: {temperatures}°C";
                weatherImage.Image = Image.FromFile(GetWeatherIconPath(description));
            }
        }

        private string GetWeatherIconPath(string description)
        {
            string iconPath = @"C:\Users\Jordan\Downloads\clear-sky.png";

            if (description.Contains("clear"))
            {
                iconPath = @"C:\Users\Jordan\Downloads\clear-sky.png";
            }
            else if (description.Contains("cloud"))
            {
                iconPath = @"C:\Users\Jordan\Downloads\clouds.png";
            }
            else if (description.Contains("rain"))
            {
                iconPath = @"C:\Users\Jordan\Downloads\rainy-day.png";
            }
            else if (description.Contains("storm"))
            {
                iconPath = @"C:\Users\Jordan\Downloads\storm.png";
            }
            else if (description.Contains("sun"))
            {
                iconPath = @"C:\Users\Jordan\Downloads\sun.png";
            }

            return iconPath;
        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            profileInfo pfp = new profileInfo(Form1.LoggedInUser);
            farmerPanel.Controls.Clear();
            pfp.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(pfp);
            pfp.BringToFront();
        }

        private void myCrops_Click(object sender, EventArgs e)
        {
            farmerCropsUC = new FarmerCrops(Form1.LoggedInUserID);
            farmerPanel.Controls.Clear();
            farmerCropsUC.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(farmerCropsUC);
            farmerCropsUC.BringToFront();
            //FarmerCrops crops = new FarmerCrops(Form1.LoggedInUserID);
            //farmerPanel.Controls.Clear();
            //crops.Dock = DockStyle.Fill;
            //farmerPanel.Controls.Add(crops);
            //crops.BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void saleHistory_Click(object sender, EventArgs e)
        {
            FarmerSale sale = new FarmerSale(Form1.LoggedInUserID);
            farmerPanel.Controls.Clear();
            sale.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(sale);
            sale.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            farmerHomeUC = new FarmerHome(Form1.LoggedInUserID);
            farmerPanel.Controls.Clear();
            farmerHomeUC.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(farmerHomeUC);
            farmerHomeUC.BringToFront();
            //FarmerHome home = new FarmerHome(Form1.LoggedInUserID);
            //farmerPanel.Controls.Clear();
            //home.Dock = DockStyle.Fill;
            //farmerPanel.Controls.Add(home);
            //home.BringToFront();
        }
        //KOA SEARCH BOX PARA SEARCH2 SA KATO FARMERHOME UG FARMERCROPS
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //PANGTAWAG SA FUNCTION SA FARMERHOME UG FARMERCROPS
            //EACH TIME MAG TYPE SA SEARCH BOX, MO CALL NI NGA FUNCTION
            //UG MO FILTER SA CROPS BASED SA INPUT
            if (farmerHomeUC != null)
            {
                farmerHomeUC.FilterCrops(searchBox.Text);
            }
            if (farmerCropsUC != null)
            {
                farmerCropsUC.FilterCrops(searchBox.Text);
            }
        }

        private void pendingOrders_Click(object sender, EventArgs e)
        {
            PendingOrders pendingOrders = new PendingOrders(Form1.LoggedInUserID);
            farmerPanel.Controls.Clear();
            pendingOrders.Dock = DockStyle.Fill;
            farmerPanel.Controls.Add(pendingOrders);
            pendingOrders.BringToFront();
        }
    }
}
