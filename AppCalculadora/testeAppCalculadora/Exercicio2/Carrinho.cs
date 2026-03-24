using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.Exercicio2
{
    public class Carrinho
    {
        public class Item
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
        }

            private List<Item> itens = new();
            public void Adicionar(Item item)
            {
                itens.Add(item);
            }
            public double Total()
            {
                return itens.Sum(i => i.Preco);
            }
            public int Quantidade()
            {
                return itens.Count;
            }
            public void Limpar()
            {
                itens.Clear();
            }
        

    }
}
