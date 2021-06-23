using System;
using System.Collections.Generic;

#nullable disable

namespace Repository
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
