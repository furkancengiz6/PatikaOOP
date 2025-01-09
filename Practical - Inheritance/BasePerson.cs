using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInheritance
{
    //base sınıfı abstract yaparak bu sınıftan nesne oluşturulmasını engelledik.
    public abstract class BasePerson
    {
        //Ortak özelliklerimizi burada tanımladık.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Ortak metotlarımızı burada tanımladık.
        public virtual void ShowInfo()
        {
            Console.WriteLine($"First Name: {FirstName}\nLast Name: {LastName}");
        }

        //Constructor denemesi
        public BasePerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            ShowInfo();
        }

    }
}
