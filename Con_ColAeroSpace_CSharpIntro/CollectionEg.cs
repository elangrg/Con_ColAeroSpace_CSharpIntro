using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class CollectionEg
    {

        static void Main()
        {
            #region Collection Intro
            List<string> lstNames = new List<string>()
            {
            "Suresh","Shiv","Ramesh"
            };

            lstNames.Add("Ganesh");
            lstNames.Add("Mahesh");

            Console.WriteLine("\n\nFor Each loop\n\n");
            foreach (string name in lstNames)
            {
                Console.WriteLine(name);
            }

            lstNames.Remove("Suresh");

            lstNames.RemoveAt(1);
            Console.WriteLine("\n\nFor Each Method");
            lstNames.ForEach(n => Console.WriteLine(n));


            Console.WriteLine(lstNames.Count + " \n Found ");

            Console.WriteLine(lstNames.Find(s => s.Contains("esh")));

            Console.WriteLine("Dictionary Eg ");


            Dictionary<int, string> dicEmpnames = new Dictionary<int, string>();

            dicEmpnames.Add(100, "Ganesh");
            dicEmpnames.Add(110, "Dinesh");
            dicEmpnames.Add(200, "Annesh");
            dicEmpnames.Add(201, "Rajesh");


            foreach (KeyValuePair<int, string> emp in dicEmpnames)

            {
                Console.WriteLine(emp.Key + " =>" + emp.Value);

            }

            dicEmpnames.Remove(200);


            Console.WriteLine("List =>  index based Random access" + lstNames[1]);
            Console.WriteLine("Dictionary -> Key based Random access" + dicEmpnames[100]);


            Console.WriteLine(dicEmpnames.Count);
            #endregion


            #region IEnumerable Intro

            Console.WriteLine("IEnumerable Example");
            EmployeeList objLst = new EmployeeList();

            foreach (string name in objLst)
            {
                Console.WriteLine(name);
            }



            #endregion


            #region Iterator Example
            Console.WriteLine("Iterator example");
            foreach (string Name in GetNames(true))
            {
                Console.WriteLine(Name) ;
            }



            #endregion

            Console.ReadKey();


        }


        static IEnumerable GetNames(bool allNames = false)
        {
            yield return "Amaresh";

            yield return "Rajesh";
            yield return "Vignesh";
            if (allNames == false)
                yield break;

            yield return "Mukesh";


        }





    }




    class EmployeeList : IEnumerable
    {
        List<string> lst = new List<string>() {"John","Jim","Jack" };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StringEnumerator(lst);
        }
    }


    class StringEnumerator : IEnumerator
    {
        List<string> _lst = null;

        int idx = -1;

        public StringEnumerator(List<string> lst)
        {
            _lst = lst;
        }


        public object Current => _lst[idx];

        public bool MoveNext()
        {
            idx++;

            return idx < _lst.Count;
        }

        public void Reset()
        {
           idx = -1;
        }
    }

}


