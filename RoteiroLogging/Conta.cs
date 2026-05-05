using NLog;
using System;


namespace RoteiroLogging
{
    public class Conta
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public decimal Saldo { get; private set; }

        public Conta(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            
            logger.Info($"Tentativa de saque: {valor}");

            if (valor <= 0)
                throw new ArgumentException("Valor deve ser positivo");

            if (Saldo < valor)
            {
                
                logger.Error($"Saldo insuficiente. Saldo atual: {Saldo}, Tentativa: {valor}");
                throw new Exception("Saldo insuficiente");
            }

            Saldo -= valor;

            logger.Info($"Saque realizado com sucesso. Novo saldo: {Saldo}");
        }
    }
}
