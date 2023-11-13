namespace Cadastro_de_Livros.Models
{
    public class Livro : ItemCatalogo
    {
        public string Autor { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Autor(a) do livro: {Autor}";
        }
    }
}
