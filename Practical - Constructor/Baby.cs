

namespace ConstructorFirst
{
    public class Baby
    {
        //Bebek sınıfının propertyleri -> Doğum Tarihi , Ad , Soyad 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //1.si Default Constructor tarzında parametre almayan bir metot.
        public Baby()
        {
            FirstName = "";
            LastName = "";

            Console.WriteLine("Ingaaaaa");
            BirthDate = DateTime.Today;
        }

        //2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.
        public Baby(string firstName, string lastName)
        {
            Console.WriteLine("Ingaaaaa");
            FirstName = firstName;
            LastName = lastName;
            BirthDate = DateTime.Today;
        }


        public void Info()
        {
            Console.WriteLine($"Name : {FirstName},LastName: {LastName} ,Date of Birth: {BirthDate}");
        }







    }
}
