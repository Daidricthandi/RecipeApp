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
            private string[] steps;
            private string[] units;
            private double[] originalQuantity;

            public Recipe(int numIngredients, int numSteps, string numOfUnits)//constructor
            {
                ingredients = new string[numIngredients];
                originalQuantity = new double[numIngredients];
                units = new string[numIngredients];
            
               //looping through each ingredient to get the name, quantity, and the unit of measurement from the user
                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"\nINGREDIENT {i + 1} :  ");
                    Console.WriteLine("Please enter the name of ingredient " + (i + 1) + " : ");
                    ingredients[i] = Console.ReadLine();

                    Console.WriteLine("\nPlease enter the quantity of " + ingredients[i] + " : ");
                    originalQuantity[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nEnter the unit of measurement for ingredient " + (i + 1) + " : ");
                    units[i] = Console.ReadLine();
                }

                //looping through each step to get the user's description
                steps = new string[numSteps];
                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine("\nEnter the description for step " + (i + 1) + " : ");
                    steps[i] = Console.ReadLine();
                }
                    Console.WriteLine("\nRecipe details entered successfully!");
            }

            public void DisplayRecipe()
            {
                //looping through each ingredient and displaying the recipe
                Console.WriteLine("\nRECIPE : ");
                Console.WriteLine("***************");
                for (int i = 0; i < ingredients.Length; i++)
                {
                    Console.WriteLine($"{originalQuantity[i]} {units[i]} {ingredients[i]}");
            }
                    Console.WriteLine("***************");

                //looping through each step and displaying all the steps
                Console.WriteLine("\nSTEPS : ");
                Console.WriteLine("***************");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + steps[i]);
                }
                    Console.WriteLine("***************");
        }

            public void ScaleRecipe(double factor) 
        {
                //calculating the scaled quantity
                for (int i = 0; i < ingredients.Length; i++)
                {
                    double scaledQuantity = originalQuantity[i] * factor;

                    Console.WriteLine($"\nThe recipe scaled by {factor} : ");
                    Console.WriteLine($"{scaledQuantity} {units[i]} {ingredients[i]}")
;                }
                    Console.WriteLine("\nRecipe scaled successfully!");
            }

            public void ResetQuantities()
            {
                //reset the quantities to the original values
                Console.WriteLine("\nResetting recipe to original quantities ");
                for (int i = 0; i < ingredients.Length; i++)
                {
                    Console.WriteLine("The original value is {0} ", originalQuantity[i] + " " + ingredients[i]);
                }
            }

            public void ClearRecipe()  //clearing all the data
            {
                ingredients = null;
                steps = null;
                originalQuantity = null;
            
               Console.WriteLine("\nRecipe cleared successfully!");
        }
                             
        }

    }

