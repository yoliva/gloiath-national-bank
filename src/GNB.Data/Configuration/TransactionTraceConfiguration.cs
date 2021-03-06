﻿using GNB.Core.Traces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNB.Data.Configuration
{
    public class TransactionTraceConfiguration : IEntityTypeConfiguration<TransactionTrace>
    {
        public void Configure(EntityTypeBuilder<TransactionTrace> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Ignore(x => x.TableName);

            builder.Property(x => x.TransactionList).IsRequired();

            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.Property(x => x.LastUpdatedAt).HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
