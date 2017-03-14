using System;
using System.Collections.Generic;
using System.Threading;

namespace RsItemPriceGetter
{
    class Program
    {
        static int i = 0;
        static List<string> allItems = new List<string>();

        static void Main(string[] args)
        {

            ItemList list = new ItemList();        
            
            //add all items to one list
            allItems.AddRange(list.HerbloreItems);

            //timer
            var timer = new Timer(e => iterate(),
                null, 0, Convert.ToInt32(TimeSpan.FromSeconds(60).TotalMilliseconds));

            Console.ReadLine();            
        }
        public static void iterate()
        {

            //checks to see if i is greater than list size, if so returns i to 0
            if (i > allItems.Count)
            {
                i = 0;
            }

            DbInsert insert = new DbInsert();

            //calls dbInsert to do its thing
            insert.putInDb(allItems[i]);
            ++i;
        }
    }
}
