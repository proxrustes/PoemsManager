using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ModelsObject;

namespace WpfApp1.Context
{
    internal class ApplicationDBcontext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Poem> Poems { get; set; }
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBcontext).Assembly);
            base.OnModelCreating(builder);

        }

    }
}
