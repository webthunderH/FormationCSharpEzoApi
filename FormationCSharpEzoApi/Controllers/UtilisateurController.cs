using ApplicationCore.UtilisateurDomaine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormationCSharpEzoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateurService _utilisateurService;
       
        public UtilisateurController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _utilisateurService.GetUtilisateurs().ConvertAll(UtilisateurMapper.Map);
            var x = from a in result
                    where a.Id < 10
                    select a;
            var xx = result.Where(a => a.Id < 10);
            var toShow2 = _utilisateurService.GetUtilisateurs().Where(x => x.Id < 10);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get(string nom)
        {
            var result = _utilisateurService.GetUtilisateurs().ConvertAll(UtilisateurMapper.Map);
            var result2 = result.LastOrDefault(a => a.Nom == nom ); 
            var xx = result.Where(a => a.Id < 10);
            var toShow2 = _utilisateurService.GetUtilisateurs().Where(x => x.Id < 10);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(UtilisateurModel utilisateur)
        {
            if (ModelState.IsValid)
            {
              var result = _utilisateurService.CreateUtilisateur(UtilisateurMapper.Map(utilisateur));
              return Ok(result);
            }
            else
            {
                return BadRequest();
            }  
        }
    }
}
