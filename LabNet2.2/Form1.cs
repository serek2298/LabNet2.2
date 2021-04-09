using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Globalization;
using System.Data.Entity;

namespace LabNet2._2
{
    public partial class Form1 : Form
    {
        RecordsCurrencyExchange dataBase = new RecordsCurrencyExchange();
        DateTime currentTime = new DateTime();
        int timeStamp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public async void load()
        {
            string call = "https://openexchangerates.org/api/latest.json?app_id=1c20a8ea81d5429cbf2fdc8fa15816a7";
            HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(call);
            Console.WriteLine(json);
           
            var data = JsonConvert.DeserializeObject<ExchangeRateFromApi>(json);

            foreach (var x in data.Rates)
            {
                ListViewItem a = new ListViewItem(x.Key);
                a.SubItems.Add(x.Value.ToString());
                listView1.Items.Add(a);
            }
            foreach(var item in data.Rates.Keys)
            {
                comboBoxChooseCurrency.Items.Add(item);
                comboBoxToFindCurrency.Items.Add(item);
            }
            timeStamp = data.timeStamp;
            currentTime = UnixTimeToDateTime(data.timeStamp);
            textBoxtimeStamp.Text = UnixTimeToDateTime(data.timeStamp).ToString();
        }
        /// <summary>
        /// This function allow convert unix time - int to available date to read by human
        /// </summary>
        /// <param name="unixtime"></param>
        /// <returns></returns>
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            comboBoxChooseCurrency.Text = this.listView1.SelectedItems[0].Text;

        }

        

        private void comboBoxChooseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRateOfThisCurrency.Text = listView1.Items[comboBoxChooseCurrency.SelectedIndex].SubItems[1].Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRateOfThisCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            provider.NumberGroupSeparator = " ";
            int numberWritten = Int32.Parse(textBox1.Text);
            double exchangeRate = float.Parse(textBoxRateOfThisCurrency.Text,provider);
            textBoxResultOfCalculating.Text = (numberWritten * exchangeRate).ToString();
        }

        

        private void buttonSaveToDataBase_Click(object sender, EventArgs e)
        {
            string strCurrency  =  listView1.Items[comboBoxChooseCurrency.SelectedIndex].SubItems[0].Text;

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            provider.NumberGroupSeparator = " ";

            int numberWritten = Int32.Parse(textBox1.Text);
            double exchangeRate = Double.Parse(textBoxRateOfThisCurrency.Text.ToString(), provider);
            double result = Double.Parse(textBoxResultOfCalculating.Text, provider);


            SingleCurrencyExchange singleRecord = new SingleCurrencyExchange(timeStamp, strCurrency, exchangeRate, numberWritten, result);
            dataBase.SingleCurrencyExchanges.Add(singleRecord);
            dataBase.SaveChanges();         

        }

        private void textBoxtimeStamp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonToShowHistory_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataBase.SingleCurrencyExchanges.ToList<SingleCurrencyExchange>();
        }

        private void comboBoxToFindCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currencyName = listView1.Items[comboBoxChooseCurrency.SelectedIndex].SubItems[0].Text;
            dataGridView2.DataSource = dataBase.SingleCurrencyExchanges.SqlQuery("select * from SingleCurrencyExchanges where nameOfCurrency = @p0", currencyName).ToList<SingleCurrencyExchange>();
        }
    }
}
