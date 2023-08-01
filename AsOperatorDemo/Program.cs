// See https://aka.ms/new-console-template for more information
Console.WriteLine("C# As Operator Demo");

//take a string variable
string str1 = "Test string 1";

//taking an object type variable
//assigning string variable to it
object obj1 = str1;

//List of objects


string str2 = obj1 as string;

if (str2 != null)
{
    Console.WriteLine("Sucessfully Cast");
}

List<string> mylist = obj1 as List<string>;

if(mylist != null)
{
    Console.WriteLine("Sucessfully Cast");
}
else
{
    Console.WriteLine("Not Sucessfully");
}

Console.ReadLine();





