using ChapterBET6.Models;
using ChapterBET6.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterBET6.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;


        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Livro livroBuscado = _livroRepository.BuscarPorId(id);

              if (livroBuscado == null)
              {
                    return NotFound();

              }

                return Ok(livroBuscado);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Livro nomeL)
        {
            try
            {
                _livroRepository.Cadastrar(nomeL);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);

                return Ok("livro removido com sucesso");
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Livro nomel)
        {
            try
            {
                _livroRepository.Alterar(id, nomel);

                return StatusCode(204);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
