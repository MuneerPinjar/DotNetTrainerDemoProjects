// See https://aka.ms/new-console-template for more information
using IsOperatorDemo;

Console.WriteLine("Is Operator Demo");

//create object of Author and work class
Author author = new Author();
author.AuthorDetails("Test Name", "Test Description", 999);

Work work = new Work();
work.TestMethod(10, 101);

bool result;

//check whether author object is of Author tpye or not
//

result = author is Author;

Console.WriteLine("Is author object is of Author type ? :{0}",result);


// check work is a Author type or not using Is Opertor
result=work is Author;

Console.WriteLine("Is work object is of Author type ? :{0}", result);


//take the value of author is null

author = null;

result =author is Author;

Console.WriteLine("Is author object is of Author type ? :{0}", result);

Console.Read();



