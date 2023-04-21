using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace currency_exchanger
{
    public partial class Log : Form
    {
        private Start form1;
        private List<Logger.ExchangeRate_DealSize> log;
        public Log(Start form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            LoadLogFromFile();
            UpdateLabels();
        }
        private void LoadLogFromFile()
        {
           log = new List<Logger.ExchangeRate_DealSize>();
            if (File.Exists("log.json"))
            {
                var json = File.ReadAllText("log.json");
                log = JsonConvert.DeserializeObject<List<Logger.ExchangeRate_DealSize>>(json);
            }
        }
        private void UpdateLabels()
        {
            const int labelHeight = 20;
            const int margin = 10;

            var y = margin;
            foreach (var entry in log)
            {
                var groupBox = new GroupBox();
                groupBox.AutoSize = true;
                groupBox.Location = new Point(margin, y);

                var operationLabel = new Label();
                operationLabel.Text = $"Операція здійснена {entry.Time}";
                operationLabel.Location = new Point(margin, margin + labelHeight);
                operationLabel.AutoSize = true;
                groupBox.Controls.Add(operationLabel);

                var actionLabel = new Label();
                if(entry.Action == false)
                    actionLabel.ForeColor = Color.Red;
                else
                    actionLabel.ForeColor = Color.Green;
                actionLabel.Text = $"Дія: {(entry.Action ? "Купівля" : "Продаж")}";
                actionLabel.Location = new Point(margin, margin + labelHeight * 2);
                actionLabel.AutoSize = true;
                groupBox.Controls.Add(actionLabel);

                var exchangeRateLabel = new Label();
                exchangeRateLabel.Text = $"Курс обміну: {entry.ExchangeRate}";
                exchangeRateLabel.Location = new Point(margin, margin + labelHeight * 3);
                exchangeRateLabel.AutoSize = true;
                groupBox.Controls.Add(exchangeRateLabel);

                var convertedValueLabel = new Label();
                convertedValueLabel.Text = $"Обміняна валюта: {entry.Converted_Value}{entry.Ccy}";
                convertedValueLabel.Location = new Point(margin, margin + labelHeight * 4);
                convertedValueLabel.AutoSize = true;
                groupBox.Controls.Add(convertedValueLabel);

                var dealSizeLabel = new Label();
                dealSizeLabel.Text = $"Сума після обміну: {entry.DealSize}UAH";
                dealSizeLabel.Location = new Point(margin, margin + labelHeight * 5);
                dealSizeLabel.AutoSize = true;
                groupBox.Controls.Add(dealSizeLabel);


                y += groupBox.Height + margin;

                Controls.Add(groupBox);

                LOG1.Controls.Add(groupBox);
            }
            LOG1.AutoScrollPosition = new Point(0, LOG1.VerticalScroll.Maximum);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("log.json");
            Application.Restart();
        }
    }
}
