using Microsoft.AspNetCore.Mvc;
using vendas.Models;

namespace vendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        [HttpPost(Name = "CadastrarUsuario")]
        public void CadastrarUsuario(Usuario usuario)
        {

        }
    }
}
