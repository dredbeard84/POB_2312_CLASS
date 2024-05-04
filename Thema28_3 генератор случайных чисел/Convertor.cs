using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thema28_3_генератор_случайных_чисел
{
    internal class Convertor
    {
        private double current;

        public Convertor(double current)
        {
            this.current = current;
        }
        public double toSM() => 0.1 * current;
        public double toDM() => 0.01 * current;
        public double toMetr() => 0.001 * current;
        public double toKM() => 0.0001 * current;
        public double toKelvin() => current + 273.15;
        public double toFarenheit() => current * 1.8 + 32;
        public double toMMHg() => current * 0.0075;
        public double toBAR() => current * 0.00001;
        public double toATM() => current * 0.00001;
    }
}
