using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriTrack_FinalProject
{
    public partial class Customer : Form
    {
        private WebBrowser weatherWebView;
        public Customer()
        {
            InitializeComponent();
            weatherWebView = new WebBrowser();
            weatherWebView.Dock = DockStyle.Fill;
            this.Controls.Add(weatherWebView);

            Task.Run(() => FetchWeatherAsync());
        }
        private MarketPlace? marketPlaceUC;
        private ShoppingCart? shoppingCartUC;
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
            customerPanel.Controls.Clear();
            pfp.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(pfp);
            pfp.BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void marketPlace_Click(object sender, EventArgs e)
        {
            marketPlaceUC = new MarketPlace(Form1.LoggedInUserID);
            customerPanel.Controls.Clear();
            marketPlaceUC.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(marketPlaceUC);
            marketPlaceUC.BringToFront();
            //MarketPlace mp = new MarketPlace(Form1.LoggedInUserID);
            //customerPanel.Controls.Clear();
            //mp.Dock = DockStyle.Fill;
            //customerPanel.Controls.Add(mp);
            //mp.BringToFront();
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            shoppingCartUC = new ShoppingCart(Form1.LoggedInUserID);
            customerPanel.Controls.Clear();
            shoppingCartUC.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(shoppingCartUC);
            shoppingCartUC.BringToFront();
            //ShoppingCart sc = new ShoppingCart(Form1.LoggedInUserID);
            //customerPanel.Controls.Clear();
            //sc.Dock = DockStyle.Fill;
            //customerPanel.Controls.Add(sc);
            //sc.BringToFront();
        }

        private void purchaseHistory_Click(object sender, EventArgs e)
        {
            PurchaseHistory ph = new PurchaseHistory(Form1.LoggedInUserID);
            customerPanel.Controls.Clear();
            ph.Dock = DockStyle.Fill;
            customerPanel.Controls.Add(ph);
            ph.BringToFront();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (marketPlaceUC != null)
            {
                marketPlaceUC.FilterCrops(searchBox.Text);
            }
            if(shoppingCartUC != null)
            {
                shoppingCartUC.FilterCrops(searchBox.Text);
            }
        }
    }
}
