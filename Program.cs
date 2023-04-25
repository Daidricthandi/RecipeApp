using System;

namespace RecipeApp
{
   
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("WELCOME TO THE RECIPE APPLICATION!");
            Console.WriteLine("************************************");

            Console.WriteLine();
    
            //creating an object of the recipe class
            Recipe recipe = new Recipe();

            bool exit = false;

            //loop until user exits the program
            while (!exit)
            {
                Console.WriteLine("\nPlease choose an option below : ");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Dispaly recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Exit application");
                
                Console.WriteLine();

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipe.EnterDetails();
                        break;

                    case 2:
                        recipe.DisplayRecipe();
                    break;

                    case 3:
                        recipe.ScaleRecipe();
                    break;

                    case 4:
                        recipe.ResetQuantities();
                    break;

                    case 5:
                        recipe.ClearRecipe();
                    break;

                    case 6:
                     exit = true;
                    break;

                    default:
                        Console.WriteLine("Invalid choice!");
                    break;

                }
            }
            Console.WriteLine("Thank you for using our application!");
        }


    }
}
