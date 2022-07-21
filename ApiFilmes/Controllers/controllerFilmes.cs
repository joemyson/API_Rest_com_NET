using ApiFilmes.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace ApiFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class controllerFilmes : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;


        [HttpPost]
        public IActionResult adicionarFilme([FromBody] Filme filme)
        {

            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaId), new { Id = filme.Id}, filme);



        }
        [HttpGet]
        public IActionResult recuperaFilmes()
        {

            return Ok(filmes);
        }


        [HttpGet("{id}")]
        public IActionResult RecuperaId( int id)
        {
         Filme filme = filmes.FirstOrDefault(filme =>filme.Id == id);
            if(filme != null)
            {

                return Ok(filme);
            }
            return NotFound();

        }
    }
}
