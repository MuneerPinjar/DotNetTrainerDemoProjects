// See https://aka.ms/new-console-template for more information
using NestedClassesDemo;

Console.WriteLine("Nested Demo");


//Syntax
//class OUterClass
//{


//    //some code here


//     class Inner_Class
//    {
//        // some code here of Inner classs
//    }
//}

/// <summary>
///  Creating a instance for Outer class
/// </summary>
Outer_Class outer_Class = new Outer_Class();


outer_Class.Dispplay();

//Inner_Class inner_Class = new Inner_Class();

Outer_Class.Inner_Class inner_Class = new Outer_Class.Inner_Class();


inner_Class.Display();

Console.ReadLine();




