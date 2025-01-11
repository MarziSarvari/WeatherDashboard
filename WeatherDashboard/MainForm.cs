using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WeatherDashboard.Model;
using WeatherDashboard.Tool;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherDashboard
{
    public partial class MainForm : Form
    {
        private bool isCelsius;
        private BindingList<City> _preferredCities;

        private Dictionary<string, string> weatherIconMap = new Dictionary<string, string>()
        {
            { "Cloudy", "img/cloudy_icon.png" },
            { "Partly", "img/partlycloudy_icon.png" },
            { "Rainy", "img/rainy_icon.png" },
            { "Snowy", "img/snowy_icon.png" },
            { "Sunny", "img/sunny_icon.png" },
            { "Windy", "img/partlycloudy_icon.png" },
            { "Hot", "img/sunny_icon.png" },
            { "Humid", "img/sunny_icon.png" },
            { "Clear", "img/sunny_icon.png" },
        };


        public MainForm()
        {
            InitializeComponent();
            InitializePictureBoxes();
            SetupDataGridView();

            _preferredCities =
                new BindingList<City>(
                    Database.Cities
                    .Where(c => Database.UserSetting.PreferredCities.Contains(c.Name))
                    .ToList()
                    );

            var firstCity = _preferredCities.FirstOrDefault().Name;
            var city = Database.Cities.FirstOrDefault(c => c.Name == firstCity);
            if (Database.UserSetting.DefaultTemperatureUnit == TemperatureUnit.Celsius) { isCelsius = true; }
            comboCity.DataSource = Database.Cities.Select(c => c.Name).ToList();
            comboCity.SelectedItem = firstCity;
            DisplayPreferredCities(_preferredCities);
            DisplayWeatherForCity(city);
            DisplayForcastHours(city.Forcastfor6Hours);


        }

        private void InitializePictureBoxes()
        {
            pictureBoxReal.Image = Image.FromFile("img/temperature_icon.png");
            pictureBoxUv.Image = Image.FromFile("img/Sun_icon.png");
            pictureBoxChance.Image = Image.FromFile("img/drop_water_icon.png");
            pictureBoxWind.Image = Image.FromFile("img/wind_icon.png");

        }

        private void SetupDataGridView()
        {
            dgvPreferred.RowHeadersVisible = false;
            dgvPreferred.DefaultCellStyle.BackColor = Color.FromArgb(32, 43, 59);       
            dgvPreferred.ColumnHeadersDefaultCellStyle.Font = new Font(dgvPreferred.Font, FontStyle.Bold);
            dgvPreferred.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPreferred.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 43, 59);
            dgvPreferred.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPreferred.DefaultCellStyle.ForeColor = Color.White;
            dgvPreferred.GridColor = Color.FromArgb(32, 43, 59);
            dgvPreferred.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvPreferred.Columns.Add("CityName", "City Name");
            dgvPreferred.Columns.Add("Temperature", "Temperature");
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgColumn.Name = "WeatherConditionImage";
            imgColumn.HeaderText = "Condition";
            dgvPreferred.Columns.Add(imgColumn);
        }

        private void DisplayPreferredCities(BindingList<City> preferredCities)
        {
            dgvPreferred.Rows.Clear(); // Clear existing rows

            foreach (var city in preferredCities)
            {
                int rowIndex = dgvPreferred.Rows.Add();
                dgvPreferred.Rows[rowIndex].Cells["CityName"].Value = city.Name;
                dgvPreferred.Rows[rowIndex].Cells["Temperature"].Value = FormatTemperature(Convert.ToDouble(city.CurrentWeather.Temperature));
                var weatherImage = Image.FromFile(weatherIconMap[city?.CurrentWeather.Condition.ToString()]);
                dgvPreferred.Rows[rowIndex].Cells["WeatherConditionImage"].Value = weatherImage;
            }
        }


        private void DisplayWeatherForCity(City city)
        {

            lblCityName.Text = city.Name;

            lblWeatherCondition.Text = city?.CurrentWeather.Condition.ToString();
            pictureBoxWeatherIcon.Image = Image.FromFile(weatherIconMap[city?.CurrentWeather.Condition.ToString()]);
            lblTemperature.Text = FormatTemperature(Convert.ToDouble(city?.CurrentWeather.Temperature));
            lblRealFeel.Text = FormatTemperature(Convert.ToDouble(city?.CurrentWeather.RealFeel));
            lblWind.Text = city?.CurrentWeather.WindSpeed.ToString() + " km/h";
            lblChanceRain.Text = city?.CurrentWeather.ChanceOfRain.ToString() + " %";
            lblUV.Text = city?.CurrentWeather.UVIndex.ToString();

        }


        private void DisplayForcastHours(List<WeatherData> forecast)
        {
            // Map forecast to UI elements
            Label[] lblTemps = { lbltemp1, lbltemp2, lbltemp3, lbltemp4, lbltemp5, lbltemp6 };
            Label[] lblHours = { lblHour1, lblHour2, lblHour3, lblHour4, lblHour5, lblHour6 };
            PictureBox[] picBoxes = { picBoxHour1, picBoxHour2, picBoxHour3, picBoxHour4, picBoxHour5, picBoxHour6 };

            DateTime currentTime = DateTime.Now;
            // Update the UI for each hour
            for (int i = 0; i < forecast.Count; i++)
            {
                lblTemps[i].Text = FormatTemperature(Convert.ToDouble(forecast[i].Temperature));

                // Update hour label (e.g., "1 PM", "2 PM")
                lblHours[i].Text = currentTime.AddHours(i + 1).ToString("h tt");
                picBoxes[i].Image = Image.FromFile(weatherIconMap[forecast[i].Condition.ToString()]);

            }

        }

        private string FormatTemperature(double temperature)
        {
            return isCelsius
                ? $"{temperature} °C"
                : $"{WeatherService.ConvertToFahrenheit(temperature):0.0} °F";
        }

        private void btnToggleUnit_Click(object sender, EventArgs e)
        {
            isCelsius = !isCelsius;
            var city = Database.Cities.FirstOrDefault(c => c.Name == lblCityName.Text);
            DisplayWeatherForCity(city);
            DisplayForcastHours(city.Forcastfor6Hours);
            DisplayPreferredCities(_preferredCities);

        }

        private void comboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cityName = comboCity?.SelectedItem?.ToString() ?? _preferredCities.FirstOrDefault().ToString();
            var city = Database.Cities.FirstOrDefault(c => c.Name == cityName);

            DisplayWeatherForCity(city);
            DisplayForcastHours(city.Forcastfor6Hours);
        }

        private void dgvPreferred_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedCity = dgvPreferred.Rows[e.RowIndex].Cells["CityName"].Value.ToString();
                int cityIndex = comboCity.Items.IndexOf(selectedCity);
                if (cityIndex >= 0)
                {
                    comboCity.SelectedIndex = cityIndex;
                    comboCity_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
        }

        private void btnAddPreferred_Click(object sender, EventArgs e)
        {
            var selectedCityName = comboCity.SelectedItem.ToString();
            City selectedCity = Database.Cities.FirstOrDefault(c => c.Name == selectedCityName);

            if (selectedCity != null)
            {
                bool cityExists = _preferredCities.Any(c => c.Name == selectedCity.Name);
                if (cityExists)
                {
                    MessageBox.Show($"{selectedCity.Name} is already in your preferred cities list.");
                }
                else
                {
                    _preferredCities.Add(selectedCity);
                    DisplayPreferredCities(_preferredCities);
                }
            }
        }

        private void btnRemovePreferred_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow selectedRow in dgvPreferred.SelectedRows)
            {
                string selectedCityName = selectedRow.Cells["CityName"].Value.ToString();
                City cityToRemove = _preferredCities.FirstOrDefault(c => c.Name.Equals(selectedCityName, StringComparison.OrdinalIgnoreCase));

                if (cityToRemove != null)
                {
                    _preferredCities.Remove(cityToRemove);
                    DisplayPreferredCities(_preferredCities);
                }
            }
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            Database.UserSetting.PreferredCities = new HashSet<string>(_preferredCities.Select(c => c.Name));
            Database.UserSetting.DefaultTemperatureUnit = isCelsius ? TemperatureUnit.Celsius : TemperatureUnit.Fahrenheit;

            Database.SaveSetting();
            MessageBox.Show("Settings have been saved successfully.");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save your settings?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Database.UserSetting.PreferredCities = new HashSet<string>(_preferredCities.Select(c => c.Name));
                Database.UserSetting.DefaultTemperatureUnit = isCelsius ? TemperatureUnit.Celsius : TemperatureUnit.Fahrenheit;
                Database.SaveSetting();
            }
            else if (result == DialogResult.No)
            {

            }
            else
            {
                e.Cancel = true;
            }

        }

    }
}
