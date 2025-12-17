
using Microsoft.AspNetCore.Mvc;
using ProvaP3.Application.Interfaces;
using ProvaP3.Dominio.Entidades;

namespace ProvaP3.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : Controller
    {
        private readonly IJogoService _service;

        public JogoController(IJogoService service)
        {
            _service = service;
        }

        [HttpPost("api/jogo/registrar")]
        public IActionResult Registrar(int valor1, int valor2, int valor3, int valor4, int valor5, int valor6)
        {
            var jogo = new Jogo(valor1, valor2, valor3, valor4, valor5, valor6);
            _service.Registrar(jogo);
            return Ok("Jogo registrado com sucesso");
        }

        [HttpGet("api/jogo/listar")]
        public IActionResult ListarTodos()
        {
            return Ok(_service.ObterTodos());
        }
    }
}
