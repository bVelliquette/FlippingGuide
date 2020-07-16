using System;
using System.Collections.Generic;
using System.Text;

namespace NinjaData
{
    public class ListingModel
    {
        public int Test { get; set; }
        public string CurrencyTypeName { get; set; }
        public Fragment[] Lines { get; set; }
    }

    public class Fragment
    {
        public string CurrencyTypeName { get; set; }
        public float chaosEquivalent { get; set; }
    }
}
