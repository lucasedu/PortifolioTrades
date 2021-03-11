using System;
using System.Collections.Generic;
using System.Linq;
using CreditSuisse.Categories;
using CreditSuisse.Categories.Interface;
using CreditSuisse.Negociation;

namespace CreditSuisse.Service
{
    public class CategoryService
    {
        public List<ICategory> _categoryService;

        public CategoryService()
        {
            _categoryService = new List<ICategory>();
            _categoryService.Add(new CategoryDefaulted());
            _categoryService.Add(new CategoryHighRisk());
            _categoryService.Add(new CategoryMediumRisk());
        }

        public string AnalyzerTradeService(Portifolio port)
        {
            return string.Join("\n", port.ListTrade.Select(item => $"{ _categoryService.Find(i => i.VerifyRisk(port.DataReference, item)).GetCategory() }"));
        }
    }
}