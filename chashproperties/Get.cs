using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chashproperties
{
    class Employee
    {
        public int age;
        public string name;

        public int Age
        {
            get
            {
                return age;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Employee()
        {
            age = 30;
            name = "XYZ";
        }
    }
    

}
