using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>()
        {
            new Produto { Nome = "Teclado", Preco = 120.50 },
            new Produto { Nome = "Mouse", Preco = 60.90 },
            new Produto { Nome = "Monitor", Preco = 850.00 }
        };

        XmlSerializer serializer = new XmlSerializer(typeof(List<Produto>));

        using (FileStream fs = new FileStream("produtos.xml", FileMode.Create))
        {
            serializer.Serialize(fs, produtos);
        }

        string conteudo = File.ReadAllText("produtos.xml");
        Console.WriteLine(conteudo);
    }
}
