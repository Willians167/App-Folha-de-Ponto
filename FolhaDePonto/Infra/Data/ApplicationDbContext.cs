using Microsoft.EntityFrameworkCore;
using FolhaDePonto.Models;

namespace FolhaDePonto.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
