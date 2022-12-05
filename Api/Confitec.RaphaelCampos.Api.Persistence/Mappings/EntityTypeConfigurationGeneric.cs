using Confitec.RaphaelCampos.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Confitec.RaphaelCampos.Api.Persistence.Mappings
{
    public abstract class EntityTypeConfigurationGeneric<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        protected abstract string TableName { get; }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.PropertyType == typeof(string))
                {
                    builder.Property(prop.PropertyType, prop.Name).HasMaxLength(70);
                }
            }

            builder
                .ToTable(TableName)
                .HasKey(x => x.Id);
        }
    }
}
