using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        //Field - Alanlar prive olmalıdır
        private string FirstName { get; set; }

        private string LastName { get; set; }

        private DateTime BirthDate { get; set; }



        //Kapsulleme kullanımı zorunlu oluyor fieldlar private oldugu icin

        public Person(string firstName,string lastName, DateTime birtDate) 
        {

            FirstName = firstName;
            LastName = lastName;
            BirthDate = birtDate;
        }

        //Method olusturuldu bilgi vermek icin
        public void Info()
        {
            Console.WriteLine($"Name : {FirstName},LastName: {LastName} ,Date of Birth: {BirthDate}");
        }

    }
}