using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model
{
    public class ClassCar
    {
        public ClassCar(string model, string category)
        {
            Model = model;
            Category = category;
            CarPassport = new ClassCarPassport(this);
        }
        public string Model { get; }
        public Color Color { get; set; } = Color.Blue;
        public string Category { get; }
        public ClassCarPassport CarPassport { get; }
        public string CarNumber { get; private set; }

        public void ChangeOwner(ClassDriver driver, string number)
        {
            CarPassport.Owner = driver;
            driver.OwnCar(this);
            CarNumber = number;
        }
    }
}
