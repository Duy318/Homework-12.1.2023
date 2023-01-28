using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class StudentClass
    {
        List<Student> students = new List<Student>();
        public void AddAStudentToList()
        {
            Console.WriteLine("Enter the information about student");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter GPA: ");
            double gpa = double.Parse(Console.ReadLine());
            Student st1 = new Student(name, age, gpa);
            students.Add(st1);
        }
        public void FindByName(string studentName)
        {
            foreach (Student item in students)
            {
                if (item.Name == studentName) Console.WriteLine(item);
            }
        }

    }
}
