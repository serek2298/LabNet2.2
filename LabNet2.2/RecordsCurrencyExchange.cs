using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace LabNet2._2
{
    public class RecordsCurrencyExchange: DbContext
    {
        public virtual DbSet<SingleCurrencyExchange> SingleCurrencyExchanges { get; set; }

    }
}
