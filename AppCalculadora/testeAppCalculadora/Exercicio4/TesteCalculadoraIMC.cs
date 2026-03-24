using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tests.Exercicio4
{
    public class TesteCalculadoraIMC
    {
        [Fact]
        public void Calcular_DeveRetornarValorCorreto()
        {
            var calc = new CalculadoraIMC();
            var imc = Math.Round(calc.Calcular(70, 1.75), 2);
            Assert.Equal(22.86, imc);
        }
        [Fact]
        public void Classificar_DeveRetornarAbaixodopeso()
        {
            var calc = new CalculadoraIMC();
            var resultado = calc.Classificar(17);
            Assert.Equal("Abaixo do peso", resultado);
        }
        [Fact]
        public void Classificar_DeveRetornarSobrepeso()
        {
            var calc = new CalculadoraIMC();
            var resultado = calc.Classificar(26);
            Assert.Equal("Sobrepeso", resultado);
        }
        [Fact]
        public void excessao_deveretornar_altura_invalida()
        {
            var calc = new CalculadoraIMC();
            Assert.Throws<ArgumentException>(() => calc.Calcular(70, 0));
        }

    }
}

