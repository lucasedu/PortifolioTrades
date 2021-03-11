using CreditSuisse.Negociation.Interface;
using System;

namespace CreditSuisse.Categories.Interface
{
    public interface ICategory
    {
        bool VerifyRisk(DateTime referenceDate, ITrade trade);

        string GetCategory();
    }
}
