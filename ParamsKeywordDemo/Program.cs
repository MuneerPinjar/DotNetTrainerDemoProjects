using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeywordDemo
{
    class Program
    {
        /// <summary>
        /// Add operation
        /// </summary>
        /// <param name="listNumbers"> list of intergers</param>
        /// <returns> Sum of all the interger array </returns>
        public static int Add(params int[] listNumbers)
        {
            int total = 0;

            //Add operation

            foreach (var i in listNumbers)
            {
                // total = total+i;
                total += i;
            }


            return total;
        }

        public static void DisplayDetails(string des=null,int test = 0)
        {

        }



        public static void DisplayRandomMessage(params object[] messageList) {

            StringBuilder _result = new StringBuilder();

            /*foreach (var item in messageList)
            {
                _result.Append(item);
                _result.AppendLine();
            }*/
            Console.WriteLine("Result : "+_result);
        
        }


        static void Main(string[] args)
        {


            //calling a function by passing 5 arguments

            int y = Add(10, 10, 40, 90, 10);

            Console.WriteLine("5 Arguments Result : "+y);

            int testres = Add(30, 20);

            Console.WriteLine("2 Arguments Result :"+testres);

            DisplayRandomMessage("Hello Everyone", "Welcome to BootCamp learning program", DateTime.Now.Date.ToShortDateString(), 1235);


            Console.ReadLine();
        }
    }
}
