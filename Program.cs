using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string empname;
            char empgender;
            double empSalary;
            DateTime DOJ;
      
            Console.WriteLine("Enter id");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            empname = Console.ReadLine();

            Console.WriteLine("Enter gender");
            empgender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter salary");
            empSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of joining");
            DOJ = DateTime.Parse(Console.ReadLine());
            if (empSalary > 90000)
            {
                Console.WriteLine("You have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("Tax will 15%");
            }

            Console.WriteLine("ID : \t" + id + "\n NAME: " + empname + "\n Gender: \t " + empgender + "\n salary: \t  " + empSalary + "\n Date of joining: \t " + DOJ);
            Console.ReadKey();
        }
    }
}
