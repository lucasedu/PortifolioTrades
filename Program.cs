using CreditSuisse.Negociation;
using CreditSuisse.Negociation.Interface;
using CreditSuisse.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace CreditSuisse.Categories.Interface
{
    class Program
    {
        private static IList<ITrade> _listTrades = new List<ITrade>();

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            ReadInput();
        }

        public static void ReadInput()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the reference date of the negotiation");
           
            var date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter the number of trades");

            var countTrade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter trade data");

            while (countTrade > _listTrades.Count)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                _listTrades.Add(new Trade(
                    Convert.ToDouble(inputs[0]),
                    inputs[1].ToString(),
                    Convert.ToDateTime(inputs[2])));
            }

            Console.WriteLine();

            if (_listTrades.Count > 0)
            {
                var port = new Portifolio(date, countTrade, _listTrades);

                Console.WriteLine(new CategoryService().AnalyzerTradeService(port));
            }
            else
                Console.WriteLine("No data found !");
           

            Console.ReadKey();
        }
    }
}
