using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument doc = XDocument.Load("estoque.xml");

        var itemMouse = doc.Descendants("item")
                           .FirstOrDefault(i => i.Element("nome").Value == "Mouse");

        if (itemMouse != null)
        {
            itemMouse.Element("quantidade").Value = "10";
        }

        doc.Save("estoque.xml");

        Console.WriteLine("Quantidade atualizada com sucesso!");
    }
}