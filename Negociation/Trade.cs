using CreditSuisse.Negociation.Interface;
using System;

namespace CreditSuisse.Negociation
{
    public class Trade : ITrade
    {
        public double Value { get; private set; }
        public string ClientSector { get; private set; }
        public DateTime NextPaymentDate { get; private set; }

        public Trade(double value, string clientSector, DateTime date)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = date;
        }
    }
}
