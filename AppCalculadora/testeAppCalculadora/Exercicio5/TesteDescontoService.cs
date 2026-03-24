using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.Exercicio5
{
    public class TesteDescontoService
    {
        [Fact]
        public void AplicarDesconto_DeveRetornarValor90()
        {
            var service = new DescontoService();
            var resultado = service.AplicarDesconto(100, 10);
            Assert.Equal(90, resultado);
        }

        [Fact]
        public void AplicarDesconto_DeveRetornarValor100()
        {
            var service = new DescontoService();
            var resultado = service.AplicarDesconto(200, 50);
            Assert.Equal(100, resultado);
        }

        [Fact]
        public void AplicarDesconto_DeveRetornarValor80()
        {
            var service = new DescontoService();
            var resultado = service.AplicarDesconto(80, 0);
            Assert.Equal(80, resultado);
        }

        [Fact]
        public void AplicarDesconto_ValorNegativo_DeveLancarExcecao()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(-100, 10));
        }

        [Fact]
        public void AplicarDesconto_Percentual_menor_que_0_DeveLancarExcecao()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, -10));
            
        }

        [Fact]
        public void AplicarDesconto_Percentual_maior_que_100_DeveLancarExcecao()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, 150));
        }

        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(200, 50, 100)]
        [InlineData(80, 0, 80)]
        public void AplicarDesconto_ValoresValidos_DeveRetornarValorCorreto(double valor, double percentual, double esperado)
        {
            var service = new DescontoService();
            var resultado = service.AplicarDesconto(valor, percentual);
            Assert.Equal(esperado, resultado);
        }
    }
}
