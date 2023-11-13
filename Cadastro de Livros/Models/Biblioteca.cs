namespace Cadastro_de_Livros.Models
{
    public class Biblioteca
    {
        private List<ItemCatalogo> catalogo = new List<ItemCatalogo>();

        public void AdicionarItem(ItemCatalogo item)
        {
            catalogo.Add(item);
        }

        public List<ItemCatalogo> ObterCatalogo()
        {
            return catalogo;
        }
    }

}
