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
            public Person(string F, string L, string HP, string WP)
            {
                firstName = F;
                lastName = L;
                homePhone = HP;
                workPhone = WP;
            }
        }
        
        static void Main(string[] args)
        {
            Person Arne = new Person("Arne", "Saknusem", "013-13 13 13", "073 - 747 57 67");
            Arne.Print();
        }                
    }
}
