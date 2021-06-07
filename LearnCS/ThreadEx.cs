using System;
using System.Threading;

namespace LearnCS
{

    class Printer  //version 1.0
    {
        char ch;
        int sleeptime = 0;
        public Printer(char c, int sleeptime)
        {
            ch = c;
            this.sleeptime = sleeptime;
        }
        // print the data in parallel
        public void Print()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(ch);
                Thread.Sleep(this.sleeptime);
            }
            Console.WriteLine("End of charcher {0}", ch);
        }
    }

    class ThreadEx
    {
         void Main() // first process
        {

            // states of the thread 
            Printer a = new Printer('.', 500);
            Thread t = new Thread(a.Print);
            t.Name = "Worker Thread";
            t.Priority = ThreadPriority.Normal;
            Console.WriteLine("name = {0}, priority = {1}, state = {2}", t.Name, t.Priority, t.ThreadState);
            t.Start();
            Thread.Sleep(1000);
            Console.WriteLine("name = {0}, priority = {1}, state = {2}", t.Name, t.Priority, t.ThreadState);
            t.Suspend();
            Console.WriteLine("name = {0}, priority = {1}, state = {2}", t.Name, t.Priority, t.ThreadState);
            Thread.Sleep(2000);
            t.Resume();
            Console.WriteLine("name = {0}, priority = {1}, state = {2}", t.Name, t.Priority, t.ThreadState);
            t.Abort();
            Thread.Sleep(0);
            Console.WriteLine("name = {0}, priority = {1}, state = {2}", t.Name, t.Priority, t.ThreadState);

            //Printer a = new Printer('.',500);
            //Printer b = new Printer('*',1000);
            //Thread t1 = new Thread(a.Print);
            //t1.Start(); // new thread process
            //Thread t2 = new Thread(b.Print);
            //t2.Start(); // new thread proces
            ////Thread.Sleep(2000);
            //t1.Join();
            //Console.WriteLine("Main Thread end");
            Console.Read();
        }
    }
}
