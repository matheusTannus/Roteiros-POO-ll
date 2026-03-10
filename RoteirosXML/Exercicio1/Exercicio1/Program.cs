using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument doc = XDocument.Load("alunos.xml");

        var alunos = doc.Descendants("aluno");

        foreach (var aluno in alunos)
        {
            string nome = aluno.Element("nome").Value;
            string curso = aluno.Element("curso").Value;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine();
        }
    }
}