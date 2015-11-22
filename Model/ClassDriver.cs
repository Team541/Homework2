using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClassDriver
    {
        public ClassDriver(string name, DateTime licenceDate)
        {
            Name = name;
            LicenceDate = licenceDate;
        }
        public string Name { get; }
        public DateTime LicenceDate { get; }
        public int Experience => DateTime.Now.Year - LicenceDate.Year;
        public string Category { get; set; }
        public ClassCar Car { get; private set; }
        public void OwnCar(ClassCar car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                Console.WriteLine("Категория водителя не подходит к категории автомобиля");
            }
        }

    }
}
