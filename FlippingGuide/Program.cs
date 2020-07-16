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
        static async Task Main(string[] args)
        {
            ApiHelper.InitializeClient();
            var listing = await PriceProcessor.LoadData();
            Console.WriteLine(listing.Lines[0].CurrencyTypeName);
            Console.WriteLine(listing.Lines[0].chaosEquivalent);
        }
    }
}
