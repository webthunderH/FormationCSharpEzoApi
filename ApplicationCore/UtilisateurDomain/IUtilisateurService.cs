using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.UtilisateurDomaine
{
    public interface IUtilisateurService
    {
        List<Utilisateur> GetUtilisateurs();
        Utilisateur CreateUtilisateur(Utilisateur utilisateur);
    }
}
