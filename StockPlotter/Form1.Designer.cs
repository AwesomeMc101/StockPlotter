
namespace StockPlotter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ADX_checkbox = new System.Windows.Forms.CheckBox();
            this.obv_checkbox = new System.Windows.Forms.CheckBox();
            this.ema_checkbox = new System.Windows.Forms.CheckBox();
            this.aroon_checkbox = new System.Windows.Forms.CheckBox();
            this.macdext_checkbox = new System.Windows.Forms.CheckBox();
            this.ALTTICKERBOX = new System.Windows.Forms.TextBox();
            this.altstock_checkbox = new System.Windows.Forms.CheckBox();
            this.cci_checkbox = new System.Windows.Forms.CheckBox();
            this.sma_checkbox = new System.Windows.Forms.CheckBox();
            this.rsi_checkbox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KEY = new System.Windows.Forms.TextBox();
            this.TICKER = new System.Windows.Forms.TextBox();
            this.INDICATOR = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INTERVAL = new System.Windows.Forms.ComboBox();
            this.AMOUNT = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMOUNT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centauri Analytics - Stock Plotter v.01";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(2, 64);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.SaddleBrown,
        System.Drawing.Color.Gold,
        System.Drawing.Color.ForestGreen,
        System.Drawing.Color.LightSeaGreen,
        System.Drawing.Color.Orchid};
            this.chart1.Size = new System.Drawing.Size(451, 430);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.KEY);
            this.groupBox1.Controls.Add(this.TICKER);
            this.groupBox1.Controls.Add(this.INDICATOR);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.INTERVAL);
            this.groupBox1.Controls.Add(this.AMOUNT);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Sans Serif Collection", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(459, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ADX_checkbox);
            this.groupBox2.Controls.Add(this.obv_checkbox);
            this.groupBox2.Controls.Add(this.ema_checkbox);
            this.groupBox2.Controls.Add(this.aroon_checkbox);
            this.groupBox2.Controls.Add(this.macdext_checkbox);
            this.groupBox2.Controls.Add(this.ALTTICKERBOX);
            this.groupBox2.Controls.Add(this.altstock_checkbox);
            this.groupBox2.Controls.Add(this.cci_checkbox);
            this.groupBox2.Controls.Add(this.sma_checkbox);
            this.groupBox2.Controls.Add(this.rsi_checkbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 185);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comparisons";
            // 
            // ADX_checkbox
            // 
            this.ADX_checkbox.AutoSize = true;
            this.ADX_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADX_checkbox.Location = new System.Drawing.Point(202, 103);
            this.ADX_checkbox.Name = "ADX_checkbox";
            this.ADX_checkbox.Size = new System.Drawing.Size(68, 31);
            this.ADX_checkbox.TabIndex = 21;
            this.ADX_checkbox.Text = "ADX";
            this.ADX_checkbox.UseVisualStyleBackColor = true;
            // 
            // obv_checkbox
            // 
            this.obv_checkbox.AutoSize = true;
            this.obv_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obv_checkbox.Location = new System.Drawing.Point(107, 103);
            this.obv_checkbox.Name = "obv_checkbox";
            this.obv_checkbox.Size = new System.Drawing.Size(69, 31);
            this.obv_checkbox.TabIndex = 20;
            this.obv_checkbox.Text = "OBV";
            this.obv_checkbox.UseVisualStyleBackColor = true;
            // 
            // ema_checkbox
            // 
            this.ema_checkbox.AutoSize = true;
            this.ema_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ema_checkbox.Location = new System.Drawing.Point(21, 103);
            this.ema_checkbox.Name = "ema_checkbox";
            this.ema_checkbox.Size = new System.Drawing.Size(69, 31);
            this.ema_checkbox.TabIndex = 19;
            this.ema_checkbox.Text = "EMA";
            this.ema_checkbox.UseVisualStyleBackColor = true;
            // 
            // aroon_checkbox
            // 
            this.aroon_checkbox.AutoSize = true;
            this.aroon_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aroon_checkbox.Location = new System.Drawing.Point(154, 66);
            this.aroon_checkbox.Name = "aroon_checkbox";
            this.aroon_checkbox.Size = new System.Drawing.Size(97, 31);
            this.aroon_checkbox.TabIndex = 18;
            this.aroon_checkbox.Text = "AROON";
            this.aroon_checkbox.UseVisualStyleBackColor = true;
            this.aroon_checkbox.CheckedChanged += new System.EventHandler(this.aroon_checkbox_CheckedChanged);
            // 
            // macdext_checkbox
            // 
            this.macdext_checkbox.AutoSize = true;
            this.macdext_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macdext_checkbox.Location = new System.Drawing.Point(21, 66);
            this.macdext_checkbox.Name = "macdext_checkbox";
            this.macdext_checkbox.Size = new System.Drawing.Size(119, 31);
            this.macdext_checkbox.TabIndex = 17;
            this.macdext_checkbox.Text = "MACDEXT";
            this.macdext_checkbox.UseVisualStyleBackColor = true;
            // 
            // ALTTICKERBOX
            // 
            this.ALTTICKERBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ALTTICKERBOX.Cursor = System.Windows.Forms.Cursors.No;
            this.ALTTICKERBOX.Font = new System.Drawing.Font("Sans Serif Collection", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALTTICKERBOX.Location = new System.Drawing.Point(130, 147);
            this.ALTTICKERBOX.MaxLength = 6;
            this.ALTTICKERBOX.Name = "ALTTICKERBOX";
            this.ALTTICKERBOX.ReadOnly = true;
            this.ALTTICKERBOX.Size = new System.Drawing.Size(140, 30);
            this.ALTTICKERBOX.TabIndex = 16;
            this.ALTTICKERBOX.Text = "Alt Ticker...";
            // 
            // altstock_checkbox
            // 
            this.altstock_checkbox.AutoSize = true;
            this.altstock_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altstock_checkbox.Location = new System.Drawing.Point(21, 147);
            this.altstock_checkbox.Name = "altstock_checkbox";
            this.altstock_checkbox.Size = new System.Drawing.Size(103, 31);
            this.altstock_checkbox.TabIndex = 3;
            this.altstock_checkbox.Text = "Alt. Stock";
            this.altstock_checkbox.UseVisualStyleBackColor = true;
            this.altstock_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cci_checkbox
            // 
            this.cci_checkbox.AutoSize = true;
            this.cci_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cci_checkbox.Location = new System.Drawing.Point(209, 28);
            this.cci_checkbox.Name = "cci_checkbox";
            this.cci_checkbox.Size = new System.Drawing.Size(61, 31);
            this.cci_checkbox.TabIndex = 2;
            this.cci_checkbox.Text = "CCI";
            this.cci_checkbox.UseVisualStyleBackColor = true;
            // 
            // sma_checkbox
            // 
            this.sma_checkbox.AutoSize = true;
            this.sma_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sma_checkbox.Location = new System.Drawing.Point(107, 28);
            this.sma_checkbox.Name = "sma_checkbox";
            this.sma_checkbox.Size = new System.Drawing.Size(69, 31);
            this.sma_checkbox.TabIndex = 1;
            this.sma_checkbox.Text = "SMA";
            this.sma_checkbox.UseVisualStyleBackColor = true;
            this.sma_checkbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rsi_checkbox
            // 
            this.rsi_checkbox.AutoSize = true;
            this.rsi_checkbox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsi_checkbox.Location = new System.Drawing.Point(21, 28);
            this.rsi_checkbox.Name = "rsi_checkbox";
            this.rsi_checkbox.Size = new System.Drawing.Size(60, 31);
            this.rsi_checkbox.TabIndex = 0;
            this.rsi_checkbox.Text = "RSI";
            this.rsi_checkbox.UseVisualStyleBackColor = true;
            this.rsi_checkbox.CheckedChanged += new System.EventHandler(this.rsi_checkbox_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(350, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 38);
            this.button4.TabIndex = 14;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(99, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "Save Chart Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "AlphaVantage API Key (2 calls)";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // KEY
            // 
            this.KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KEY.Location = new System.Drawing.Point(6, 339);
            this.KEY.Name = "KEY";
            this.KEY.PasswordChar = '*';
            this.KEY.Size = new System.Drawing.Size(480, 39);
            this.KEY.TabIndex = 9;
            this.KEY.Text = "API Key...";
            // 
            // TICKER
            // 
            this.TICKER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TICKER.Location = new System.Drawing.Point(12, 35);
            this.TICKER.MaxLength = 6;
            this.TICKER.Name = "TICKER";
            this.TICKER.Size = new System.Drawing.Size(220, 39);
            this.TICKER.TabIndex = 8;
            this.TICKER.Text = "Stock Ticker...";
            this.TICKER.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // INDICATOR
            // 
            this.INDICATOR.FormattingEnabled = true;
            this.INDICATOR.Items.AddRange(new object[] {
            "RSI",
            "SMA"});
            this.INDICATOR.Location = new System.Drawing.Point(324, 172);
            this.INDICATOR.Name = "INDICATOR";
            this.INDICATOR.Size = new System.Drawing.Size(121, 40);
            this.INDICATOR.TabIndex = 6;
            this.INDICATOR.SelectedIndexChanged += new System.EventHandler(this.INDICATOR_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(421, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval";
            // 
            // INTERVAL
            // 
            this.INTERVAL.FormattingEnabled = true;
            this.INTERVAL.Items.AddRange(new object[] {
            "Minutes",
            "Days",
            "Months",
            "Years"});
            this.INTERVAL.Location = new System.Drawing.Point(243, 36);
            this.INTERVAL.Name = "INTERVAL";
            this.INTERVAL.Size = new System.Drawing.Size(121, 40);
            this.INTERVAL.TabIndex = 2;
            this.INTERVAL.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AMOUNT
            // 
            this.AMOUNT.Location = new System.Drawing.Point(375, 36);
            this.AMOUNT.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Size = new System.Drawing.Size(120, 39);
            this.AMOUNT.TabIndex = 1;
            this.AMOUNT.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(990, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Centauri Stock Plotter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMOUNT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox INTERVAL;
        private System.Windows.Forms.NumericUpDown AMOUNT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox INDICATOR;
        private System.Windows.Forms.TextBox KEY;
        private System.Windows.Forms.TextBox TICKER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox sma_checkbox;
        private System.Windows.Forms.CheckBox rsi_checkbox;
        private System.Windows.Forms.CheckBox cci_checkbox;
        private System.Windows.Forms.TextBox ALTTICKERBOX;
        private System.Windows.Forms.CheckBox altstock_checkbox;
        private System.Windows.Forms.CheckBox ADX_checkbox;
        private System.Windows.Forms.CheckBox obv_checkbox;
        private System.Windows.Forms.CheckBox ema_checkbox;
        private System.Windows.Forms.CheckBox aroon_checkbox;
        private System.Windows.Forms.CheckBox macdext_checkbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

