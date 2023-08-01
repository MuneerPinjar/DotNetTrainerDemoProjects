using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    /// <summary>
    /// 
    /// </summary>
    public class DemoEncap
    {
        //private variables / data members

        private string title;
        private string description;



        // using properties we can set or get the private data variables


        public string Title
        {

            // readonly 
            get

            {

                return title;
            }

            //write only method
            set
            {
                title = value;

            }
        }


        public string Description
        {
            get { return description; }

            set { description = value; }
        }
    }





}
