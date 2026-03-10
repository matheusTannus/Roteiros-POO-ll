## BibliotecaMultiplicacao
Uma biblioteca simples em .NET para cálculo de dois numeros.

## Como usar
Para utilizar esta DLL no seu projeto, siga os passos abaixo:

1. Adicionar a Referência
Primeiro, você precisa adicionar o arquivo BibliotecaMultiplicacao.dll às referências do seu projeto:

No Visual Studio: Clique com o botão direito em Dependencies > Add Project Reference > Browse e selecione a DLL.

2. Espaço de Nomes (Namespace)
Adicione a diretiva using no topo do seu arquivo de código

```

using BibliotecaMultiplicacao;

var conversao = new Conversao();

Console.Write("\nInsira o valor para conversão de moeda: ");

float valor = float.Parse(Console.ReadLine());

Console.Write("Insira a taxa de câmbio ex: (0,05 para 5%) : ");

float taxa = float.Parse(Console.ReadLine());

Console.WriteLine("Valor convertido: " + conversao.Moeda(valor, taxa));
