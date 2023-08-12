// See https://aka.ms/new-console-template for more information
Console.WriteLine("C# As Operator Demo");

//take a string variable
string str1 = "Test string 1";

//taking an object type variable
//assigning string variable to it
object obj1 = str1;

int n = 10;

object obj2 = n;

var testvar = n;

//List of objects

string str3 = obj2 as string;

string[] str6 = new string[] { "Test 1", "test 2", "test 3", "test 4" };

object obj3 = str6;

List<int> list = obj3 as List<int>;

foreach (var item in list)
{
    Console.WriteLine(item);
}



string str4 = Convert.ToString( testvar);

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





