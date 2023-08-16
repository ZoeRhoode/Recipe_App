using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// Troelsen, A.Japikse, P. 2021.Pro c# 9 with. Net5. 10th ed. USA: West Chester.
//C# Tutorial - Full Course for Beginners- Mike. youtube video, added by Graffe acadamy.
//[Online]. Available at:https://www.youtube.com/watch?v=GhQdlIFylQ8&t=3163s 

namespace Recipe_App
{
    internal class Recipe
    {
       public static List<string> Ingredients = new List<string>();
        public static List<string> Name = new List<string>();
        public static List<string> Quantity = new List<string>();
        public static List<string> Calories = new List<string>();
        public static List<string> Steps = new List<string>();
        public static List<string> FoodGroup = new List<string>();

        public string Name;
        public int numingredients;
        public string ingredientName;       
        public double NumRecipe;
        public int numsteps;
        public double Numcalories;

        public static void Recipe(int countRecipe)
        {
            //promt the user to enter the recipe 
            Console.WriteLine("Enter recipe:" + (countRecipe + 1) )
            RecipeName.Add(Name);

            Console.WriteLine("/n");
            //promnt the user to enter the ingredients for the recipe
            Console.WriteLine("Enter the number of ingredients for the recipe:");
            numingredients = int .Parse(Console.ReadLine());

            int countIngredient = 0;
            while (countIngredient < numingredient) 
            {
                
                Console.WriteLine("Enter the ingredient details:" + (countIngredient+ 1));
                Console.WriteLine("/n");

                Console.Write("Enter the ingredient Name: ");
                ingredientName = Console.ReadLine();
                ingredientName.Add(Ingredient);

                Console.Write("Enter the number of callories: ");
                NumCallories = Convert.ToDouble(Console.ReadLine());
                callories.Add(NumCallories);

                Console.Write("Enter the quantity: ");
                quantity.Add(Convert.ToDouble(Console.ReadLine()));

                Console.Write("Enter the food group: ");
                foodGroup.Add(Console.ReadLine());

                countIngredient++;
            }

            Console.WriteLine("Enter steps:");

            NumSteps = int.Parse(Console.ReadLine());
            steps = new List<string>(NumSteps);
        }

        //Calculation of the calories 
        public static void  CalculateTotalCalories()
        {
            double TotalCallories = callories.AsQueryable().Sum();
            Console.WriteLine("Total callories = {0}", TotalCallories);
            int totalCalories = 0;
            foreach (Ingredients ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }

        

        public void EnterDetails()
        {
            //ask the user to enter the number of ingredients

            Console.WriteLine("number of ingredients:");
            int numingredients = int.Parse(Console.ReadLine());
            ingredientName = new string[numingredients];
            quantity = new double[numingredients];
            unitofmeasurement = new double[numingredients];


            //user must enter the details for each ingredient
            for (int i = 0; i < numingredients; i++)
            {
                Console.WriteLine("Enter the details for the ingredients:");
                Console.ReadLine();

                Console.Write("ingredientName:"[i]);
                ingredientName[i] = Console.ReadLine();

                Console.Write("quantity:"[i]);
                Console.ReadLine();

                Console.Write("unit of measurements:"[i]);
                Console.ReadLine();
            }

        }
        public void DisplayRecipe()
        {
            //display the ingredients and quantity for the reciepe 
            Console.WriteLine("Display ingredients:");
            for (int i = 0; i < ingredientName.Length; i++)
            {
                Console.WriteLine($"- {quantity[i]} {unitofmeasurement[i]} of {ingredientName[i]}");
            }
            //display steps
            Console.WriteLine("steps:");
            for (int i = 0; i < stepsdescription.Length; i++)
            {
                Console.WriteLine($"-{stepsdescription[i]}");
            }
        }
        public void Measurements(double factor)
        {
            Console.WriteLine("Enter the measurements ( 0.5 (half), 2 (double) or 3 (triple)):");

            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] = quantity[i] *= factor;
            }


        }

        public void Quantities()
        {
            //quantities reset
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] = quantity[i] /= 2;
            }
        }
        public void ClearRecipe() 
        {
        ingredientName= null;
        quantity= null;
        unitofmeasurement= null;        
        calories= null;

        }
    public void exit()
        {
            Environment.Exit(0);
        }
    }
}