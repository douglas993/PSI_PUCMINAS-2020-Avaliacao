using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class QuestaoProvaConfiguration : IEntityTypeConfiguration<QuestaoProva>
    {
        public void Configure(EntityTypeBuilder<QuestaoProva> builder)
        {
            builder.Property(x => x.QuestaoAvaliacaoId).IsRequired();
            builder.Property(x => x.QuestaoAvaliacaoId).HasColumnType("int");
            builder.Property(x => x.ProvaId).IsRequired();
            builder.Property(x => x.ProvaId).HasColumnType("int");
            builder.HasOne(x => x.QuestaoAvaliacao).WithMany(x => x.QuestoesProvas).HasForeignKey(x => x.QuestaoAvaliacaoId);
            builder.HasOne(x => x.Prova).WithMany(x => x.QuestoesProvas).HasForeignKey(x => x.ProvaId);

            new EntityConfiguration();
        }
    }
}
