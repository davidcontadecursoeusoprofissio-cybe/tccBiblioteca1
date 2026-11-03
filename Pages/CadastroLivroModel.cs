using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tccBiblioteca1.Data;
using tccBiblioteca1.Models;

namespace tccBiblioteca1.pages;

public class CadastroLivroModel(LivroRepositorio repositorio): PageModel
{
    public IActionResult OnPost(int id, string titulo, string? capaUrl)
    {
        var livro = new Livro
        {
            Id = id,
            Titulo = titulo,
            CapaUrl = capaUrl
        };
        repositorio.Adicionar(livro);
        return RedirectToPage("/Index");
    }
} 