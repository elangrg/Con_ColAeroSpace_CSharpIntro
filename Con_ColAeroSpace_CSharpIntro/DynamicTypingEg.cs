using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    public class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quaaaaaack!");
        }

        public void Feathers()
        {
            Console.WriteLine("The duck has white and gray feathers.");
        }
    }

    public class Person
    {
        public void Quack()
        {
            Console.WriteLine("The person imitates a duck.");
        }

        public void Feathers()
        {
            Console.WriteLine("The person takes a feather from the ground and shows it.");
        }
    }

    class DynamicTypingEg
    {
        private static void InTheForest(dynamic duck)
        {

            duck.ghfsgjhfhjgfsgsfhsgjksfdhgsfhgskdfhgsdf();




            duck.Quack();
            duck.Feathers();
        }

        public static void Execute()
        {
            Duck duck = new Duck();
            Person person = new Person();
            InTheForest(duck);
            InTheForest(person);
        }


    }

}
