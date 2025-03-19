using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Car
    {
        private string brand;
        private string model;
        private int productionYear;

        public Car(string brand, string model, int productionYear)
        {
            this.brand = brand;
            this.model = model;
            this.productionYear = productionYear;
        }

        public Car(string brand, string model) : this(brand, model, DateTime.Now.Year) 
        { 
        }
    }
}
