using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDemo
{
    public struct Person
    {
        //Decalre different data types
        private string name ="";
        private int id=0;
        private int age=0;
        private int weight=0;


        public Address address;

        // Public properties in order to get and set the private data tpyes
        public int Id {


            //read only propertery 
            get
            {
                return id;
            }

            //  Set only property
            set
            {

                id = value;
            }

        }
        public int Age {


            //read only propertery 
            get
            {
                return age;
            }

            //  Set only property
            set
            {

                age = value;
            }

        }
        public int Weight {

            //read only propertery 
            get
            {
                return weight;
            }

            //  Set only property
            set
            {

                weight = value;
            }

        }

        public string Name { 
            
            
            get { return name; }
           
            set
            {

                name= value;
            }

        }
    }

    public struct Address
    {

        //data member of Address Structure
        public string city;
        public string state;
        public string zip; 
        public string country;
    }
}
