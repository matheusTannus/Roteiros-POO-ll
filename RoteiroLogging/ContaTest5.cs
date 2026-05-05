using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoteiroLogging
{
    public class ContaTest5
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public decimal Saldo { get; private set; }

        public ContaTest5(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            logger.Info($"Tentativa de saque: {valor}");

            //tentativa invalida
            if (valor <= 0)
            {
                logger.Warn($"Tentativa de saque com valor inválido: {valor}");
                throw new ArgumentException("Valor deve ser positivo");
            }

            //erro (exceção)
            if (Saldo < valor)
            {
                logger.Error($"Saldo insuficiente. Saldo: {Saldo}, Tentativa: {valor}");
                throw new Exception("Saldo insuficiente");
            }

            //operação normal
            Saldo -= valor;
            logger.Info($"Saque realizado com sucesso. Novo saldo: {Saldo}");
        }
    }
}
