using ApplicationCore.UtilisateurDomain;
using ApplicationCore.UtilisateurDomaine;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore
{
    public static class ServiceCollection
    {
        public static void AddApplicationCore(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUtilisateurService, UtilisateurService>();

        }

        public static void AddFakeApplication(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUtilisateurService, FakeUtilisateurService>();
        }
    }
}
