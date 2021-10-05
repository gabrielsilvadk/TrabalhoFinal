using System;
namespace TrabalhoFinal.Models
{
    public class Categoria
    {
       public Categoria(int idcategoria, string nomecategoria, DateTime datacategoria, string tipo){
        if (nomecategoria == null)
                throw new System.Exception("");

            IdCategoria = idcategoria;
            NomeCategoria = nomecategoria;
            DataCategoria = datacategoria;
            Tipo = tipo;
       }
        public int IdCategoria { get; set; }

        public string NomeCategoria { get; set; }

        public DateTime DataCategoria { get; set; }

        public string Tipo { get; set; }

    }
    
   
    
}