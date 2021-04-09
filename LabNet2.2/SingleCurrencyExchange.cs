using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2._2
{
    public class SingleCurrencyExchange
    {
        // dlaczego dodajac w ten sposob ID, to wszystko dziala?
        //dlaczego nie musimy dodac [id] czy cos takiego
        public int ID { set; get; }
        public int timeStamp { set; get; }
        public string nameOfCurrency { set; get; }
        public double exchangeRate { set; get; }

        public int amountToExchange { set; get; }
        public double resultOfCalculating { set; get; }

        public SingleCurrencyExchange(int time, string name, double exchangeRate, int amount, double result)
        {
            this.timeStamp = time;
            this.nameOfCurrency = name;
            this.exchangeRate = exchangeRate;
            this.amountToExchange = amount;
            this.resultOfCalculating = result;
        }
        public SingleCurrencyExchange()
        {

        }
    }
}
