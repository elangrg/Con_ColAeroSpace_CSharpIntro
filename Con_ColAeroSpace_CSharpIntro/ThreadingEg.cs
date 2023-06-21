using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Con_ColAeroSpace_CSharpIntro
{
    internal class ThreadingEg
    {
        static void Main()
        {
            Thread.CurrentThread.Name = "PRIM";
            Worker objWorker = new Worker();



            Thread t1 = new Thread(objWorker.DoWork);
            t1.Name = "SEC1";
            t1.IsBackground= true;

            t1.Start();

            Console.WriteLine("After Thread Init");


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"I value is {i} is part of thread '{Thread.CurrentThread.ManagedThreadId}, {Thread.CurrentThread.Name}'");
                Thread.Sleep(100);
            }
            Console.WriteLine("EOL of Main");
            Console.ReadKey();

        }



    }


    class Worker
    {
        int _ctr = 0;

        public void DoWork()
        {

            for (int i = 0; i < 100; i++)

            {
                Console.WriteLine(   $"CTR value is {_ctr} is part of thread '{Thread.CurrentThread.ManagedThreadId}, {Thread.CurrentThread.Name}'"  );
                _ctr++;
                Thread.Sleep(300);
            }

        }


    }



}
