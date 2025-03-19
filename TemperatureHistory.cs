using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class TemperatureHistory
    {
        private List<double> temperatures;

        public TemperatureHistory()
        {
            this.temperatures = new List<double>();
        }

        public void addTemperature(double temperature)
        {
            this.temperatures.Add(temperature);
        }

        public void removeTemperature(int index)
        {
            this.temperatures.RemoveAt(index);
        }

        public double averageTemperature()
        {
            double temperaturesSum = 0;

            this.temperatures.ForEach(temperature => temperaturesSum += temperature);

            return temperaturesSum / this.temperatures.Count;
        }
    }
}
