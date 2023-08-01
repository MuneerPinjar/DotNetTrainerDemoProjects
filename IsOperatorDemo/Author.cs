using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOperatorDemo
{
    public class Author
    {
        //data members
        public string name;
        public string description;
        public int rank;


        //method of Author class
        public void AuthorDetails(string _name, string _description, int _rank)
        {
            name = _name;
            description = _description;
            rank = _rank;
        }
    }

    public class Work
    {

        //data members
        public int article_no;
        public int   id;

        //method of work class
        public void TestMethod(int _articleNo,int _id)
        {
            article_no = _articleNo;
            id = _id;
        }


        
    }
}
