using Confitec.RaphaelCampos.Api.Persistence.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Confitec.RaphaelCampos.Api.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
