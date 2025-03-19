using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum OperatingSystem
{
    iOS,
    Android,
}

namespace homework_1
{
    internal class Phone
    {
        private string manufacturer;
        private string model;
        private OperatingSystem operatingSystem = OperatingSystem.Android;

        public Phone(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.operatingSystem = OperatingSystem.iOS;
        }
    }
}
