using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class PersonesEnumerator : IEnumerator
    {
        PersonList persones;
        Person CurrentPerson;
        int currentIndex;

        public PersonesEnumerator(PersonList customerList)
        {
            persones = customerList;
            currentIndex = -1;
        }

        public object Current => CurrentPerson;

        public bool MoveNext()
        {
            if ((currentIndex++) >= persones.Count() - 1)
                return false;
            else
                CurrentPerson = persones[currentIndex];
            return true;
        }

        public void Reset()
        {
        }
    }
}
