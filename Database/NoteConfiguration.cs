using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> modelBuilder)
        {

            modelBuilder.ToTable("Note");

            modelBuilder.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("FK__Note__Utilisateu__267ABA7A");
            
        }
    }
}
