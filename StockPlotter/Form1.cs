using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Centauri Analytics v0.1 by AwesomeMc101\n\nThank you for using!", "Centauri");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AMOUNT.Value = 0;
            TICKER.Text = "";
            KEY.Text = "";
            ALTTICKERBOX.Text = "";

            rsi_checkbox.Checked = false;
            sma_checkbox.Checked = false;
            cci_checkbox.Checked = false;
            macdext_checkbox.Checked = false;
            aroon_checkbox.Checked = false;
            ema_checkbox.Checked = false;
            obv_checkbox.Checked = false;
            ADX_checkbox.Checked = false;
            altstock_checkbox.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the amount of datapoints you want from your specified interval.\n\nFor example, you may enter 31 if you do days to receive 1 month of data.", "Centauri");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        static int get_interval(string iv)
        {
            switch (iv[0])
            {
                case 'M':
                    return (iv[1] == 'o' ? 0 : 2); //0 month, 2 minute
                    break;
                case 'D':
                    return 1;
                    break;
                case 'Y':
                    return 3;
                    break;
            }
            return 0;
            
        }

        private List<double> get_prices(string downloaded_data)
        {
        
            //custom parser cuz i only know C++!
            List<double> tuple_list = new List<double>();
            string ol = "";
            using (StringReader reader = new StringReader(downloaded_data))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if(line.Contains("1. open"))
                        {
                            string snipped = line.Substring(line.IndexOf('n'));
                            StringBuilder result = new StringBuilder(); 
                            for (int i = 0; i < snipped.Length; i++)
                            { 
                                if (Char.IsDigit(snipped[i]) || snipped[i] == '.') { 
                                    result.Append(snipped[i]);
                                } 
                            }
                            string lol = result.ToString();
                            if (double.TryParse(lol, out double numericValue))
                            {
                                tuple_list.Add(double.Parse(lol));
                            }
                        }
                        else
                        {
                            ol = line;
                        }
                    }

                } while (line != null);
            }
          //  label5.Text = tuple_list.Count().ToString();
            return tuple_list;
        }
        private List<double> get_ind(string searcher, string downloaded_data)
        {

            //custom parser cuz i only know C++!
            List<double> tuple_list = new List<double>();
            string ol = "";
            using (StringReader reader = new StringReader(downloaded_data))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (line.Contains(searcher))
                        {
                            string snipped = line;
                            StringBuilder result = new StringBuilder();
                            for (int i = 0; i < snipped.Length; i++)
                            {
                                if (Char.IsDigit(snipped[i]) || snipped[i] == '.')
                                {
                                    result.Append(snipped[i]);
                                }
                            }
                            string lol = result.ToString();
                            if (double.TryParse(lol, out double numericValue))
                            {
                                tuple_list.Add(double.Parse(lol));
                            }
                          
                        }
                        else
                        {
                            ol = line;
                        }
                    }

                } while (line != null);
            }
            //  label5.Text = tuple_list.Count().ToString();
            return tuple_list;
        }
        private int min(int a, int b, int c)
        {
            int cc = (a < b ? a : b);
            return (c < cc ? c : cc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            //string type = INDICATOR.SelectedItem.ToString();
            int interval = get_interval(INTERVAL.SelectedItem.ToString());
            string str_interval = "";
            switch (interval)
            {
                case 0://month
                    str_interval = "monthly";
                    break;
                case 1://day
                    str_interval = "daily";
                    break;
                case 2: //minute
                case 3:
                    str_interval = "1min";
                    break;
           
            }
            int amount = (int)AMOUNT.Value;

            string ticker = TICKER.Text;
            string apikey = KEY.Text;

            string prices_url = "";// "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&outputsize=full&symbol=" + ticker + "&apikey=" + apikey;
            switch (interval)
            {
                case 0://month
                    prices_url = "https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&outputsize=full&symbol=" + ticker + "&apikey=" + apikey;
                    break;
                case 1://day
                    prices_url = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&outputsize=full&symbol=" + ticker + "&apikey=" + apikey;
                    break;
                case 2: //minute
                case 3:
                    prices_url = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&interval=1min&outputsize=full&symbol=" + ticker + "&apikey=" + apikey;
                    break;
            }
            string contents;
            using (var wc = new System.Net.WebClient())
                contents = wc.DownloadString(prices_url);
            List<double> prices = get_prices(contents);
            chart1.Titles.Add(ticker + " data.");
            Series s = chart1.Series.Add("Prices");
           
        

            for (int i = 0; i < (prices.Count < amount ? prices.Count : amount); i++)
            {
                s.Points.AddXY(i + 1, prices[i]);
            }
            chart1.ChartAreas[0].AxisY.Minimum = prices.Min() / 1.2; //dont need 0->max price ngl
            chart1.ChartAreas[0].AxisY.RoundAxisValues();

            List<double> indvals = new List<double>();
            if (rsi_checkbox.Checked)
            {
                string datafr = "";
                string rsi_url = "https://www.alphavantage.co/query?function=RSI&interval=" + str_interval + "&time_period=10&series_type=open&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(rsi_url);

                indvals = get_ind("RSI", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("RSI");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;
            }
            if (sma_checkbox.Checked)
            {
                string datafr = "";
                string sma_url = "https://www.alphavantage.co/query?function=SMA&interval=" + str_interval + "&time_period=10&series_type=open&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(sma_url);

                indvals = get_ind("SMA", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("SMA");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }
            if (cci_checkbox.Checked)
            {
                string datafr = "";
                string sma_url = "https://www.alphavantage.co/query?function=CCI&interval=" + str_interval + "&time_period=10&series_type=open&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(sma_url);

                indvals = get_ind("CCI", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("CCI");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }
            if (macdext_checkbox.Checked)
            {
                string datafr = "";
                string sma_url = "https://www.alphavantage.co/query?function=MACDEXT&interval=" + str_interval + "&time_period=10&series_type=open&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(sma_url);

                indvals = get_ind("MACDEXT", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("MACDEXT");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }
            if (aroon_checkbox.Checked)
            {
                string datafr = "";
                string sma_url = "https://www.alphavantage.co/query?function=AROON&interval=" + str_interval + "&time_period=10&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(sma_url);

                indvals = get_ind("AROON", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("AROON");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }
            if (ema_checkbox.Checked)
            {
                string datafr = "";
                string sma_url = "https://www.alphavantage.co/query?function=EMA&interval=" + str_interval + "&time_period=10&series_type=open&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(sma_url);

                indvals = get_ind("EMA", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("EMA");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }
            if (obv_checkbox.Checked)
            {
                string datafr = "";
                string sma_url = "https://www.alphavantage.co/query?function=AROON&interval=" + str_interval + "&time_period=10&series_type=open&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(sma_url);

                indvals = get_ind("OBV", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("OBV");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }
            if (ADX_checkbox.Checked)
            {
                string datafr = "";
                string sma_url = "https://www.alphavantage.co/query?function=AROON&interval=" + str_interval + "&time_period=10&series_type=open&symbol=" + ticker + "&apikey=" + apikey;
                using (var wc = new System.Net.WebClient())
                    datafr = wc.DownloadString(sma_url);

                indvals = get_ind("ADX", datafr);
                if (indvals.Count() > 0)
                {
                    indvals.RemoveAt(0);
                }

                Series r = chart1.Series.Add("ADX");
                for (int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
                {
                    r.Points.AddXY(i + 1, indvals[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }
            if (altstock_checkbox.Checked)
            {
                string alt_ticker = ALTTICKERBOX.Text;
                string alt_prices_url = "";// "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&outputsize=full&symbol=" + ticker + "&apikey=" + apikey;
                switch (interval)
                {
                    case 0://month
                        alt_prices_url = "https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&outputsize=full&symbol=" + alt_ticker + "&apikey=" + apikey;
                        break;
                    case 1://day
                        alt_prices_url = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&outputsize=full&symbol=" + alt_ticker + "&apikey=" + apikey;
                        break;
                    case 2: //minute
                    case 3:
                        alt_prices_url = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&interval=1min&outputsize=full&symbol=" + alt_ticker + "&apikey=" + apikey;
                        break;
                }
                string alt_contents;
                using (var wc = new System.Net.WebClient())
                    alt_contents = wc.DownloadString(alt_prices_url);
                List<double> alt_prices = get_prices(alt_contents);
             
                Series r = chart1.Series.Add(alt_ticker);
                chart1.ChartAreas.Last().AxisY2.Minimum = alt_prices.Min() / 1.5; //dont need 0->max price ngl
                                                                                  //  chart1.ChartAreas.Last().AxisY2.RoundAxisValues();
              

                for (int i = 0; i < min(prices.Count, amount, alt_prices.Count); i++)
                {
                    r.Points.AddXY(i + 1, alt_prices[i]);
                }
                r.YAxisType = AxisType.Secondary;

            }


            // s.Points.Add(prices.ToArray());
            s.XAxisType = AxisType.Primary;
            s.XValueType = ChartValueType.Auto;

            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
            chart1.ChartAreas[0].AxisY2.LabelStyle.Format = "0.00";
            //chart1.ChartAreas[0].AxisY2.Minimum = indvals.Min() / 1.5; //dont need 0->max price ngl
            //chart1.ChartAreas[0].AxisY2.RoundAxisValues();


            // s.Points.
            //for(int i = 0; i < min(prices.Count, amount, indvals.Count); i++)
            // {
            //     s.Points.AddXY(i+1, prices[i]);
            //     r.Points.AddXY(i + 1, indvals[i]);
            // }


            //label4.Text = prices.Count().ToString();
            // label5.Text = type;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void INDICATOR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.SaveImage(DateTime.Now.ToLongDateString() + DateTime.Now.TimeOfDay.TotalSeconds.ToString() + ".png", ChartImageFormat.Png);
            MessageBox.Show("Saved successfully to file '" + DateTime.Now.ToLongDateString() + DateTime.Now.TimeOfDay.TotalSeconds.ToString() + ".png'", "Centauri");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Firstly, select a value to compare to under the compare dropbox.", "Centauri Help");
            MessageBox.Show("Next, select a time interval between each datapoint. Want daily prices? Select day.", "Centauri Help");
            MessageBox.Show("Then, select the amount of data you'd like to visualize.", "Centauri Help");
            MessageBox.Show("Enter the stock ticker from which you'd like to get the data.", "Centauri Help");
            MessageBox.Show("Lastly, input a valid AlphaVantage API key.\nYou can get one for free at alphavantage.co.", "Centauri Help");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!altstock_checkbox.Checked)
            {
                ALTTICKERBOX.ReadOnly = true;
                ALTTICKERBOX.Cursor = Cursors.No;
            }
            else
            {
                ALTTICKERBOX.ReadOnly = false;
                ALTTICKERBOX.Cursor = Cursors.IBeam;
            }
        }

        private void rsi_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using Centauri StockPlotter!", "Centauri");
        }

        private void topMostToggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void aroon_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
