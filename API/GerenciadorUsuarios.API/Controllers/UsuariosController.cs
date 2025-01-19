using GerenciadorUsuarios.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorUsuarios.API.Controllers;

[Route("/api/usuarios")]
public class UsuariosController : ControllerBase
{
    private readonly static List<Usuario> _usuarios = new()
    {
        new Usuario()
        {
            Id = Guid.NewGuid(),
            Nome = "Usuario 01",
            Email = "usuario01@gmail.com"
        }
    };

    [HttpGet]
    public IActionResult BuscarUsuarios()
    {
        return Ok(_usuarios);
    }

    // [HttpGet("id:guid")]
}
