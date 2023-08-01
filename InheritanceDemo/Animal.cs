using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    // <summary>
    /// Base Class
    /// </summary>
    public class Animal
    {

        public void Eat()
        {
            Console.WriteLine("Animal is Eating test data");
        }

    }

    //Dervied class -- Single Inheritance
    public class Dog : Animal
    {

        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }


    }


    //multi - level inheritance

    public class BreedDog1 : Dog
    {

        public void DisplayBreedDog1()
        {

            Console.WriteLine("Breed Dog 1 method is called");
        }

    }

    //
    public class BreedDog2 : Dog
    {

        public void DisplayBreedDog2()
        {

            Console.WriteLine("Breed Dog 2 method is called");
        }

    }

    //Hierarchial Inheritance

    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    public class Eagle : Bird
    {
        public void Hunt()
        {

            Console.WriteLine("Eagle is hunting");
        }
    }

    public class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming");
        }
    }

    public class Peacock : Bird
    {

        public void Dance()
        {
            Console.WriteLine("Peacock is dancing");
        }
    }

    //Syntax for interface

    //Access_Specifier interface InterfaceName
    //{
    //   //Method decalrations
    //}

    //multiple inheritance
    public interface TestInterface1
    {
        void TestMethod1();
      
        void TestMethod3();
    }

    public interface TestInterface2
    {
        void TestMethod2();
        void TestMethod4();
    }

    public class MultipleClassDemo : TestInterface1, TestInterface2
    {
        public void TestMethod1()
        {
            Console.WriteLine("Test method 1 called");
        }

        public void TestMethod2()
        {
            Console.WriteLine("Test method 2 called");
        }

        public void TestMethod3()
        {
            Console.WriteLine("Test method 3 called");
        }

        public void TestMethod4()
        {
            Console.WriteLine("Test method 4 called");
        }
    }





}
