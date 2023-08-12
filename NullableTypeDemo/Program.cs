// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Nullable Type Demo");



//syntax for Nullable type
// Nullable<data_type> variable_name = null;

//Shortcut syntax for Nullable tpye using ? operator
//syntax : datatype? variable_name = null;

Nullable<int> testIntVariable = null;

int? result = null;

string? testvariablename;



string? testString = "Test String";


testString = null;

if(testString != null)
{
    Console.WriteLine("Default Test string Nullable Variable :" + testString.GetType().ToString());
}
else
{
    Console.WriteLine("Exception Raised");
}

Console.WriteLine("Default Test Int Nullable Variable :"+testIntVariable.GetValueOrDefault());


Console.ReadLine();