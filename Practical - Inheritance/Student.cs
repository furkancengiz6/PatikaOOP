using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInheritance
{
    internal class Student:BasePerson
    {

        //StudentNumber adında bir property eklendi ve constructor metodu güncellendi.
        public int StudentNumber { get; set; }

        public Student(string firstName, string lastName, int strudenNumber) : base(firstName, lastName)
        {
            StudentNumber = strudenNumber;
           
            
        }

        //ShowInfo metodu override edildi.
        public override void ShowInfo()
        {
            Console.WriteLine($"Student Number: {StudentNumber}");
           
        }
      





    }
}
