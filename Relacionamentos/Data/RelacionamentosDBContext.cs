using Microsoft.EntityFrameworkCore;
using Relacionamentos.Models;

namespace Relacionamentos.Data
{
    public class RelacionamentosDBContext : DbContext
    {
        public RelacionamentosDBContext(DbContextOptions<RelacionamentosDBContext> options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


    }
}
