using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class PersonList:IEnumerable
    {
        Person[] persones = new Person[4];
        public PersonList()
        {
            persones[0] = new Person { Name = "Bijay Thapa", Age = 20};
            persones[1] = new Person { Name = "Jack", Age = 18};
            persones[2] = new Person { Name = "Anil min", Age = 26};
            persones[3] = new Person { Name = "Jim sin", Age = 20 };
        }

        public int Count()
        {
            return persones.Count();
        }

        public Person this[int index]
        {
            get
            {
                return persones[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return persones.GetEnumerator(); // we can do this but we are going to make our own Enumerator
        }
    }
}
