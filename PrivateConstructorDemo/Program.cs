// See https://aka.ms/new-console-template for more information
using PrivateConstructorDemo;

Console.WriteLine("Private Constructor Demo");

//Creating a instance of a class is not possible if the constructor is specified with Private specifier
//Student student = new Student();

Student.age = 20;

Console.WriteLine( Student.GetAge() ); 
