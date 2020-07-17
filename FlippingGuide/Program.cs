using Microsoft.VisualBasic.CompilerServices;
using NinjaData;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlippingGuide
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            ApiHelper.InitializeClient();
            await PriceProcessor.LoadData();

            Console.WriteLine($"{"Breachstone",35}{"Price",10}\n======================================================================");
            foreach (var Listing in PriceProcessor.Stones)
                Console.WriteLine($"{Listing.CurrencyTypeName, 35} {Listing.chaosEquivalent, 10} chaos");

            List<Tuple<string, float>> profits = PriceProcessor.ProfitCalc();

            Console.WriteLine($"\n\n{"Breachstone",25}     {"Profit to Flip"}\n========================================================");
            foreach (var listing in profits)
                Console.WriteLine($"{listing.Item1,25} {listing.Item2,10:F2} chaos");

            Console.ReadLine();
        }
    }
}
