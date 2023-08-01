using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeywordDemo2
{
    public class Complex
    {


        //private data memebers 
        private int real, img;

        public Complex()
        {

        }

        //Patameterize constructor to use to initialize private data memebers
        public Complex(int r,int i)
        {
            real = r;
            img = i;
        }

        //Method to get value of real data member
        public int getRealValue()
        {
            return real;
        }

        //Method to get value of real data member
        public int getImgValue()
        {
            return img;
        }

        //Method to update value of complex object using reference of the object
        public static void Update(ref Complex obj)
        {
            /// we can perform actions in order update data members, propertes, events etc..
            obj.real += 10;
            obj.img += 10;
        }

    }
}
