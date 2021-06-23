using ApplicationCore.UtilisateurDomaine;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.UtilisateurDomain
{
    public class FakeUtilisateurService : IUtilisateurService
    {
        public Utilisateur CreateUtilisateur()
        {
            throw new NotImplementedException();
        }

        public Utilisateur CreateUtilisateur(Utilisateur utilisateur)
        {
            throw new NotImplementedException();
        }

        public List<Utilisateur> GetUtilisateurs()
        {
            throw new NotImplementedException();
        }
    }
}
