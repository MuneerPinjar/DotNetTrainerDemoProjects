// See https://aka.ms/new-console-template for more information
using StructureDemo;

Console.WriteLine("Structures Demo");


//syntax:
// Access_Modifier struct Structure_Name
//{
//    //Fields, methods, construtor, properties, constants, Events, Indexers, etc..
//}


//Declare P1 of type person


Person P1 = new Person();

P1.Name = "Test Name";


Console.WriteLine("Enter the Age : ");
P1.Age = Convert.ToInt32( Console.ReadLine());
P1.Weight = 60;
P1.Id = 101;
P1.address.city = "test city";
P1.address.state = "Test State";

Console.WriteLine("Person Name: "+P1.Name);
Console.WriteLine("Person Id : "+P1.Id);
Console.WriteLine("Person Weight : "+P1.Weight);
Console.WriteLine("Person Age : "+P1.Age);

Console.WriteLine("Person City : "+P1.address.city);

//copy one structure object to another object
Person p2;
p2 = P1;



Console.ReadLine();

