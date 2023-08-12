// See https://aka.ms/new-console-template for more information
using EarlyAndLateBindingDemo;

Console.WriteLine("Early and Late Binding Demo");

Employee employee1 = new Employee();


Employee employee = new Employee(101, 20, "Drake");



//employee.details("Rock", 30, 101);

//double = 123123.8761 + "this is test string";

//employee.GetDetails();

//Dynamic objects
dynamic obj = 4;
dynamic dynamic = 7123.2348 +"This is string";


Console.WriteLine("Dispaly Dynamic objects");

Console.WriteLine(dynamic.GetType());

Console.Read();

