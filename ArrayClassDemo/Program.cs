using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassDemo
{

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //declare an 1D array of string

            string[] store;

            store = new string[10];
            int[] a = new int[10];
            int[][][] cc = new int[10][2][];
            int[][] c = new int[10][];
            int[,,,] d = new int[10, 2, 2, 2];

            store[0] = "A";
            var ababzb = new IComparable();
            var aasdfadsf = new[] { 0 };
            var aadsgadfhs = new Int32();

            store = new string[] { "Book", "Pen", "Ruler" };




            List<Student> students = new List<Student>();

            students.Add(new Student() { Id =101,Name= "Rock"});
            students.Add(new Student() { Id = 102, Name = "Rock" });
            students.Add(new Student() { Id = 103, Name = "Sam" });
            students.Add(new Student() { Id = 104, Name = "Drake" });
            students.Add(new Student() { Id = 105, Name = "Rock" });
            students.Add(new Student() { Id = 106, Name = "Rock" });


            foreach (var item in students)
            {
                
            }

          var student =   students.Where(i => i.Id == 101).FirstOrDefault();


            students.Remove(students[0]);


            int[] testint = new int[] { 1, 2, 3 };


            Array.Sort(testint);


            Array.Sort(testint);


            Array.Reverse(store);


            //Non-generic and its not a strong typed
            ArrayList arrayList = new ArrayList();

            arrayList.Add(90.090);




            List<int> list = new List<int>();

            List<string> vs = new List<string>();



            arrayList.Add(10.0);
            arrayList.Add(132);
            arrayList.Add("This is test data");

            arrayList.Add("Test is data type");





            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            IList arrylist1 = new ArrayList();

            List<int> vs4 = new List<int>();

            List<object> list1 = new List<object>();

            List<Order> orders = new List<Order>();

            for (int i = 0; i < 100; i++)
            {
                list1.Add("This is testdata : "+ i.ToString());
            }

            foreach (var item in list1)
            {

            }
         



            //List<T>() -->This constructor is used to create an instance of List<T> class that is empty and has the default intital capacity








            IEnumerable testen = new ArrayList();

            IEnumerable vs1 = new List<string>();

            IEnumerable vs2 = new HashSet<string>();

            IEnumerable vs3 = new Dictionary<int,string>();

            


        }
    }
}
