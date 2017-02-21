using MySql.Data.MySqlClient;
using System;

namespace RsItemPriceGetter
{
    class DbInsert
    {
        GetPrice p = new GetPrice();

        public void putInDb(string itemId)
        {

            try
            {
                int price = p.getPrice(itemId);

                string server = "localhost";
                string database = "items";
                string uid = "root";
                string password = "082490";

           
                string cs = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(cs);



                connection.Open();
                //Console.WriteLine("Opening connection");

                MySqlCommand cmd = new MySqlCommand("UPDATE items SET Price = " + price + " WHERE Item_Id = " + Int32.Parse(itemId) + ";", connection);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Executing query: Item number = " + itemId + ", Price = " + price);
            
                connection.Close();
                //Console.WriteLine("Connection Closed");
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
