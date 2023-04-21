using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace currency_exchanger
{
    internal class Logger
    {
        public class ExchangeRate_DealSize
        {
            [JsonProperty("action")]
            public bool Action { get; set; }

            [JsonProperty("time")]
            public DateTime Time { get; set; }

            [JsonProperty("exchangeRate")]
            public double ExchangeRate { get; set; }

            [JsonProperty("dealSize")]
            public double DealSize { get; set; }

            [JsonProperty("convertedValue")]
            public double Converted_Value { get; set; }

            [JsonProperty("сcy")]
            public string Ccy { get; set; }

        }

        public void WriteLog(bool action, DateTime time, double exchangeRate, double dealSize, double converted_Value, string ccy)
        {

            var exchangeRate_DealSize = new ExchangeRate_DealSize
            {
                Action = action,
                Time = time,
                ExchangeRate = exchangeRate,
                DealSize = dealSize,
                Converted_Value = converted_Value,
                Ccy = ccy
            };


            var log = new List<ExchangeRate_DealSize>();
            if (File.Exists("log.json"))
            {
                var json = File.ReadAllText("log.json");
                log = JsonConvert.DeserializeObject<List<ExchangeRate_DealSize>>(json);
            }

            log.Add(exchangeRate_DealSize);

            var newJson = JsonConvert.SerializeObject(log, Formatting.Indented);
            File.WriteAllText("log.json", newJson);

        }
    }
}
