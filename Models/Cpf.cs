using System;
using System.Text.RegularExpressions;

namespace TrabalhoFinal.Models
{
    public class Cpf
    {
        public Cpf(string valor)
        {
            Regex cpfConfirmation = new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}");
            if (!cpfConfirmation.IsMatch(valor))
            {
                throw new Exception($"Invalid CPF: {valor}.");
            }
            Valor = valor;
        }

        public string Valor { get; set; }
    }
}