using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryUtilisateur : BaseRepository<Utilisateur>, IRepositoryUtilisateur
    {
        public RepositoryUtilisateur(FormationCEzoContext formationCEzoContext):base(formationCEzoContext)
        {

        }

        public Task<List<Utilisateur>> GetUtilisateursAndNote()
        {
            return DbSet.Include(e=>e.Notes).ThenInclude(e=>e.Utilisateur).ToListAsync();
        }
        public Task<List<Utilisateur>> GetUtilisateursAndNote(Expression<Func<Utilisateur, bool>> e)
        {
            
           return DbSet.Where(e).ToListAsync();
        }
    }
}
