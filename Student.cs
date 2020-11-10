using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3

{
    public class Student
    {
        string department;
        string id;
        string name;
        float cgpa;
        public Student()
        {
            name = "Sharmin";
            id = "17-33604-1";
            cgpa = 3.56f;
            department = "CSE";
        }

        public Student(string name, string id, float cgpa, string department)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.department = department;
        }
        public void ShowInfo()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Cgpa : " + cgpa);
            Console.WriteLine("Department : " + department);
        }
    }
}
