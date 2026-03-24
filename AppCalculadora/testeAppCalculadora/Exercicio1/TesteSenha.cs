using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tests.Exercicio1;
using Xunit;


namespace tests.Exercicio1
{
    public class TesteSenha
    {
        [Fact]
        public void Senha123_DeveSerValida()
        {
            string senha = "Senha123";
            bool resultado = ValidadorSenha.EhValida(senha);
            Assert.True(resultado);
        }

        [Fact]
        public void SenhaCurta_DeveSerInvalida()
        {
            string senha = "12345678";
            bool resultado = ValidadorSenha.EhValida(senha);
            Assert.False(resultado);
        }

        [Fact]
        public void Senhavazia_DeveSerInvalida()
        {
            string senha = "";
            bool resultado = ValidadorSenha.EhValida(senha);
            Assert.False(resultado);
        }

        [Fact]
        public void SenhaSemNumero_DeveSerInvalida()
        {
            string senha = "abcdEFGH";
            bool resultado = ValidadorSenha.EhValida(senha);
            Assert.False(resultado);
        }
    }
}