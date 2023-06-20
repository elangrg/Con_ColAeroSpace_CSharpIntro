﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class LINQ_Std_Operators
    {


        static Customer[] customers = new Customer[] {
  new Customer {Name = "Paolo", City = "Brescia",
      Country = Countries.Italy, Orders =
  new Order[] {
    new Order {Quantity = 3, IdProduct = 1 , Shipped = false, Month = "January"},
    new Order {Quantity = 5, IdProduct = 2 , Shipped = true, Month = "May"}
  }},

    new Customer {Name = "Marco", City = "Torino", Country = Countries.Italy, Orders =
  new Order[] {
    new Order {Quantity = 10, IdProduct = 1 , Shipped = false, Month = "July"},
    new Order {Quantity = 20, IdProduct = 3 , Shipped = true, Month = "December"}}},

    new Customer {Name = "James", City = "Dallas", Country = Countries.USA, Orders =
  new Order[] {
    new Order {Quantity = 20, IdProduct = 3 , Shipped = true, Month = "December"}}},

       new Customer {Name = "Bond", City = "Dallas", Country = Countries.USA, Orders =
  new Order[] {
    new Order {Quantity = 20, IdProduct = 3 , Shipped = true, Month = "January"}}},

    new Customer {Name = "Frank", City = "Seattle", Country = Countries.USA, Orders =
  new Order[] {
    new Order {Quantity = 20, IdProduct = 5 , Shipped = false, Month = "July"}}},

     new Customer {Name = "Smith", City = "Seattle", Country = Countries.USA, Orders =
  new Order[] {
    new Order {Quantity = 20, IdProduct = 5 , Shipped = false, Month = "July"}}}



 };

        static ProductLinq[] products = new ProductLinq[] {
    new ProductLinq {IdProduct = 1, Price = 10 },
    new ProductLinq {IdProduct = 2, Price = 20 },
    new ProductLinq {IdProduct = 3, Price = 30 },
    new ProductLinq {IdProduct = 4, Price = 40 },
    new ProductLinq {IdProduct = 5, Price = 50 },
    new ProductLinq {IdProduct = 6, Price = 60 }};



        static void Main()
        {
            // LINQIntro();
            //BasicIntro();


            string choice = "";

            do
            {
                Console.Clear();
                Console.WriteLine("LINQ Standard Operators \n\n\n1. Where\n\n2. Select\n\n3. Sort\n\n4. Group\n\n5. Join \n\n0. Exit \n\n\n\n");
                Console.Write("Enter Choice:");
                choice = Console.ReadLine();



                if (choice == "1")
                {

                    ExecuteWhere();

                }
                if (choice == "2")
                {
                    SelectOperator();

                }

                if (choice == "3")
                {
                    OrderByOperator();

                }
                if (choice == "4")
                {
                    GroupByOperator();

                }
                if (choice == "5")
                {
                    JoinOperator();

                }

            } while (choice != "0");



        }



        public static void OrderByOperator()
        {
            var expr =
   from c in customers
       //where c.Country == Countries.Italy
   orderby c.Name descending, c.Country
   select new { c.Name, c.City };



            var expr1 = customers
    .Where(c => c.Country == Countries.Italy)
    .OrderByDescending(c => c.Name)
    .ThenBy(c => c.Country);
            //.Select(c=>c);

        }
        private static void BasicIntro()
        {
            //Func<int,int,int> fptr2 = (i, j) => i + j;
            //Action<string> ac = msg => Console.WriteLine(msg);


            //dlgDemo fptr = (i, j) => i + j;

            // IEnumerable<Customer> qry=  customers.Where(FilterCriteria);

            //  IEnumerable<Customer> qry = customers.Where(c=>c.Country== Countries.Italy);

            var qry = customers.Where(c => c.Country == Countries.Italy);

            foreach (var item in qry)
            {
                Console.WriteLine(item.Country + item.Name);
            }
        }

        public static bool FilterCriteria(Customer c)
        { return c.Country == Countries.USA; }


        private static void ExecuteWhere()
        {
            //pattern matching

            var qry = customers.Where(c => c.Name.Contains("o"));

            foreach (var item in qry)
            {
                Console.WriteLine(item.Name);
            }
            //Console.WriteLine("Qry1 : Result....");
            //var qry1 = customers.Where(c =>
            //Regex.IsMatch(c.Name, "[A-M][A-Za-z]*"));

            //foreach (var item in qry1)
            //{
            //    Console.WriteLine(item.Name);
            //}


            var demo = customers.Where(c => c.Country == Countries.Italy)
                   .Select(c => new { c.Name, c.City });

            var WhereExpr =
            from c in customers
            where c.Country == Countries.Italy
            select new { c.Name, c.City };



            //var Qry10 =
            //    from p in products
            //    where p.Price > 30
            //    select p;




            var expr6 =
              customers
              .Where((c, index) =>
                  (c.Country == Countries.Italy && index >= 1))
              .Select(c => c.Name).ToList();




            foreach (var item in expr6)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(customers.Count(c => c.Country == Countries.USA));



            Console.WriteLine("Press Any key to continue...");


            Console.ReadKey();
        }


        public static void SelectOperator()
        {
            IEnumerable<string> d = customers.Select(c => c.Name);

            //Projection Operator Select
            var expr2 = customers.Select(c => new { c.Name, c.City });
            var expr8 = customers.Select(c => new Customer { Name = c.Name, Country = c.Country });

            var rst = expr2.ToList();


            IEnumerable<Order[]> expr3 = customers.Select(c => c.Orders);

            IEnumerable<Order> expr4 = customers.SelectMany(c => c.Orders);






            IEnumerable<Order> orders1 =
     from c in customers
         // where c.Country == Countries.Italy
     from o in c.Orders
     select o;



            Console.WriteLine("Press Any key to continue...");


            Console.ReadKey();
            Console.Clear();


        }


        public static void JoinOperator()
        {
            var expr =
    customers
    .SelectMany(c => c.Orders)
     .Join(products,
           o => o.IdProduct,
           p => p.IdProduct,
           (o, p) => new { o.Month, o.Shipped, p.IdProduct, p.Price });


            foreach (var item in expr)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Press Any key to continue...");


            Console.ReadKey();
            Console.Clear();

        }


        public static void GroupByOperator()
        {


            var grpIntro = customers.GroupBy(c => c.Country);




            var expr =
   customers
   .GroupBy(c => new { c.Country }, c => new { c.Name, c.City, c.Country, c.Orders });

            foreach (var customerGroup in expr)
            {
                Console.WriteLine("Country: {0}", customerGroup.Key);
                Console.WriteLine(customerGroup.Key + " has - >  " + customerGroup.Count());
                foreach (var item in customerGroup)
                {

                    Console.WriteLine("  {0}", item.Name);
                }
            }





            var results = from c in customers
                          group c by c.Country into g
                          select new { Country = g.Key, groupedResult = g.ToList() };


            var results1 = from c in customers
                           from o in c.Orders
                           group o by o.Month into g
                           // orderby g.Key 
                           select new { Month = g.Key, Orders = g.ToList() };

            foreach (var item in results1)
            {
                Console.WriteLine(item.Month);
                foreach (var Order in item.Orders)
                {

                    Console.WriteLine(Order.IdProduct);
                }
            }

        }


        private static void LINQIntro()
        {
            List<Course> _lstCourses = new List<Course>() {
            new Course{ CourseId =1000, CourseName="ASP.NET", Duration=40 },
             new Course{ CourseId =1001, CourseName="ASP.NET Core 3.1", Duration=30 },
              new Course{ CourseId =1002, CourseName="ASP.NET Core 6.0", Duration=50 },
               new Course{ CourseId =1003, CourseName="ASP.NET MVC 5", Duration=40 },
            };


            IEnumerable<Course> qry = _lstCourses.Where(c => c.Duration == 40);

            foreach (var item in qry)
            {
                Console.WriteLine(item.CourseName);
            }

            Console.ReadKey();
        }
    }



    public enum Countries
    {
        USA,
        Italy,
    }
    public class Customer
    {
        public string Name;
        public string City;
        public Countries Country;

        public Order[] Orders;
    }

    public class Order
    {
        public int Quantity;
        public bool Shipped;
        public string Month;
        public int IdProduct;
    }

    public class ProductLinq
    {
        public int IdProduct;
        public decimal Price;
    }




}
