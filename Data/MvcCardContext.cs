using Microsoft.EntityFrameworkCore;
using MvcCard.Models;

namespace MvcCard.Data
{
    public class MvcCardContext : DbContext
    {
        public MvcCardContext(DbContextOptions<MvcCardContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Card { get; set; }
    }
}