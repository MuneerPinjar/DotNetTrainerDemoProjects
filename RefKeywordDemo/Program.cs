// See https://aka.ms/new-console-template for more information
using RefKeywordDemo;

Console.WriteLine("Hello, World!");


int a=10, b=12;

Console.WriteLine("Initial Value  a: "+a);
Console.WriteLine("Intial Value b : "+b);

BasicCalculator.addValue(a);

Console.WriteLine("Value of a after Addition  : "+a);

BasicCalculator.subtractValue(ref b);

Console.WriteLine("Value of b after subtraction : "+b);



//object of the ClassA -- Instance of the class
    ClassA sampleClassAObject = new ClassA(23,23);




Console.ReadLine();

