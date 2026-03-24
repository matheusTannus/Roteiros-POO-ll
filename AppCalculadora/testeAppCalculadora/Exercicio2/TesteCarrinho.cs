using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tests.Exercicio2.Carrinho;

namespace tests.Exercicio2
{
    public class TesteCarrinho
    {
        [Fact]
        public void AdicionarItens_DeveSomarTotalCorretamente()
        {
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "Produto 1", Preco = 10 });
            carrinho.Adicionar(new Item { Nome = "Produto 2", Preco = 20 });

            var total = carrinho.Total();
            Assert.Equal(30, total);
        }

        [Fact]
        public void Limpar_DeveZerarCarrinho()
        {
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "Produto", Preco = 10 });

            carrinho.Limpar();
            Assert.Equal(0, carrinho.Quantidade());
            Assert.Equal(0, carrinho.Total());
        }

        [Fact]
        public void Quantidade_DeveRetornarNumeroCorretoDeItens()
        {
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "Produto 1", Preco = 5 });
            carrinho.Adicionar(new Item { Nome = "Produto 2", Preco = 15 });
            carrinho.Adicionar(new Item { Nome = "Produto 3", Preco = 25 });

            var quantidade = carrinho.Quantidade();
            Assert.Equal(3, quantidade);
        }
    }
}
