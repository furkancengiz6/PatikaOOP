using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEncapsulation
{
    public class Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        private int doorCount;
        //Kapı sayısı 2 veya 4 olabilir. Kapsülleme yaparak bu kuralı sağlayalım.
        public int DoorCount
        {
            get
            {
                return doorCount;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    doorCount = value;
                }
                else
                {
                    Console.WriteLine("Kapi sayisi 2 veya 4 olmalidir.");
                    doorCount -= 1;
                }
            }
        }

     
        public Car(string brand, string model, string color, int doorCount)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount;
            Console.WriteLine($"Araba olusturuldu.\nMarka : {Brand} , \nModel: {Model}, \nRenk: {Color}, \nKapı Sayisi: {DoorCount} ");
        }



    }
}
