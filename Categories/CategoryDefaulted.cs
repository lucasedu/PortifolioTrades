using CreditSuisse.Categories.Interface;
using CreditSuisse.Negociation.Interface;
using System;

namespace CreditSuisse.Categories
{
    public class CategoryDefaulted : ICategory
    {
        private readonly string CategorieRisk = "DEFAULTED";

        public string GetCategory() => CategorieRisk;

        public bool VerifyRisk(DateTime referenceDate, ITrade trade)
        {
            TimeSpan differenceTimeSpan = referenceDate - trade.NextPaymentDate;

            var differenceDays = (int)differenceTimeSpan.TotalDays;

            return differenceDays > 30;
        }
    }
}
