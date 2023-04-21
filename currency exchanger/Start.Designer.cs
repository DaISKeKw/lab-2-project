namespace currency_exchanger
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.Sell = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(12, 12);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(109, 53);
            this.Buy.TabIndex = 4;
            this.Buy.Text = "Купити";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(127, 12);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(109, 53);
            this.Sell.TabIndex = 5;
            this.Sell.Text = "Продати";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(12, 73);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(109, 53);
            this.Chart.TabIndex = 6;
            this.Chart.Text = "Графіки";
            this.Chart.UseVisualStyleBackColor = true;
            this.Chart.Click += new System.EventHandler(this.Chart_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(127, 73);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(109, 53);
            this.Log.TabIndex = 7;
            this.Log.Text = "Історія дій";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.History_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 177);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Text = "Конвертор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Button Chart;
        private System.Windows.Forms.Button Log;
    }
}

