using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UtilisateurConfiguration : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {

            builder.ToTable("Utilisateur");

            builder.Property(e => e.Nom)
                .HasColumnName("NameOf")
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
