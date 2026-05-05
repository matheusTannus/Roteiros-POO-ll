using NLog;
using RoteiroLogging;

class Program
{
    private static readonly Logger logger =
    LogManager.GetCurrentClassLogger();
    static void Main()
    {
        logger.Trace("Detalhe técnico");
        logger.Debug("Valor de variável X");
        logger.Info("Usuário logado");          //1
        logger.Warn("Tentativa inválida");
        logger.Error("Erro ao salvar dados");
        logger.Fatal("Falha crítica no sistema");


        logger.Info("Programa iniciado");
        try
        {
            Console.WriteLine("insira um número para somer com outro logo em seguida: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("insira outro número: ");
            double n2 = double.Parse(Console.ReadLine());
            double resultado = n1 + n2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
        }
        catch (Exception ex)                        //2
        {
            logger.Error(ex, "Erro durante execução");
        }
        finally
        {
            logger.Info("Programa finalizado");
        }



        Console.Write("Digite um número: ");
        string entrada = Console.ReadLine();
        try
        {
            int numero = int.Parse(entrada);
            Console.WriteLine("Número convertido: " + numero);      //3
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Erro: valor inválido!");
            logger.Error(ex, $"Falha ao converter '{entrada}' para inteiro");
        }


        Conta conta = new Conta(100);
        try
        {
            Console.WriteLine("Tentando sacar 50...");
            conta.Sacar(50);

            Console.WriteLine("Tentando sacar 100...");
            conta.Sacar(100); 
        }                                                   //4
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        Console.WriteLine("Programa finalizado.");


        ContaTest5 conta1 = new ContaTest5(100);

        try
        {
            conta1.Sacar(50);   // normal (info)
            conta1.Sacar(0);    // invalido (warn)      //5
            conta1.Sacar(200);  // erro (error)
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }



        ContaTest6 conta3 = new ContaTest6("Matheus", 1000);
        ContaTest6 conta4 = new ContaTest6("Maria", 500);

        try
        {
            conta3.Depositar(200);                      //6
            conta3.Sacar(300);
            conta3.Transferir(conta4, 400);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        Console.WriteLine("Fim do programa");
    }
}


