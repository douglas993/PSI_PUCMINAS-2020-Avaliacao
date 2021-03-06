﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class QuestaoAvaliacaoConfiguration : IEntityTypeConfiguration<QuestaoAvaliacao>
    {
        public void Configure(EntityTypeBuilder<QuestaoAvaliacao> builder)
        {
            builder.Property(x => x.AvaliacaoId).IsRequired();
            builder.Property(x => x.AvaliacaoId).HasColumnType("int");
            builder.Property(x => x.Tipo).IsRequired();
            builder.Property(x => x.Tipo).HasColumnType("int");
            builder.Property(x => x.Enunciado).IsRequired();
            builder.Property(x => x.Enunciado).HasColumnType("varchar(255)");
            builder.HasOne(x => x.Avaliacao).WithMany(x => x.QuestoesAvaliacoes).HasForeignKey(x => x.AvaliacaoId);

            new EntityConfiguration();
        }
    }
}
