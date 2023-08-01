using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorDemo
{
    public class TechGeeks
    {
        //private instance variables
        private string month;
        private int year;
        private string name;
        public int id;

        public TechGeeks()
        {

        }

        //Decalre copy constructor
        public TechGeeks(TechGeeks techGeeks )
        {
            this.month = techGeeks.month;
            this.year = techGeeks.year;
            this.id=techGeeks.id;
            this.name = techGeeks.name;
        }


        //parameterised constructor
        public TechGeeks(string month, int year, int id,string name)
        {
            this.month = month;
            this.year = year;
            this.id = id;
            this.name = name;
        }

        //Public method (Function)
        public string Details
        {
            get
            {

                return "Month : " + month.ToString() + "\n Year : " + year.ToString();
            }
        }
    }
}
