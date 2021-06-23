using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.AuthentificationDomaine
{
    public class AuthentificationService : IAuthentificationService
    {
        public bool IsAdministrateur()
        {
            return true;
        }
    }
}
