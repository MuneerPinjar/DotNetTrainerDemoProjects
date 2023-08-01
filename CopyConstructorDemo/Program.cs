// See https://aka.ms/new-console-template for more information
using CopyConstructorDemo;

Console.WriteLine("Copy Constructor Demo");

TechGeeks techGeeks1 = new TechGeeks("Test month", 2022, 101, "Test Name ");

TechGeeks techGeeks2 = new TechGeeks(techGeeks1);

TechGeeks techGeeks3 = new TechGeeks();

TechGeeks techGeeks4 = new TechGeeks(techGeeks3);




Console.WriteLine(techGeeks2.Details);