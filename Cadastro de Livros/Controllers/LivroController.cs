using Cadastro_de_Livros.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class LivroController : Controller
{
    //Biblioteca é onde está a nossa lista (List<>)
    private static Biblioteca biblioteca = new Biblioteca();

    public IActionResult Index()
    {
        var catalogo = biblioteca.ObterCatalogo();
        return View(catalogo);
    }

    public IActionResult ItensCadastrados()
    {
        var catalogo = biblioteca.ObterCatalogo();
        return PartialView("ItensCadastrados", catalogo);
    }

    [HttpPost]
    public IActionResult Cadastrar(string tipoItem, string titulo, string autorEditora)
    {
            ItemCatalogo novoItem;

            if (tipoItem == "Livro")
            {
                novoItem = new Livro { Titulo = titulo, Autor = autorEditora };
            }
            else if (tipoItem == "Revista")
            {
                novoItem = new Revista { Titulo = titulo, Editora = autorEditora };
            }
            else
            {
                throw new InvalidOperationException("Tipo de item inválido.");
            }

            biblioteca.AdicionarItem(novoItem);

            //Redireciona de volta para a página inicial após o cadastro
            return RedirectToAction("Index");
    }

}
