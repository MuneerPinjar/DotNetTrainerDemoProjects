using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    /// <summary>
    /// Abstract class (Super Class)
    /// </summary>
    public abstract class Shape
    {
        //abstract method
        public abstract int area();


        public abstract int AreaofCircle();


    }

    public abstract class ActionResult
    {

        //abstract data memebr
        public abstract string ReturnTheResult();


    }


    public class JsonResult : ActionResult
    {
        public override string ReturnTheResult()
        {

            // return json result
            throw new NotImplementedException();
        }
    }

    public class FileResult : ActionResult
    {
        public override string ReturnTheResult()
        {
            throw new NotImplementedException();
        }
    }

    public class ViewResult : ActionResult
    {
        public override string ReturnTheResult()
        {
            throw new NotImplementedException();
        }
    }

    public class Square : Shape
    {
        //private data memebers
        private int side;

        public Square(int x = 0)
        {
            side = x;
        }

        //override of the abstract method of shape
        // class using the override keyword

        public override int area()
        {
            Console.WriteLine("Area of Square}");
            return (side*side);
        }

        public override int AreaofCircle()
        {
            throw new NotImplementedException();
        }
    }

    public class Circle : Shape
    {
        private const double pie = 3.142;
        private double _radius;

        public Circle(double radius = 0)
        {
            _radius = radius;
        }

        public virtual void Display()
        {
            Console.WriteLine( "Implementaiton of Circle class");
        }

        public override int area()
        {
            Console.WriteLine("Area of the circle");

            return Convert.ToInt32((pie * _radius * _radius));
            

        }

        public override int AreaofCircle()
        {
            throw new NotImplementedException();
        }

        public class TestClass123 : Circle
        {
            public override void Display()
            {
                Console.WriteLine("Implementation of test class");
            }
        }
    }







}
