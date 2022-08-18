using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Braspag.Model
{
    public class BrasPagContext : DbContext
    {
        public BrasPagContext( DbContextOptions<BrasPagContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PessoaModel> pessoas { get; set; }

        
    }
}
