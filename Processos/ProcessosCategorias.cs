using TrabalhoFinal.Models;
using TrabalhoFinal.Repositorios;
using System.Collections.Generic;
using System;

namespace TrabalhoFinal
{
    public class ProcessosCategorias
    {
        private readonly RepositorioCategorias repositorioCategorias;

        public ProcessosCategorias(RepositorioCategorias repositorioCategorias)
        {
            this.repositorioCategorias = repositorioCategorias;
        }


        public Categoria CadastrarCategoria(int idcat, string nomecat, DateTime datacat, string tipocat)
        {
            var categoria = new Categoria(0, nomecat, datacat, tipocat);

            int id = repositorioCategorias.CadastrarCategoria(categoria);
            categoria.IdCategoria = id;

            return categoria;
        }

        public List<Categoria> Listar(string nomeCategoria = null)
        {
            // Recuperar o id ao cadastro no banco de dados
            // Setar o id na classe
            // pessoa.id = resultadoDoBancoDeDados;

            return new List<Categoria>();
        }
    }














}