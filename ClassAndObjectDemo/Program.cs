// See https://aka.ms/new-console-template for more information
using ClassAndObjectDemo;

Console.WriteLine("Class and Object Demo");


Dog dog1 = new Dog("Tuffy", "Husky", 3, "White", "Very calm, friednly and more welcoming and loves going out for walk");

Dog dog2 = new Dog("Jerry", "Pitbull", 2, "Dark Brown", "Very Angry, not so friednly");


Console.WriteLine(dog1.GetDetailsInString());

Console.WriteLine(dog1.Bark());


Console.WriteLine("#############################");
Console.WriteLine(dog2.GetDetailsInString());

Console.WriteLine(dog2.Bark());


Console.ReadLine();


