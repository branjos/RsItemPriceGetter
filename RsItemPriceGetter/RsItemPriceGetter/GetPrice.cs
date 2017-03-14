using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RsItemPriceGetter
{
    class GetPrice
    {
        public int getPrice(string itemId)
        {
            string[] price = new string[2];
            int goldPieces = 0;
            try
            {
                var url = new WebClient().DownloadString("http://services.runescape.com/m=itemdb_rs/api/graph/" + itemId + ".json");

                int index1 = url.IndexOf("average");

                url = url.Substring(0, index1 - 3);

                string[] csv = url.Split(',');

                price = csv[csv.Length - 1].Split(':');

                if (url == null)
                {
                    goldPieces = 0;
                }
                else
                {
                    goldPieces = Int32.Parse(price[1]);
                }
            }
            catch(WebException e)
            {
                Console.WriteLine(e);
            }
            
            return goldPieces;
        }
    }
}
