using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    //generic T param
    class Employee<T>
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }

        public List<T> Things { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>
            {
                id = 1,
                fName = "Yujin",
                lName = "Ahn",
                Things = new List<string> { "Laptop", "Notebook", "Pen" }
            };

            Employee<int> employee2 = new Employee<int>
            {
                id = 2,
                fName = "Minju",
                lName = "Kim",
                Things = new List<int> { 100, 102, 103 }
            };

            //loops all yujinahn's things
            Console.WriteLine("Employee 1's Things");
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            //loops all minjukim's things (in int)
            Console.WriteLine("\nEmployee 2's Things:");
            foreach(int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
