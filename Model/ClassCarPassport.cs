using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClassCarPassport
    {
        public ClassCarPassport(ClassCar car)
        {
            Car = car;
        }
        public ClassDriver Owner { get; set; }
        public ClassCar Car { get; }
    }
}
