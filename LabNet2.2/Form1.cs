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
//migrowanie bazy danych:
//https://docs.microsoft.com/pl-pl/ef/core/managing-schemas/migrations/?tabs=vs&fbclid=IwAR3kkGe0DaTLehQ7WA55zgRgDGHf6Jl1A1H3_BTB6WZT_EOafzW8cvUOJu0
namespace LabNet2._2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// inicjalizacja bazy danych
        /// </summary>
        RecordsCurrencyExchange dataBase = new RecordsCurrencyExchange();
        /// <summary>
        /// zmienna do przechowania obecnego timestampu w kursach walut
        /// </summary>
        int timeStamp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funkcja ktora odpowiada za calosc pobierania jsona z zewnetrznego api
        /// </summary>
        public async void load()
        {
            string call = "https://openexchangerates.org/api/latest.json?app_id=1c20a8ea81d5429cbf2fdc8fa15816a7";
            HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(call);
            Console.WriteLine(json);
            // deserializacja
            var data = JsonConvert.DeserializeObject<ExchangeRateFromApi>(json);
            //wypelnianie list view
            foreach (var x in data.Rates)
            {
                ListViewItem a = new ListViewItem(x.Key);
                a.SubItems.Add(x.Value.ToString());
                listView1.Items.Add(a);
            }
            //wypelnianie
            foreach(var item in data.Rates.Keys)
            {
                comboBoxChooseCurrency.Items.Add(item);
                comboBoxToFindCurrency.Items.Add(item);
            }
            timeStamp = data.timeStamp;
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

        /// <summary>
        /// ten przycisk wywoluje zaciaganie z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //Uwaga z tym, ja uzywam eng system wiec u mnie kropka
            //jesli uzywasz polskiego to ,
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = " ";
            int numberWritten = Int32.Parse(textBox1.Text);
            double exchangeRate = float.Parse(textBoxRateOfThisCurrency.Text,provider);
            textBoxResultOfCalculating.Text = (numberWritten * exchangeRate).ToString();
        }

        

        private void buttonSaveToDataBase_Click(object sender, EventArgs e)
        {
            string strCurrency  =  listView1.Items[comboBoxChooseCurrency.SelectedIndex].SubItems[0].Text;

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = " ";

            int numberWritten = Int32.Parse(textBox1.Text);
            double exchangeRate = Double.Parse(textBoxRateOfThisCurrency.Text.ToString(), provider);
            double result = Double.Parse(textBoxResultOfCalculating.Text, provider);

            //konstruktor
            SingleCurrencyExchange singleRecord = new SingleCurrencyExchange(timeStamp, strCurrency, exchangeRate, numberWritten, result);
            dataBase.SingleCurrencyExchanges.Add(singleRecord);
            //operacje na bazie danych
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
            string currencyName = listView1.Items[comboBoxToFindCurrency.SelectedIndex].SubItems[0].Text;
            dataGridView2.DataSource = dataBase.SingleCurrencyExchanges.SqlQuery("select * from SingleCurrencyExchanges where nameOfCurrency = @p0", currencyName).ToList<SingleCurrencyExchange>();
        }
    }
}
