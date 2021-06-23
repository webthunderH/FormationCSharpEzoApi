using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ServiceCollection
    {
        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<FormationCEzoContext>(option=>option.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=FormationC#Ezo;Trusted_Connection=True;"));
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IRepositoryUtilisateur, RepositoryUtilisateur>();
        }
    }
}
