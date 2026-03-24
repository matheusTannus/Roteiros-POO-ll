using AppCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.Exercicios
{
    public class Exercicio_0
    {
        [Fact]
        public void Somar_DeveRetornar5()
        {
            var calc = new Calculadora();
            var resultado = calc.Somar(2, 3);
            //Assert.Equal(4, resultado);   errado
            Assert.Equal(5, resultado); // correto
        }

        [Fact]
        public void Dividir_DeveLancarExcecao()
        {
            var calc = new Calculadora();
            //Assert.Throws<DivideByZeroException>(() => calc.Dividir(10,2));   errado
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));    //certo
        }

        /*[fact]
        public void carrinho_deveestarvazio()
        {
            var carrinho = new carrinho();
            carrinho.adicionar(new item { nome = "produto", preco = 15 });   errado (nao deveria exitir)
            assert.empty(new list<item> { new item() });                     errado (nao deveria exitir)

            var carrinho = new carrinho();
            var itens = carrinho.itens();
            Assert.Empty(itens);    certo
        }*/

        /*[Fact]
        public void Classificar_DeveRetornarPesoNormal()
        {
            var calc = new CalculadoraIMC();
            var resultado = calc.Classificar(31);    errado
            
            var calc = new CalculadoraIMC();
            var resultado = calc.Classificar(22);  
            Assert.Equal("Peso normal", resultado);
        }*/


    }
}
