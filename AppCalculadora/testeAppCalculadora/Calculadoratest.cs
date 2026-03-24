using Xunit;
using AppCalculadora;
using System;


namespace testeAppCalculadora
{
    public class Calculadoratest
    {
        
            // --- TESTE SOMAR ---
            [Theory]
            [InlineData(2, 3, 5)]
            [InlineData(10, 5, 15)]
            [InlineData(0, 0, 0)]
            [InlineData(-2, 5, 3)]
            [InlineData(-4, -6, -10)]
            public void Somar_DeveRetornarResultadoCorreto(int a, int b, int esperado)
            {
                // Arrange
                var calc = new Calculadora();
                // Act
                var resultado = calc.Somar(a, b);
                // Assert
                Assert.Equal(esperado, resultado);
            }
            // --- TESTE SUBTRAIR ---
            [Theory]
            [InlineData(10, 5, 5)]
            [InlineData(5, 10, -5)]
            [InlineData(0, 0, 0)]
            [InlineData(-3, -7, 4)]
            public void Subtrair_DeveRetornarResultadoCorreto(int a, int b, int esperado)
            {
                var calc = new Calculadora();
                var resultado = calc.Subtrair(a, b);
                Assert.Equal(esperado, resultado);
            }
            // --- TESTE MULTIPLICAR ---
            [Theory]
            [InlineData(2, 3, 6)]
            [InlineData(10, 0, 0)]
            [InlineData(-2, 5, -10)]
            [InlineData(-3, -3, 9)]
            public void Multiplicar_DeveRetornarResultadoCorreto(int a, int b, int esperado)
            {
                var calc = new Calculadora();
                var resultado = calc.Multiplicar(a, b);
                Assert.Equal(esperado, resultado);
            }
            // --- TESTE DIVIDIR (RESULTADO NORMAL) ---
            [Theory]
            [InlineData(10, 2, 5)]
            [InlineData(9, 3, 3)]
            [InlineData(5, 2, 2.5)]
            [InlineData(-10, 2, -5)]
            public void Dividir_DeveRetornarResultadoCorreto(int a, int b, double esperado)
            {
                var calc = new Calculadora();
                var resultado = calc.Dividir(a, b);
                Assert.Equal(esperado, resultado, 1); // tolerância de 1 casa decimal
            }
            // --- TESTE DIVIDIR (EXCEÇÃO) ---
            [Theory]
            [InlineData(10, 0)]
            [InlineData(-5, 0)]
            [InlineData(0, 0)]
            public void Dividir_DeveLancarExcecao_QuandoDivisorForZero(int a, int b)
            {
                var calc = new Calculadora();
                Assert.Throws<DivideByZeroException>(() => calc.Dividir(a, b));
            }
        
    }
}
    
