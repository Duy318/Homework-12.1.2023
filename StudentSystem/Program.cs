using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass class1 = new StudentClass();
            Console.WriteLine("Please select option");
            Console.WriteLine("1. Creates a new student");
            Console.WriteLine("2. Information about a student");
            Console.WriteLine("3. Exit");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please choose from 1 to 3");
            int ch = int.Parse(Console.ReadLine());
            do
            {
                if (ch == 1)
                {
                    class1.AddAStudentToList();
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter student's name");
                    string name = Console.ReadLine();
                    class1.FindByName(name);
                }
                else
                {
                    Console.WriteLine("Exit, see you again!!!!!!");
                    break;
                }
                Console.WriteLine("Please choose from 1 to 3");
                ch = int.Parse(Console.ReadLine());
            } while (true);
            Console.ReadLine();
        }
    }
}
