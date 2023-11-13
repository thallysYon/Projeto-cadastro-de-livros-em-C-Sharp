namespace Cadastro_de_Livros.Models
{
    public class Revista : ItemCatalogo
    {
        public string Editora { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Editora da revista: {Editora}";
        }
    }
}
