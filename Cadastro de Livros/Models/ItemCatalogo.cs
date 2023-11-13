namespace Cadastro_de_Livros.Models
{
    // Classe abstrata
    public abstract class ItemCatalogo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public abstract string ExibirDetalhes();
    }

}
