using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class ExceptionHandling
    {
        static void Main()
        {

            Console.Write("Enter Qty: ");

            int i = 0;

            try
            {
                try
                {
                    i = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {

                    CustomExpection exp = new CustomExpection("trans1204242342");

                    throw exp;


                    Console.WriteLine("Invalid Number, ...");


                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(" Number to Long , ...");
                }
                finally
                {
                    Console.WriteLine("Finally Called inner");

                }




                Console.WriteLine("Enter Date");

                DateTime j = DateTime.Parse(Console.ReadLine());





            }
            catch (Exception ex)
            {

                Console.WriteLine("Some thing went wrong .... \n\n" + ex.ToString());
            }
            finally { Console.WriteLine(" Outer Finally Called !..."); }

            
            
            
            Console.ReadKey();
        

        
        }


        static void Display()
        { 
        
        
        
        
        }


      }



    class CustomExpection:ApplicationException
    {

        public CustomExpection(string transactionId):base("Custom Error Message for Payment Gateway Failure")
        {
            
            TransactionId = transactionId;
        }

        public string TransactionId { get; set; }



    }


}
