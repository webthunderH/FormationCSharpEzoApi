using System;
using System.Collections.Generic;

#nullable disable

namespace Repository
{
    public partial class Note
    {
        public int Id { get; set; }
        public string NoteTableau { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
    }
}
