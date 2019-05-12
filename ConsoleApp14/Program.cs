using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonList personList = new PersonList();
            foreach (Person item in personList)
            {
                Console.WriteLine("{0},{1}", item.Name, item.Age);
            }

            Console.ReadLine();
        }
    }
}
