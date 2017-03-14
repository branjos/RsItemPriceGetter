using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RsItemPriceGetter
{
    class Program
    {
        static void Main(string[] args)
        {

            ItemList list = new ItemList();
            DbInsert insert = new DbInsert();
            Task t = new Task();
            
            //add all items to one list
            List<string> allItems = new List<string>();
            allItems.AddRange(list.HerbloreItems);

            while (true)
            {
                for(int i = 0; i < allItems.Count; ++i)
                {
                    //checks to see if i is greater than list size, if so returns i to 0
                    if (i >= allItems.Count)
                    {
                        i = 0;
                        break;
                    }

                    //calls dbInsert to do its thing
                    insert.putInDb(allItems[i]);

                    System.Threading.Thread.Sleep(30000);
                }
            }            
        }
    }
}
