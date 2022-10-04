public class Program
{
    public static void Main()
    {
        Console.WriteLine("Jessie's Shopping list:");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Enter the corresponding number to add item to list: \n");
        //Setting ints i,choice,sum to 0. //set string to empty
        int i = 0;
        int choice = 0;
        int sum = 0;
        string input = "";
        string sum2 = "";

        //A list of all items availble for purchase
        List<string> grocery = new List<string>();
        grocery.Add("Pokemon Cards, ");
        grocery.Add("Soft Blanket, ");
        grocery.Add("Succulents, ");
        grocery.Add("La croix, ");
        grocery.Add("Coffee, ");
        grocery.Add("Doritos, ");
        grocery.Add("Phone Charger, ");
        grocery.Add("Cat Food, ");
        grocery.Add("Mystery Bag, ");
        grocery.Add("Dragon Balls: Seven Count, ");

        //A list of coresponding prices for item list
        List<int> prices = new List<int>();
        prices.Add(3);
        prices.Add(8);
        prices.Add(9);
        prices.Add(1);
        prices.Add(3);
        prices.Add(2);
        prices.Add(22);
        prices.Add(4);
        prices.Add(3);
        prices.Add(9001);

        //Dictionary of items created...I didn't comprehend how to use this during the time that the lab was due. 
        Dictionary<string, double> itemPrice = new Dictionary<string, double>();
        itemPrice.Add("Pokemon Cards", 3);
        itemPrice.Add("Soft Blanket", 8);
        itemPrice.Add("Succulents", 9);
        itemPrice.Add("La croix", 1);
        itemPrice.Add("Coffee", 3);
        itemPrice.Add("Doritos", 2);
        itemPrice.Add("Phone Charger", 22);
        itemPrice.Add("Cat Food", 4);
        itemPrice.Add("Mystery Bag", 3);
        itemPrice.Add("Dragon Balls: Seven Count", 9001);

        for (i = 0; i < grocery.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + grocery[i]);
        }
        while (!input.ToLower().Equals("x"))
        {
            input = Console.ReadLine();
            
            if (Int32.TryParse(input, out choice))
            {
                choice = choice - 1;
                if (choice >= 0 && choice < grocery.Count)
                {
                    Console.WriteLine("Adding " + grocery[choice] + "to the list. Please enter next item OR if finished, press \"ENTER\" for total");

                    sum += prices[choice];
                    sum2 += grocery[choice];
                    //Adds all prices determined here                   
                }
            
                else
                 {
                Console.WriteLine("Invalid input. Please enter a number between 1-10 OR press \"ENTER\" to continue to check out.");
                 }
             }

            else 
            { 
             break;
            }
        
    }


    Console.WriteLine("\n Total Amount Due For: " + sum2 + " Is: $" + sum);
        //will print the sum of the order here.
    }
    
}