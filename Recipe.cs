using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Recipe
    {
        //declaring fields
        private string[] ingredients;
        private double[] quantity;
        private string[] units;
        private string[] steps;
        private double[] originalQuantity;


            public void EnterDetails()
            {
                Console.WriteLine("\nPlease enter the number of ingredients : ");
                int numIngredients = Convert.ToInt32(Console.ReadLine());

                //arrays to store ingredients
                ingredients = new string[numIngredients];
                quantity = new double[numIngredients];
                units = new string[numIngredients];
                originalQuantity = new double[numIngredients];
                
                //looping through each ingredient to get the name, quantity, and the unit of measurement from the user
                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"\nINGREDIENT {i + 1} ");
                    Console.WriteLine("*********************");
                    Console.WriteLine("Please enter the name of ingredient " + (i + 1) + " : ");
                    ingredients[i] = Console.ReadLine();

                    Console.WriteLine("\nPlease enter the quantity of " + ingredients[i] + " : ");
                    quantity[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nPlease enter the unit of measurement for " + ingredients[i] + " :  ");
                    units[i] = Console.ReadLine();
                    Console.WriteLine("*********************");
 
                    originalQuantity[i] = quantity[i];
                }

                Console.WriteLine("\nPlease enter the number of steps : ");
                int numSteps = Convert.ToInt32(Console.ReadLine());

                //looping through each step to get the user's description
                steps = new string[numSteps];

                for (int i = 0; i < numSteps; i++)
                {
                  Console.WriteLine("\nSTEP " + (i + 1));
                  Console.WriteLine("*********************");
                  Console.WriteLine("Enter the description for step " + (i + 1) + " : ");
                    steps[i] = Console.ReadLine();
                  Console.WriteLine("*********************");
            }
                Console.WriteLine("\nRecipe details entered successfully!");
            }


        public void DisplayRecipe()
        {
            //Displaying the recipe
            Console.WriteLine("\nRECIPE ");
            Console.WriteLine("*********************");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($"{originalQuantity[i]} {units[i]} of {ingredients[i]}");
            }
            Console.WriteLine("*********************");

            //Displaying all the steps
            Console.WriteLine("\nSTEPS ");
            Console.WriteLine("****************");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + steps[i]);
            }
            Console.WriteLine("****************");
        }


        public void ScaleRecipe()
        {
            Console.Write("\nPlease enter the scale factor (0.5, 2 0r 3): ");
            double factor = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] = originalQuantity[i] * factor;

                Console.WriteLine($"\nThe recipe scaled by {factor} is : ");
                Console.WriteLine($"{quantity[i]} {units[i]} {ingredients[i]}");
            }
            Console.WriteLine("\nRecipe scaled successfully!");
        }


        public void ResetQuantities()
        {
            //reset the quantities to the original values
            Console.WriteLine("\nResetting recipe to original quantities : ");
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] = originalQuantity[i];
                Console.WriteLine("The initial value is {0} ", quantity[i] );
            }
        }

        public void ClearRecipe()  
        {
            //clearing all the data that was stored previously stored
             ingredients = null;
             quantity = null;
             units = null;
             steps = null;
             originalQuantity = null;

        Console.WriteLine("Recipe cleared. Please enter a new recipe ");

            //calling the enterDetails method for the user to enter a new recipe
            EnterDetails();
            
        }                       
          
        }

    }
   

