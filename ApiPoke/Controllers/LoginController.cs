using Microsoft.AspNetCore.Mvc;
using ApiPoke.Models;

namespace ApiPoke.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApiDbContext _context;
        public LoginController(ApiDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }

        private bool loginValidate([Bind("Correo,Contraseña")] Usuario usuario)
        {
            return usuario != null;

        }


        public Usuario registerUser([Bind("Nombre,Apellido,Correo,Contraseña")] Usuario usuario)
        {
            _context.Users.Add(usuario);

            return usuario;
        }
    }
}
