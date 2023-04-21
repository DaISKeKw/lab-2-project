using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace currency_exchanger
{
    internal class ExchangeRatesAPI
    {
        private const string ExchangeRatesURL1 = "https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=11";
        private const string ExchangeRatesURL2 = "https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=12";   
        public class ExchangeRatePB
        {
            public string Base_ccy { get; set; }
            public string Ccy { get; set; }
            public double Buy { get; set; }
            public double Sale { get; set; }
        }
        public class ExchangeRateAtTheDate
        {
            public string Date { get; set; }
            public string Bank { get; set; }
            public double BaseCurrency { get; set; }
            public string BaseCurrencyLit { get; set; }
            public List<ExchangeRateNB> ExchangeRate { get; set; }
        }

        public class ExchangeRateNB
        {
            public string BaseCurrency { get; set; }
            public string Currency { get; set; }
            public double SaleRateNB { get; set; }
            public double PurchaseRateNB { get; set; }
            public double? SaleRate { get; set; }
            public double? PurchaseRate { get; set; }
        }


        private List<ExchangeRatePB> GetExchangeRates(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.Execute<List<ExchangeRatePB>>(request);


            if (response.IsSuccessful)
                return response.Data;
            return null;
        }

        public List<ExchangeRatePB> GetCombinedExchangeRates()
        {
            var combinedRates = new List<ExchangeRatePB>();
            var rates1 = GetExchangeRates(ExchangeRatesURL1);
            var rates2 = GetExchangeRates(ExchangeRatesURL2);

            combinedRates.AddRange(rates1);
            combinedRates.AddRange(rates2);

            if (combinedRates.Count == 0)
            {
                MessageBox.Show("An error occurred while retrieving exchange rates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return combinedRates;
        }

        public async Task<ExchangeRateAtTheDate> GetExchangeRatesByDate(DateTime date)
        {
            var dateString = date.ToString("dd.MM.yyyy");
            var url = $"https://api.privatbank.ua/p24api/exchange_rates?json&date={dateString}";

            var client = new RestClient(url);
            var request = new RestRequest();
            request.RequestFormat = DataFormat.Json;
            var response = await client.ExecuteAsync<ExchangeRateAtTheDate>(request);

            if (response.IsSuccessful)
                return response.Data;
            return null;
        }
    }
}