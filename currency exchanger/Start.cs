using System;
using System.Windows.Forms;


namespace currency_exchanger
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Buy_Click(object sender, EventArgs e)
        {
            Buy Buy = new Buy(this);
            Buy.Show();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            Sell Sell = new Sell(this);
            Sell.Show();
        }

        private void Chart_Click(object sender, EventArgs e)
        {
            Chart Chart = new Chart(this);
            Chart.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            Log History = new Log(this);
            History.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
