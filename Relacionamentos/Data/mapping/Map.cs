using Relacionamentos.Models;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace Relacionamentos.Data.mapping
{
    public static class Map
    {
        public static void OnModelCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Posts)
                .WithOne(e => e.Blog)
                .HasForeignKey(e => e.BlogId)
                .HasPrincipalKey(e => e.Id);
        }
    }
}
