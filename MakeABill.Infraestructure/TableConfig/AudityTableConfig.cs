using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MakeABill.Domain.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakeABill.Infraestructure.TableConfig
{
    internal class AudityTableConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : AuditableEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();
        }
    }
}
