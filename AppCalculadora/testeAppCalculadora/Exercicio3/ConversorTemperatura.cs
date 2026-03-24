using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.Exercicio3
{
    public class ConversorTemperatura
    {
        public double CelsiusParaFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        public double FahrenheitParaCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

    }
}
