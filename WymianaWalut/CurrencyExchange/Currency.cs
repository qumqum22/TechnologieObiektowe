using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class Currency
    {
        public string Name { get;protected set; }
        public double Factor { get;protected set; }
        public string CurrencyTag { get; protected set; }
        public double ExchangeRate { get; protected set; }

        public Currency()
        {

        }
        public Currency(string name, double factor, string currencyTag, double exchangeRate)
        {
            this.Name = name;
            this.Factor = factor;
            this.CurrencyTag = currencyTag;
            this.ExchangeRate = exchangeRate;
        }

    }
}
