
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.UtilisateurDomaine
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IRepositoryUtilisateur repositoryUtilisateur;
        private readonly IUnitOfWork unitOfWork;

        public UtilisateurService(IRepositoryUtilisateur repositoryUtilisateur, IUnitOfWork unitOfWork)
        {
            this.repositoryUtilisateur = repositoryUtilisateur;
            this.unitOfWork = unitOfWork;
        }

        public Utilisateur CreateUtilisateur(Utilisateur utilisateur)
        {
            repositoryUtilisateur.Insert(utilisateur);
            unitOfWork.SaveChange();
            return utilisateur;
        }

        public IEnumerable<Repository.Utilisateur> GetUtilisateurs()
        {     
            foreach(var x in repositoryUtilisateur.Get().Result)
            {
                yield return x;
            }           
        }
        private void Delete(Utilisateur utilisateur)
        {

        }

        public Delegate Action => new Action<Utilisateur>(Delete);
    }
}
