using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;

public class Food
{
    public string Name { get; set; }
    public string Price { get; set; }
}

class Program
{
    static async Task Main()
    {
        string url = "https://www.w3schools.com/xml/simple.xml";

        HttpClient client = new HttpClient();

        var conteudourl = await client.GetStringAsync(url);

        var documento = XDocument.Parse(conteudourl);

        var foods = documento.Descendants("food");

        foreach (var food in foods)
        {
            string nome = food.Element("name").Value;
            string preco = food.Element("price").Value;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine();
        }
    }
}