using System;

namespace RecipeApp
{
   
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("WELCOME TO THE RECIPE APPLICATION!");

            Console.WriteLine();

            Console.WriteLine("Please enter the number of ingredients : ");
            int numIngredients = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the number of steps : ");
            int numSteps = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the unit of measurement : ");
            String measureUnits = (Console.ReadLine());

            Recipe recipe = new Recipe(numIngredients, numSteps, measureUnits);

            //loop until user exits the program
            while (true)
            {
                Console.WriteLine("\nPlease choose an option below : ");
                Console.WriteLine("1. Dispaly recipe");
                Console.WriteLine("2. Scale recipe");
                Console.WriteLine("3. Reset quantities");
                Console.WriteLine("4. Clear recipe");
                Console.WriteLine("5. Exit");
                
                Console.WriteLine();

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipe.DisplayRecipe();
                    break;

                    case 2:
                        Console.WriteLine("\nEnter the scale factor (0.5, 2 0r 3): ");
                        double factor = Convert.ToDouble(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                    break;

                    case 3:
                        recipe.ResetQuantities();
                    break;

                    case 4:
                        recipe.ClearRecipe();
                    break;

                    case 5:
                        Environment.Exit(0);
                    break;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                    break;

                }
            }
        }


    }
}
