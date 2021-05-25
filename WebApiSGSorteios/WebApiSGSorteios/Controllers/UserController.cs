using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebApiSGSorteios.Dtos;
using Domain.Models;
using WebApiSGSorteios.Services;

namespace WebApiSGSorteios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;

        public UserController(IConfiguration pConfig)
        {
            _config = pConfig;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginDto pUserLogin)
        {
            try
            {
                /*
                 * TODO: adicionar comparação de senha
                 */
                var user = new User
                {
                    Id = 1,
                    Username = pUserLogin.Username,
                    Password = pUserLogin.Password,
                    Role = "employer"
                };

                if (user == null)
                    return NotFound(new { message = "Usuário ou senha inválidos" });

                var token = TokenService.GenerateToken(_config, user);
                user.Password = string.Empty;

                return Ok(new
                {
                    user = user,
                    token = token
                });

            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco Dados Falhou {ex.Message}");
            }
        }

        [HttpGet("authenticated")]
        [Authorize]
        public string Authenticated()
        {
            return string.Format("Autenticado - {0}", User.Identity.Name);
        }
    }
}
