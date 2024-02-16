// See https://aka.ms/new-console-template for more information
using CalcExample;
Console.WriteLine("Hello, World!");

Calc calc = new Calc();
Console.WriteLine("Add Call");
calc.Add(10, 10);
Console.WriteLine("Sub call");
calc.Sub(30, 20);
Console.WriteLine("Div Call");

calc.Multi(200 , 100);