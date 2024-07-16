using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[]args)
    {
        List<Recipe> recipes = new List<Recipe>
        {
         new Pizza(),
         new Spaghetti(),
        };
        
        foreach (var recipe in recipes)
        {
            Console.WriteLine();
            Console.WriteLine($"recipe({recipe.GetType().Name})");
            Console.WriteLine();
            Console.WriteLine(recipe.Prepare());
        }
    }
}

public abstract class Recipe
{
    public abstract string Prepare();
}

public class Pizza : Recipe
{
    public override string Prepare()
    {
        return "1. Roll out the pizza dough. \n" +
               "2. Spread the pizza sauce on the dough. \n"+
               "3. Add desired toppings. \n" +
               "4. Bake the pizza in the oven. \n" +
               "5. Slice and serve.";
        
    }
}

public class Spaghetti : Recipe
{
    public override string Prepare()
    {
        return "1. Boil water in a pot. \n " +
               "2. Add spaghetti noodles to the boiling water. \n "+
               "3. Cook the noodles. \n"+
               "4. Drain the cooked noodles. \n" +
               "5. Serve with your favorite sauce and toppings.";
    }
}
   