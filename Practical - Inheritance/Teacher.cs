using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInheritance
{
    public class Teacher: BasePerson
    {
        public int Salary { get; set; }
        //Constructor denemesi 
        public Teacher(string firstName, string lastName, int salary) : base(firstName, lastName)
        {
            Salary = salary;
        }

        

        public override void ShowInfo()
        {
            Console.WriteLine($"Salary: {Salary}");
            base.ShowInfo();
        }

    }
}
