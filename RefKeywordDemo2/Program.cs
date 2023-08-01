// See https://aka.ms/new-console-template for more information
using RefKeywordDemo2;

Console.WriteLine("Demo to illustrate the use of Ref keyword with an instance of a class");


//Instance of complex object
Complex complex = new Complex(2, 3);

Console.WriteLine("Before update");

Console.WriteLine(" Complex NUmber Real Value : " + complex.getRealValue() + " Image value : " + complex.getImgValue());

// lets call update method by pass ref of complex object

Complex.Update(ref complex);

Console.WriteLine("After Updating");

Console.WriteLine(" Complex NUmber Real Value : " + complex.getRealValue() + " Image value : " + complex.getImgValue());

Console.ReadLine();


//if else
//if(condition)
//{
//    ///this gets executed when condition is true
//}
//else
//{
//    ///this gets executed when condition is false
//}

//if - else - if ladder statement
//if (true)
//{
//    //code will be executed if condtion1 is true
//}
//else if (true)
//{
//    //code will be executed if condtion2 is true
//}
//else if (true)
//{
//    //code will be executed if condtion3 is true
//} 
//else if(true)
//{
//    //code will be executed if condtion4 is true
//}

//else
//{
//    // code wil be execute if all the conditon are false
//}

//Nested - if statement

if (true)
{
    //
    if (true)
    {
        if(true)
        {

        }
    }
}

// Switch Statement

//switch (expression)
//{
//    case 1://state sequence

//        break;
//    case 2:
//        break;
//    case 3:
//        //code will be executed
//        break;


//        default:
//        break;
//}

// Nested Switch 

//switch (expression)
//{
//    case 1://state sequence

//        break;
//    case 2:
//        break;
//    case 3: Swtich (express)
//{
//  
//
//
//}
//        //code will be executed
//        break;


//        default:
//        break;
//}

// Entry controlled loops
while (true)
{
    // code will executed til the condition is true

}



// Example of List of students  and you want to update the Results of each student
for (int i = 0; i < 10; i++)
{
    // Block of statements
}

//Exit controlled loops
do
{
    // block of statements
} while (true);

//infinite loop
for (; ; )
{
    // this code will be executed infinite times
}


// Nested loops

for (int i = 0; i < 100; i++)
{

    Console.WriteLine("Index of i in current iteration : "+i);

    for (int j = 0; i < 10; i++)
    {
        for (int k = 0; i < 5; i++)
        {

        }
    }
}

for (int i = 0; i < 10; i++)
{
    // BLock of statements
    //...
    //    ..
    //    ...
    //    ...

    if(i == 0)
    {
        continue;
    }

    else
    {

    }

    /// rest of the block code here
    /// ..
    /// ...
    /// ..
}


// syntax foreach loop

//foreach(datatype var in collection_varialbe)
//{
//    //block of statments
//}

int[] arrayTest = new int[] { 1, 23, 54, 63, 463, 36, 346, 34, 6 };



foreach (var item in arrayTest)
{
    //item += 2;

    //if(item == sometarget)
    //{
    //    return???
    //}

    Console.WriteLine("Value : "+item);
}

//iterate in reverse direction
for (int i = 9; i < 0; i--)
{
    //block of statements
    // 9,8,7,6,5
    if (i == 4)
    {
        continue;
    }

    //rest of the code here
    var valu = arrayTest[i];


}

//rest of the code here















