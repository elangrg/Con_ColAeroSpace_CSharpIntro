using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class ProgramConstructs
    {

        static void Main()
        {
            Example();

        
        }


        public static void Example()
        {
            Console.WriteLine(GlobalSetting.Name);


            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);


            //if (true)
            //{

            //}
            //else
            //{

            //}

            //NewMethod();


            Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
            Console.Write("Please enter your selection: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int cost = 0;
            switch (n)
            {
                case 1:
                    cost += 25;
                    break;
                case 2:
                    cost += 25;
                    goto case 1;
                case 3:
                    cost += 50;
                    goto case 1;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }

          


            if (cost != 0)
                Console.WriteLine("Please insert {0} cents.", cost);
            Console.WriteLine("Thank you for your business.");

            Console.ReadKey();

        }

 void NewMethod()
            {
                for (int inc = 0; inc < 100; inc++)
                {
                    Console.WriteLine(inc);
                }
            }

    }
}
