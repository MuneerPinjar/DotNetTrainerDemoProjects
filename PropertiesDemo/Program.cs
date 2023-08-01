// See https://aka.ms/new-console-template for more information
using PropertiesDemo;

Console.WriteLine(" Welcome to C# Properties Demo");

// creating object of Bank class
Bank bank = new Bank();

//setting values to public data memebers of bank class
bank.bankAddress = "Test Bank Address";
bank.bankName = "Test Bank Name";
bank.bankDescription = "Test Bank Description";
bank.bankId = 123;
bank.bankType = "Test Bank Tpye";

bank.BankBalance = 999999;

Console.WriteLine("BAnk ID : "+bank.bankId);
Console.WriteLine("BAnk Name : " + bank.bankName);
Console.WriteLine("BAnk Address : " + bank.bankAddress);
Console.WriteLine("BAnk Description : " + bank.bankDescription);
Console.WriteLine("BAnk Type: " + bank.bankType);
Console.WriteLine("BAnk Balance : " + bank.BankBalance);

Console.ReadLine();




