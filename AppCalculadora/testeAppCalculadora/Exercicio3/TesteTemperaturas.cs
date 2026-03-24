using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.Exercicio3
{
    public class TesteTemperaturas
    {
        [Fact]
        public void CelsiusParaFahrenheit_0_para_32()
        {
            var conversor = new ConversorTemperatura();
            var resultado = conversor.CelsiusParaFahrenheit(0);
            Assert.Equal(32, resultado);
        }
        [Fact]
        public void CelsiusParaFahrenheit_100_para_212()
        {
            var conversor = new ConversorTemperatura();
            var resultado = conversor.CelsiusParaFahrenheit(100);
            Assert.Equal(212, resultado);
        }
        [Fact]
        public void FahrenheitParaCelsius_32_para_0()
        {
            var conversor = new ConversorTemperatura();
            var resultado = conversor.FahrenheitParaCelsius(32);
            Assert.Equal(0, resultado);
        }
        [Fact]
        public void FahrenheitParaCelsius_212_para_100()
        {
            var conversor = new ConversorTemperatura();
            var resultado = conversor.FahrenheitParaCelsius(212);
            Assert.Equal(100, resultado);
        }
    }
}
