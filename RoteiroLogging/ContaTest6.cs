using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoteiroLogging
{
    public class ContaTest6
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public decimal Saldo { get; private set; }
        public string Titular { get; private set; }

        public ContaTest6(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            logger.Info($"[DEPÓSITO] Início - Titular: {Titular}, Valor: {valor}");

            try
            {
                if (valor <= 0)
                    throw new ArgumentException("Valor inválido");

                Saldo += valor;

                logger.Info($"[DEPÓSITO] Sucesso - Novo saldo: {Saldo}");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"[DEPÓSITO] Erro - Valor: {valor}");
                throw;
            }
        }

        public void Sacar(decimal valor)
        {
            logger.Info($"[SAQUE] Início - Titular: {Titular}, Valor: {valor}");

            try
            {
                if (valor <= 0)
                    throw new ArgumentException("Valor inválido");

                if (Saldo < valor)
                    throw new Exception("Saldo insuficiente");

                Saldo -= valor;

                logger.Info($"[SAQUE] Sucesso - Novo saldo: {Saldo}");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"[SAQUE] Erro - Valor: {valor}");
                throw;
            }
        }

        public void Transferir(ContaTest6 destino, decimal valor)
        {
            logger.Info($"[TRANSFERÊNCIA] Início - De: {Titular} Para: {destino.Titular}, Valor: {valor}");

            try
            {
                if (destino == null)
                    throw new ArgumentNullException(nameof(destino));

                if (valor <= 0)
                    throw new ArgumentException("Valor inválido");

                this.Sacar(valor);
                destino.Depositar(valor);

                logger.Info($"[TRANSFERÊNCIA] Sucesso - Valor: {valor}");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"[TRANSFERÊNCIA] Erro - Valor: {valor}");
                throw;
            }
        }
    }
}
