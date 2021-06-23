using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormationCSharpEzoApi
{
    public static class UtilisateurMapper
    {
        public static UtilisateurModel Map(Utilisateur utilisateur)
        {
            return new UtilisateurModel()
            {
                Id= utilisateur.Id,
                Nom = utilisateur.Nom
            };
        }

        public static Utilisateur Map(UtilisateurModel utilisateur)
        {
            return new Utilisateur()
            {
                Id = utilisateur.Id,
                Nom = utilisateur.Nom
            };
        }
    }
}
