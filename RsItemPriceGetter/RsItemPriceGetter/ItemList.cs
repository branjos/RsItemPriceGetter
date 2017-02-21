/// The primary function of this class is to hold an array of item numbser for the application to
/// pull the data from the rs website and imput it into the database.  
///

namespace RsItemPriceGetter
{
    class ItemList
    {
        //array of herblore item numbers
        string[] herbloreItems =
        {        
            //clean/grimy
            "249", "199",     // Guam           0,1
            "253", "203",     // Tarromin       2,3
            "251", "201",     // Marrentil      4,5
            "255", "205",     // Harralander    6,7
            "257", "207",     // Rannar         8,9
            "2998", "3049",   // Toadflax       10,11
            "12172", "12174", // Spirit weed    12,13
            "259", "209",     // Irit           14,15
            "14854", "14836", // Wergali        16,17
            "261", "211",     // Avantoe        18,19
            "263", "213",     // Kwarum         20,21
            "37953", "37975", // bloodweed      21,22
            "3000", "3051",   // Snapdragon     23,24
            "265", "215",     // Cadantine      25,26
            "2481", "2485",   // Lantadyme      27,28
            "267", "217",     // Dwarf Weed     29,30
            "269", "219",     // Torstol        31,32
            "21624", "21626",  // Fellstalk     33,34
           
            //secondaries
            "227",   // Waterfilled Vial         36
            "221",   // Eye of newt
            "1951",  // Redberries
            "1470",  // Bead
            "225",   // Limpwurt                40
            "948",   // Bear fur
            "235",   // Ground unicorn horn
            "223",   // Red spider eggs
            "1975",  // Chocolate Dust
            "2152",  // Toads legs
            "9736",  // Goat horn dust
            "231",   // snape grass
            "12109", // cockatrice egg
            "2970",  // mort myre fungus
            "10111", // kebbit teeth dust       50
            "11525", // wimpy feather
            "241",   // dragon scale dust
            "239",   // white berries
            "245",   // wine of zamorack
            "3138",  // potato cactus
            "247",   // jangerberries
            "6693",  // crushed nest
            "5972",  // papaya
            "4698",  // mud rune
            "12539", // grenwall spike          60
            "28256", // wine of saradomin
            "28253", // wine of guthix
            "21622", // morchella mushroom
            "37914", // crushed dragonstone     64    
            "34159",  // searing ashes                                
             
            //potions
            "121",   //attack potion
            "27506", //ranging potion
            "27514", //magic potion
            "115",   //strength potion
            "133",   //defence potion
            "175",   //antipoison
            "127",   //restore
            "3010",  //energy
            "3034",  //agility
            "9741",  //combat
            "139",   //prayer
            "12142", //summoning
            "145",   //super attack
            "181",   //super antipoison
            "151",   //fishing
            "3018",  //super energy
            "10000", //hunter
            "157",   //super strength
            "14848", //fletching
            "25487", //weapon poison
            "3026",  //super restore
            "163",   //super defence
            "2454",  //antifire
            "169",   //super ranging
            "3042",  //super magic
            "6687",  //sara brew
            "21632", //prayer renewal
            "37969", //aggression potion
            "37963"  //luck potion
        };
    

        //array of smithing item numbers
        string[] smithingItems =
        {

        };

        //array of construction item numbers
        string[] constructionItems =
        {

        };

        public string[] HerbloreItems
        {
            get
            {
                return herbloreItems;
            }
        }
    }
}
