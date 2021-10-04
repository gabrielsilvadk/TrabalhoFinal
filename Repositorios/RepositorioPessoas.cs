using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Repositorios
{
    public class RepositorioPessoas
    {
        private int ultimoId = 0;
        private List<Pessoa> bancoDeDados = new List<Pessoa>();
        
        public int Cadastrar(Pessoa pessoa)
        {
            var novoId = ++ultimoId;
            pessoa.Id = novoId;
            bancoDeDados.Add(pessoa);
            return novoId;
        }

        public Pessoa BuscarPorId(int id)
        {
            foreach (var pessoa in bancoDeDados)
            {
                if (pessoa.Id == id)
                    return pessoa;
            }

            return null;
        }

        public Pessoa BuscarPorEmail(Email email)
        {
            foreach (var pessoa in bancoDeDados)
            {
                if (pessoa.Email.Valor == email.Valor)
                    return pessoa;
            }

            return null;
        }

        public List<Pessoa> Listar(/*filtros, se houver*/)
        {
            return bancoDeDados.ToList();
        }

        public bool Atualizar(Pessoa pessoa)
        {
            for (int i = 0; i < bancoDeDados.Count; i++)
            {
                if (bancoDeDados[i].Id == pessoa.Id)
                {
                    bancoDeDados[i] = pessoa;
                    return true;
                }
            }

            return false;
        }

        public bool Excluir(Pessoa pessoa)
        {
            for (int i = 0; i < bancoDeDados.Count; i++)
            {
                if (bancoDeDados[i].Id == pessoa.Id)
                {
                    bancoDeDados.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
}