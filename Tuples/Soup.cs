namespace Tuples
{
    internal class Soup
    {
        // Constructor 
        public Soup() 
        {
            Console.WriteLine("pre-made soup");
        }

        enum soup {soup,stew,broth};
        enum ingredient { chicken, mushrooms, carrots, potatoes };
        enum seasoning { spicy, salty, sweet };

        string enteredData = "";
        public void makeSoup()
        {
            while (enteredData != "n")
            {
                // create a tuple of enums that contian the ingredients
                (soup soup_val, ingredient ingredient_val, seasoning seasoning_val) choice = (soup.soup, ingredient.chicken, seasoning.spicy);

                Console.WriteLine("\nCreate a soup! (enter stop to stop)");

                // type
                Console.Write("Type : 1.soup, 2.stew, 3.broth\n");
                enteredData = Console.ReadLine();
                switch (enteredData)
                {
                    case "1":
                        choice.soup_val = soup.soup;
                        break;
                    case "2":
                        choice.soup_val = soup.stew;
                        break;
                    case "3":
                        choice.soup_val = soup.broth;
                        break;
                }


                // ingredient
                Console.Write("Main Ingredient : 1.chicken, 2.mushrooms, 3.carrots, 4.potatoes\n");
                enteredData = Console.ReadLine();
                switch (enteredData)
                {
                    case "1":
                        choice.ingredient_val = ingredient.chicken;
                        break;
                    case "2":
                        choice.ingredient_val = ingredient.mushrooms;
                        break;
                    case "3":
                        choice.ingredient_val = ingredient.carrots;
                        break;
                    case "4":
                        choice.ingredient_val = ingredient.potatoes;
                        break;
                }

                // seasoning
                Console.Write("Seasoning : 1.spicy, 2.salty, 3.sweet\n");
                enteredData = Console.ReadLine();
                switch (enteredData)
                {
                    case "1":
                        choice.seasoning_val = seasoning.spicy;
                        break;
                    case "2":
                        choice.seasoning_val = seasoning.salty;
                        break;
                    case "3":
                        choice.seasoning_val = seasoning.sweet;
                        break;
                }

                Console.WriteLine($"Your soup is : {choice.seasoning_val} {choice.ingredient_val} {choice.soup_val}");
                Console.WriteLine("again? y/n");
                enteredData = Console.ReadLine();
            }
        }
    }
}
