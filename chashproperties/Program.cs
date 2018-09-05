using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chashproperties
{
    class Self
    {
        public readonly string name = "Sudha Avinash";  // Initializing Read Only variable

        public readonly string location;        // Declaring Read Only variables

        public readonly int house_no;

        public Self()        //or we can do it in constructor
        {

            location = "Dubai";

            house_no = 308;

        }

        public void Address()
        {
            //location = "India";        // Compile error bcz we use read only

            //house_no = 30;

        }
    }
    class Program
    {
        static void Main(string[] args)

        {
            Self u = new Self();
            //u.name = "Asha";              // error bcz v cnt initilize readonly
            Console.WriteLine("Imlimenting Readonly Property");
            Console.WriteLine("Name: {0}", u.name);
            Console.WriteLine("Location: {0}", u.location);
            Console.WriteLine("House_no: {0}\n", u.house_no);

            Console.WriteLine("Imlimenting Write only Property");
            Draw d = new Draw();
            d.shape = "Circle";
            d.clr = "Blue";
            Console.WriteLine("Sahpe is  :{0}",d.GetShape());
            Console.WriteLine("Colour is :{0}\n",d.GetColor());

            Console.WriteLine("Imlimenting Read only Property");
            Employee emp = new Employee();
            Console.WriteLine("Age: {0}", emp.age);
            Console.WriteLine("Name: {0}", emp.name);

            Console.ReadLine();
        }

    }
}