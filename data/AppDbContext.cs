
using Microsoft.EntityFrameworkCore;
using mvpStudy.model;

namespace mvpStudy.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Materia> MateriasCadastrada { get; set; }
    }
}