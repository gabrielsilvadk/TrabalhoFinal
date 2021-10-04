using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Repositorios
{
    public class RepositorioCategorias
    {
        private int ultimoId = 0;
        private List<Categoria> bancoDeDados = new List<Categoria>();
        
        public int CadastrarCategoria(Categoria categoria)
        {
            var novoId = ++ultimoId;
            categoria.IdCategoria = novoId;
            bancoDeDados.Add(categoria);
            return novoId;
        }

        public Categoria BuscarPorIdCat(int id)
        {
            foreach (var categoria in bancoDeDados)
            {
                if (categoria.IdCategoria == id)
                    return categoria;
            }

            return null;
        }


        public List<Categoria> ListarCategoria(/*filtros, se houver*/)
        {
            return bancoDeDados.ToList();
        }

        public bool AtualizarCategoria(Categoria categoria)
        {
            for (int i = 0; i < bancoDeDados.Count; i++)
            {
                if (bancoDeDados[i].IdCategoria == categoria.IdCategoria)
                {
                    bancoDeDados[i] = categoria;
                    return true;
                }
            }

            return false;
        }

        public bool ExcluirCategoria(Categoria categoria)
        {
            for (int i = 0; i < bancoDeDados.Count; i++)
            {
                if (bancoDeDados[i].IdCategoria == categoria.IdCategoria)
                {
                    bancoDeDados.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
}