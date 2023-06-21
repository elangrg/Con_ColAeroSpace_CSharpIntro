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
            t1.Start();


            Thread t2 = new Thread(objWorker.DoOtherWork);
            t2.Name = "SEC2";
            t2.Start();


           
            Console.WriteLine("EOL of Main");
            Console.ReadKey();

        }



    }


    class Worker
    {
        int _ctr = 0;

        public void DoWork()
        {

            lock (this)
            {
                for (int i = 0; i < 100; i++)

                {
                    Console.WriteLine($"CTR value is {_ctr} is part of thread '{Thread.CurrentThread.ManagedThreadId}, {Thread.CurrentThread.Name}'");
                    _ctr++;
                    Thread.Sleep(300);
                } 
            }

        }


        public void DoOtherWork()
        {

            lock (this)
            {
                for (int i = 0; i < 100; i++)

                {
                    Console.WriteLine($"CTR value is {_ctr} is part of thread '{Thread.CurrentThread.ManagedThreadId}, {Thread.CurrentThread.Name}'");
                    _ctr++;
                    Thread.Sleep(300);
                }

            }
        }

    }



}
