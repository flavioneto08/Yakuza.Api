using Microsoft.EntityFrameworkCore;
using Yakuza.Api.Models;

namespace Yakuza.Api.Data
{
    public class YakuzaDbContext:DbContext
    {
        public YakuzaDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        {
        
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
