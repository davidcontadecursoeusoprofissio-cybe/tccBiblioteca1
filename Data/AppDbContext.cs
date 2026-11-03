using Microsoft.EntityFrameworkCore;
using tccBiblioteca1.Models;

namespace tccBiblioteca1.Data
{


public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
    }
     public DbSet<Livro> Livros { get; set; }
  }
}
