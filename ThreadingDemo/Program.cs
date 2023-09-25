using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class ThreadTest
    {
        bool done;
        static void Main(string[] args)
        {
            ThreadTest tt = new ThreadTest();
            new Thread(tt.Go).Start();
            tt.Go();

        }

        void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
