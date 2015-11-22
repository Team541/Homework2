using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCar nCar = new ClassCar("Lada", "D");
            nCar.Color = Color.Purple;
            try
            {
                Console.WriteLine(nCar.CarPassport.Owner.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы не ввели имя владельца!");
            }

            ClassDriver Voldemar = new ClassDriver("Voldemar", new DateTime(2000,10,10));
            Voldemar.Category = "BC";
            nCar.ChangeOwner(Voldemar,"o777oo");
            Voldemar.Category += "D";
            nCar.ChangeOwner(Voldemar, "o777oo");

            Console.WriteLine("Номер машины Вольдемара " + Voldemar.Car.CarNumber);
            Console.WriteLine("Имя владельца лады " + nCar.CarPassport.Owner.Name);
            Console.ReadKey();
        }
    }
}
