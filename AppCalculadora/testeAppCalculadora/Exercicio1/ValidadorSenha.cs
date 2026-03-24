using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tests.Exercicio1
{
    public class ValidadorSenha
    {
            public static bool EhValida(string senha)
            {
                if (string.IsNullOrEmpty(senha)) return false;
                if (senha.Length < 8) return false;
                bool contemLetra = Regex.IsMatch(senha, "[A-Za-z]");
                bool contemNumero = Regex.IsMatch(senha, "[0-9]");
                return contemLetra && contemNumero;
            }
        
    }
}

