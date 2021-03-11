using CreditSuisse.Negociation.Interface;
using System;
using System.Collections.Generic;

namespace CreditSuisse.Negociation
{
    public class Portifolio    
    {
        public DateTime DataReference { get; private set; }

        public int TradeCount { get; private set; }

        public ICollection<ITrade> ListTrade { get; private set;}

        public Portifolio(DateTime dataReference, int tradeCount, ICollection<ITrade> trades)
        {
            DataReference = dataReference;
            TradeCount = tradeCount;
            ListTrade = trades;
        }
    }
}
