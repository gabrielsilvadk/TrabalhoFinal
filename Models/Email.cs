using System;
using System.Text.RegularExpressions;

namespace TrabalhoFinal.Models
{
    public class Email
    {
        public Email(string valorEmail)
        {
            Regex emailPattern = new Regex(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;,.]{0,1}\s*)+$");
            if (!emailPattern.IsMatch(valorEmail))
            {
                throw new Exception($"Invalid Email: {valorEmail}.");
            }
            Valor = valorEmail;
        }

        public string Valor { get; set; }
    }
}