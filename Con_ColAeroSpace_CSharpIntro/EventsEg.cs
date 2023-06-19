using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{

    class PartialOrderArg
    {
        public int AvailableQty { get; set; }
        public bool Continue { get; set; } = false;


    }

    delegate void PartialOrderNotification(PartialOrderArg Arg);



    internal class OrderService
    {

        public event PartialOrderNotification PartialOrderNotify = null;

        int _AvailableQty = 8;

        public int ReorderLevel = 20;

        public void PlaceOrder(string PrdName, int Qty)
        {

            

            // Scenario 3 partial Order
            if (Qty>_AvailableQty)
            {
                PartialOrderArg orderArg = new PartialOrderArg();
                orderArg.AvailableQty = _AvailableQty;

                if (this.PartialOrderNotify!=null)
                {
                    this.PartialOrderNotify(orderArg);
                    if (orderArg.Continue)
                    {
                        Qty=_AvailableQty;
                        Console.WriteLine($"Order Processed for Qty = {Qty} ");
                    }
                    else
                        Console.WriteLine("Order Declined!!!");

                }


            }


            Console.ReadKey();
        }


    }



    class OrderUISubscriber
    {        static void Main()
        {
            OrderService objOrderService = new OrderService();
            
            // Add Subscribtion
            objOrderService.PartialOrderNotify += PartialOrderAnotherHandler;
                // Problem 2 : Subscriber is replacing other subscribtion
            objOrderService.PartialOrderNotify += PartialOrderHandler;

            // Problem 3: Subscriber is Publishing
          //  objOrderService.PartialOrderNotify(new PartialOrderArg ());
            Console.Write("Enter Product Name:");string prdnm = Console.ReadLine();
            Console.Write("Enter Quantity:");
            int qty = 0;

            if (int.TryParse(Console.ReadLine(), out qty))
            {
                objOrderService.PlaceOrder(prdnm, qty);
            }
            else
            Console.WriteLine("Invalid Data");

            Console.ReadKey();

        }

     static void PartialOrderHandler(PartialOrderArg e)
        {
            Console.Write($"Available Quantity is {e.AvailableQty}, Continue With {e.AvailableQty}? (Y/N) : ");
            e.Continue = Console.ReadLine().ToUpper() == "Y";
        }
        
        static void PartialOrderAnotherHandler(PartialOrderArg e)
        {
            Console.WriteLine("PartialOrderAnotherHandler Called!!!");
        }
    }



}
