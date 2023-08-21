using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NaviresController : ControllerBase
    {

        private readonly INavireRepository _navireRepository;

        public NaviresController(INavireRepository navireRepository)
        {
            _navireRepository = navireRepository;
        }

        // GET: api/navires
        [HttpGet]
        public IEnumerable<Navire> GetAllNavires()
        {
            return _navireRepository.GetAllNavires();
        }

        // GET: api/navires/5
        [HttpGet("{numero}")]
        public ActionResult<Navire> GetNavireById(int numero)
        {
            Navire navire = _navireRepository.GetNavireByNumero(numero);
            if (navire == null)
            {
                return NotFound();
            }
            return navire;
        }

        // POST: api/navires
        [HttpPost]
        public ActionResult<Navire> AddNavire(Navire navire)
        {
            _navireRepository.AddNavire(navire);
            return CreatedAtAction(nameof(GetNavireById), new { id = navire.Numero }, navire);
        }

        // PUT: api/navires/5
        [HttpPut("{numero}")]
        public IActionResult UpdateNavire(int numero, Navire navire)
        {
            if (numero != navire.Numero)
            {
                return BadRequest();
            }

            _navireRepository.UpdateNavire(navire);
            return NoContent();
        }

        // DELETE: api/navires/5
        [HttpDelete("{numero}")]
        public IActionResult DeleteNavire(int numero)
        {
            Navire navire = _navireRepository.GetNavireByNumero(numero);
            if (navire == null)
            {
                return NotFound();
            }

            _navireRepository.DeleteNavire(numero);
            return NoContent();
        }
    }
}
