// ***********************************************************************
// Assembly         : PizzaFactory
// Author           : pdurr
// Created          : 01-22-2023
//
// Last Modified By : pdurr
// Last Modified On : 01-23-2023
// ***********************************************************************
// <copyright file="Program.cs" company="PizzaFactory">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Microsoft.Extensions.Configuration;
using Model;
using PizzaFactory.Core;
using System.IO;

Console.WriteLine("Hello, Chef!");

var builder = new ConfigurationBuilder()
               .AddJsonFile($"appsettings.json", true, true);

var config = builder.Build();


#region Variables held in appsettings
string Outputfile = config["OutputFileName"].ToString();
var baseCookingTime = int.Parse(config["BaseCookingTime"]);
var toppingCookingTime = int.Parse(config["ToppingCookingTime"]);
var NoOfPizza = int.Parse(config["NoOfPizza"]); 
#endregion


//Create list of pizzas 
List<Pizza> Pizzas = new List<Pizza>(NoOfPizza);



//Methods for use in application
Routine routines = new Routine();

#region Set Pizza Toppings and Cooking Time
for (int i = 0; i < NoOfPizza; i++)
{
    Topping newTopping = routines.GetRandomTopping();
    Pizzas.Add(new Pizza(baseCookingTime, toppingCookingTime) { topping = newTopping });
}

Pizzas.ForEach(p => p.SetCookingTime(baseCookingTime));
#endregion

#region Output To File


// Ask to append or replace
if(File.Exists(Outputfile))
{
   
    bool fileDeleted = false;


    Console.WriteLine("file exists overwrite (Y/N)");
    var response = Console.ReadLine();


    if (response.ToUpper() == "Y")
    {
        File.Delete(Outputfile);
        Console.WriteLine("File deleted");
        fileDeleted = true;
    }


    if (fileDeleted == false)
        Console.WriteLine("Appending orders");


}



using (StreamWriter sw = File.AppendText(Outputfile))
{

    Pizzas.ForEach(p =>
    {
        Console.WriteLine($"Cooking Pizza: {p.BaseType},{p.topping}  CookingTime={p.GetCookingTime()}");
        sw.WriteLine($"Cooking Pizza: {p.BaseType},{p.topping}  CookingTime={p.GetCookingTime()}");

        Thread.Sleep(p.GetCookingTime());
    });

    sw.Close();
};


#endregion


// End Routine
Console.WriteLine();
