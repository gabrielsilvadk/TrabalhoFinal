using System.Collections.Generic;
using TrabalhoFinal.Models;
using TrabalhoFinal.Repositorios;

namespace TrabalhoFinal.Processos
{
    public class ProcessosPessoas
    {
        private readonly RepositorioPessoas repositorioPessoas;

        public ProcessosPessoas(RepositorioPessoas repositorioPessoas)
        {
            this.repositorioPessoas = repositorioPessoas;
        }

        public ResultadoLogin Login(Email email, string senha)
        {
            // Consultar o banco de dados
            // Ver se encontra uma pessoa com o email e senha indicados
            // Retorna um resultado login

            var pessoaComEmail = repositorioPessoas.BuscarPorEmail(email);
            if (pessoaComEmail.Senha == senha)
            {
                return new ResultadoLogin(true, pessoaComEmail);
            }

            // SOLID
            // Single Responsibility - fazer uma coisa bem feita, limitar o impacto das mudanças
            // Open Closed
            // Liskov Substitution Principle
            // Interface Segregation
            // Dependency Inversion

            return new ResultadoLogin(false, null);
        }

        public Pessoa Cadastrar(string nome, Email email, Cpf cpf, string senha)
        {
            var pessoa = new Pessoa(0, nome, email, cpf, senha);

            int id = repositorioPessoas.Cadastrar(pessoa);
            pessoa.Id = id;

            return pessoa;
        }

        public List<Pessoa> Listar(Email filtroEmail = null, string filtroNome = null)
        {
            // Recuperar o id ao cadastro no banco de dados
            // Setar o id na classe
            // pessoa.id = resultadoDoBancoDeDados;

            return new List<Pessoa>();
        }
    }

    public class ResultadoLogin
    {
        public ResultadoLogin(bool sucesso, Pessoa pessoaCasoSucesso)
        {
            Sucesso = sucesso;
            PessoaCasoSucesso = pessoaCasoSucesso;
        }

        public bool Sucesso { get; }
        public Pessoa PessoaCasoSucesso { get; }
    }
}