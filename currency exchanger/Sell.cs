using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace currency_exchanger
{
    public partial class Sell : Form
    {
        private Start form1;
        public Sell(Start form1)
        {
            InitializeComponent();
            this.form1 = form1;
            comboBox1.SelectedIndex = 0;
        }
        List<ExchangeRatesAPI.ExchangeRatePB> rates;
        private bool validInput = true;
        double result;
        private void Form3_Load(object sender, EventArgs e)
        {
            ExchangeRatesAPI api = new ExchangeRatesAPI();
            rates = api.GetCombinedExchangeRates();
            button1.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int selectedIndex = comboBox1.SelectedIndex;
            string selectedText = comboBox1.Text;
            string firstThreeCharacters = selectedText.Substring(0, 3);
            if (comboBox1.SelectedIndex != -1 && validInput)
            {
                textBox1.Text = (rates[selectedIndex].Buy * result).ToString() + "UAH";
                Logger logger = new Logger();
                logger.WriteLog(false, date, (double)(rates[selectedIndex].Buy), (double)(rates[selectedIndex].Buy * result), result, firstThreeCharacters);
            }
            else
            {
                MessageBox.Show("Помилка: введено неприпустимий символ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out result) && (textBox2.Text != ",") && (string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                button1.Enabled = false;
                validInput = false;
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                button1.Enabled = true;
                validInput = true;
                textBox2.ForeColor = Color.Black;
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
