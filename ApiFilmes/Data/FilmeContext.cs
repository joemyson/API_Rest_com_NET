using ApiFilmes.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiFilmes.Data
{
    public class FilmeContext : DbContext 
    {

        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }

        public DbSet<Filme> Filmes { get;set; }
    }
}
