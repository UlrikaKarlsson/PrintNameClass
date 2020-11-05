using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNameClass
{
    class Program
    {
        class Person
        {
            public string firstName, lastName, homePhone, workPhone;
            public void Print()
            {
                Console.WriteLine("{0} {1}   {2}   {3}",
                    firstName, lastName, homePhone, workPhone);
            }
        }
        
        static void Main(string[] args)
        {
            Person Arne = new Person()
            {
                firstName = "Arne",
                lastName = "Saknusem",
                homePhone = "013-13 13 13",
                workPhone = "073 - 747 57 67"
            };
            Arne.Print();
        }                
    }
}
