using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class InterfaceEg
    {
        static void Main()
        { 
        
        Product product = new Product();

            product.Display();

            IProduct prd=product;

            prd.Display();

            IProductBase prd1 = product;
            prd1.Display();




        
        }


    }

    interface IProduct
    {
        int LotNo { get; set; }
        int ProductId { get; set; }
        string ProductName { get; set; }

        void Display();
    }

    interface IProductBase
    {
        void Display();
    }



    class Product : IProduct, IProductBase
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int LotNo { get; set; }

        public void Display()
        {
            Console.WriteLine("Implicit display");

        }
        int IProduct.LotNo { get; set; }
        int IProduct.ProductId { get; set; }
        string IProduct.ProductName { get; set; }

        void IProduct.Display()
        {
            Console.WriteLine(" Iproduct  Explicit Display");
        }

        void IProductBase.Display()
        {
            Console.WriteLine("Product Base ; Explicit Display");
        }


    }


}
