namespace TrabalhoFinal.Models
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, Email email, Cpf cpf, string senha)
        {
            if (nome == "")
                throw new System.Exception("Nome não pode estar em branco");

            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Senha = senha;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public Email Email { get; set; }

        public Cpf Cpf { get; set; }

        public string Senha { get; set; }
    }
}