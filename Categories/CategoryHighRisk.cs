using CreditSuisse.Negociation.Interface;
using CreditSuisse.Categories.Interface;
using System;

namespace CreditSuisse.Categories
{
    public class CategoryHighRisk : ICategory
    {
        private readonly string CategorieRisk = "HIGHMRISK";

        public string GetCategory() => CategorieRisk;

        public bool VerifyRisk(DateTime referenceDate, ITrade trade)
        {
            return trade.ClientSector.ToUpper() == "PRIVATE" && trade.Value > 1000000;
        }
    }
}
