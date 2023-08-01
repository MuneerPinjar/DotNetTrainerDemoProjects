// See https://aka.ms/new-console-template for more information
Console.WriteLine("Go To Jump Statement Demo");

int num = 8;

switch (num)
{
    case 0: Console.WriteLine("This is case 0");
        break;
        case 1: Console.WriteLine("This is case 1");
        break;

    case 5: Console.WriteLine("This is case 5");

        break;

    case 8: goto case 1;

    default:
        Console.WriteLine("This is default case");
        break;
}

Console.Read();


