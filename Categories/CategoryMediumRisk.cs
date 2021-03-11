using CreditSuisse.Categories.Interface;
using CreditSuisse.Negociation.Interface;
using System;

namespace CreditSuisse.Categories
{
    class CategoryMediumRisk : ICategory
    {
        private readonly string CategorieRisk = "MEDIUMRISK";

        public string GetCategory() => CategorieRisk;

        public bool VerifyRisk(DateTime referenceDate, ITrade trade)
        {
            return trade.ClientSector.ToUpper() == "PUBLIC" && trade.Value > 1000000;
        }
    }
}
