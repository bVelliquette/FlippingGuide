using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NinjaData
{
    public static class PriceProcessor
    {
        public static async Task<ListingModel> LoadData()
        {
            string url = "currencyoverview?league=Harvest&type=Fragment";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ListingModel listing = await response.Content.ReadAsAsync<ListingModel>();
                    listing.Test = 69;

                    return listing;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
