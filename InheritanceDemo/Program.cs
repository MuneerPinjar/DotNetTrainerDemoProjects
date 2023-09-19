﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class A
    {

        public void D1()
        {
            Console.WriteLine("A D1");
        }
        public virtual void  D2()
        {
            Console.WriteLine("A D2");
        }

    }

    public class B : A
    {
        public void D1()
        {
            Console.WriteLine(" B D1");
        }

        public override void D2()
        {
            Console.WriteLine("B D2");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
           
            
            
            A a = new A();
            B b = new B();

            a.D1();
            a.D2();

            b.D1();
            b.D2();

            a = b;

            Console.WriteLine("After casting");

            a.D1();
            a.D2 ();

            
            
            
            
            
            
            
            
            
            
            
            
            //Single Inheritance

            //Animal animal = new Dog();


            //Dog dog = new Dog();
            //dog.Eat();
            //dog.Bark();


            ////multi level inheritance
            //BreedDog1 breedDog1 = new BreedDog1();
            //breedDog1.Eat();
            //breedDog1.Bark();
            //breedDog1.DisplayBreedDog1();


            ////Hierarchical Inheritance
            //Eagle eagle = new Eagle();
            //eagle.Fly();
            //eagle.Eat();
            //eagle.Hunt();

            //Penguin penguin = new Penguin();
            //penguin.Eat();
            //penguin.Fly();
            //penguin.Swim();

            //// multiple inheritance

            //MultipleClassDemo multipleClassDemo = new MultipleClassDemo();
            //multipleClassDemo.TestMethod1();
            //multipleClassDemo.TestMethod2();
            //multipleClassDemo.TestMethod3();
            //multipleClassDemo.TestMethod4();


            Console.ReadLine();


        }
    }
}
