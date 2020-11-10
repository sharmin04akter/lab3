using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3

{
    class main
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ShowInfo();

            Triangle t = new Triangle();
            t.ShowInfo();
            t.TestTriangle();

            Account a = new Account();
            a.ShowInfo();
            a.Amount = 600;
            a.Deposit(600);
            a.Withdraw(600);

            Course c = new Course();
            c.CourseInfo();
        }
    }
}
