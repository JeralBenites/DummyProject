using DummyProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace DummyProject.Infraestructure
{
    public class BDContext : DbContext
    {
        public DbSet<Dummy> Dummy { get; set; }
        public BDContext(DbContextOptions<BDContext> options) : base(options)
        {
        }
    }
}
