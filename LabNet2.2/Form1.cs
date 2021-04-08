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
            }

            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
            /*var dataBase = new RecordsCurrencyExchange();

            SingleCurrencyExchange single = new SingleCurrencyExchange(5, "USD", 3, 4, 12);
            dataBase.SingleCurrencyExchanges.Add(single);

            dataBase.SaveChanges();

            var another = dataBase.SingleCurrencyExchanges.SqlQuery("select * from SingleCurrencyExchanges").ToList<SingleCurrencyExchange>();
            string x="";
            foreach (var s in another)
            {
                 x = " " + s.nameOfCurrency + " " + s.TimeStamp + " " + s.exchangeRate;
            }
            label5.Text = x;
            */
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";
            int numberWritten = Int32.Parse(textBox1.Text);
            double exchangeRate = Double.Parse(textBoxRateOfThisCurrency.Text,provider);
            textBoxResultOfCalculating.Text = (numberWritten * exchangeRate).ToString();

                //Items[comboBoxChooseCurrency.SelectedIndex].SubItems[1].Text;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
