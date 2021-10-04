namespace TrabalhoFinal.Models
{
    public class Categoria
    {
       public Categoria(int idcategoria, string nomecategoria, string datacategoria){
        if (nomecategoria == null)
                throw new System.Exception("");

            IdCategoria = idcategoria;
            NomeCategoria = nomecategoria;
            DataCategoria = datacategoria;
       }
        public int IdCategoria { get; set; }

        public string NomeCategoria { get; set; }

        public string DataCategoria { get; set; }
    }
}