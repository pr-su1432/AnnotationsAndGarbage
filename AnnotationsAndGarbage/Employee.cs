using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsAndGarbage
{
    internal class Employee
    {
        int id;
        string name;
        public Employee(int i, string n)
        {
            id = i;
            name = n;
        }
        [NewAttribute("Accessor", "Gives value of Employer Id")]
        public int getId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives value of Employer Name")]
        public string getName()
        {
            return name;
        }
    }
}
