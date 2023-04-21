using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static currency_exchanger.ExchangeRatesAPI;

namespace currency_exchanger
{
    public partial class Chart : Form
    {
        private Start form1;
        private ExchangeRateAtTheDate exchangeRates1;
        private ExchangeRateAtTheDate exchangeRates3;
        private ExchangeRateAtTheDate exchangeRates7;
        private ExchangeRateAtTheDate exchangeRates15;
        private ExchangeRateAtTheDate exchangeRates30;
        public Chart(Start form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            await Task.Run(() => LoadExchangeRatesAsync());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = comboBox1.Text;
            string firstThreeCharacters = selectedText.Substring(0, 3);
            double[] exchangeRates = process(firstThreeCharacters);
            cartesianChart1.Series.Clear();

            cartesianChart1.Series.Add(new LineSeries
            {
                Title = selectedText,
                Values = new ChartValues<ObservablePoint>
                {
                    new ObservablePoint(30, exchangeRates[4]),
                    new ObservablePoint(15, exchangeRates[3]),
                    new ObservablePoint(7, exchangeRates[2]),
                    new ObservablePoint(3, exchangeRates[1]),
                    new ObservablePoint(1, exchangeRates[0])
                },
                PointGeometrySize = 15
            });


        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private double[] process(string firstThreeCharacters)
        {
            double[] rates = new double[5];
            int index = exchangeRates1.ExchangeRate.FindIndex(rate => rate.Currency == firstThreeCharacters);
            rates[0] = exchangeRates1.ExchangeRate[index].SaleRateNB;
            index = exchangeRates3.ExchangeRate.FindIndex(rate => rate.Currency == firstThreeCharacters);
            rates[1] = exchangeRates3.ExchangeRate[index].SaleRateNB;
            index = exchangeRates7.ExchangeRate.FindIndex(rate => rate.Currency == firstThreeCharacters);
            rates[2] = exchangeRates7.ExchangeRate[index].SaleRateNB;
            index = exchangeRates15.ExchangeRate.FindIndex(rate => rate.Currency == firstThreeCharacters);
            rates[3] = exchangeRates15.ExchangeRate[index].SaleRateNB;
            index = exchangeRates30.ExchangeRate.FindIndex(rate => rate.Currency == firstThreeCharacters);
            rates[4] = exchangeRates30.ExchangeRate[index].SaleRateNB;

            return rates;
        }
        private async Task LoadExchangeRatesAsync()
        {
            DateTime date = DateTime.Today;
            var api = new ExchangeRatesAPI();

            try
            {
                comboBox1.Enabled = false;
                labelstatus.Visible = true;
                exchangeRates1 = await api.GetExchangeRatesByDate(date.AddDays(-1));
                Thread.Sleep(100);
                exchangeRates3 = await api.GetExchangeRatesByDate(date.AddDays(-3));
                Thread.Sleep(100);
                exchangeRates7 = await api.GetExchangeRatesByDate(date.AddDays(-7));
                Thread.Sleep(100);
                exchangeRates15 = await api.GetExchangeRatesByDate(date.AddDays(-15));
                Thread.Sleep(100);
                exchangeRates30 = await api.GetExchangeRatesByDate(date.AddDays(-30));
                comboBox1.Enabled = true;
                labelstatus.Text = "Оберіть валюту";
                labelstatus.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка завантаження курсів валют. Спробуйте ще раз пізніше або зверніться до служби підтримки.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}