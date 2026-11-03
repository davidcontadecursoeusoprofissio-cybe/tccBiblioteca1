
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tccBiblioteca1.Data;
using tccBiblioteca1.Models;

namespace tccBiblioteca1.Pages;

public class IndexModel : PageModel
{
    private readonly LivroRepositorio inserir;

    public List<Livro> imagem { get; set; } = new();

    public IndexModel(LivroRepositorio inserir2)
    {
        inserir = inserir2;
    }

    public void OnGet()
    {
        imagem = inserir.PuxarLivros();
    }

    public IActionResult OnPost(int id)
    {
        inserir.Deletar(id);
        return RedirectToPage("/Index");
    }
}
