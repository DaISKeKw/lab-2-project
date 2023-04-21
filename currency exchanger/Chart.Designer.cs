namespace currency_exchanger
{
    partial class Chart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.labelstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AUD (австралійський долар, Австралія)",
            "AZN (азербайджанський манат, Азербайджан)",
            "BYN (білоруський рубль, Білорусь)",
            "CAD (канадський долар, Канада)",
            "CHF (швейцарський франк, Швейцарія)",
            "CNY (китайський юань, Китай)",
            "CZK (чеська крона, Чехія)",
            "DKK (данська крона, Данія)",
            "EUR (євро, Європейський Союз)",
            "GBP (фунт стерлінгів, Велика Британія)",
            "GEL (грузинський ларі, Грузія)",
            "HUF (угорський форинт, Угорщина)",
            "ILS (ізраїльський новий шекель, Ізраїль)",
            "JPY (японська єна, Японія)",
            "KZT (казахстанський тенге, Казахстан)",
            "MDL (молдовський лей, Молдова)",
            "NOK (норвезька крона, Норвегія)",
            "PLN (польський злотий, Польща)",
            "SEK (шведська крона, Швеція)",
            "SGD (сінгапурський долар, Сінгапур)",
            "TMT (туркменський новий манат, Туркменістан)",
            "TRY (турецька ліра, Туреччина)",
            "USD (долар США, Сполучені Штати Америки)",
            "UZS (узбецький сум, Узбекистан)",
            "XAU (золото)"});
            this.comboBox1.Location = new System.Drawing.Point(106, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(545, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(39, 105);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(871, 333);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // labelstatus
            // 
            this.labelstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstatus.ForeColor = System.Drawing.Color.Red;
            this.labelstatus.Location = new System.Drawing.Point(673, 39);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(176, 24);
            this.labelstatus.TabIndex = 10;
            this.labelstatus.Text = "Йде завантаження";
            this.labelstatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 350);
            this.Name = "Chart";
            this.Text = "Графіки";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label labelstatus;
    }
}