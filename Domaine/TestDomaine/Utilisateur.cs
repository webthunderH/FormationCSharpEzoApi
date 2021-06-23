using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.TestDomaine
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Note> Notes {get;set;}   
    }
}
