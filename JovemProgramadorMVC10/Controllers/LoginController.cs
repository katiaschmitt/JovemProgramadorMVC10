using JovemProgramadorMVC10.Data.Repositorio.Interfaces;
using JovemProgramadorMVC10.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC10.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                var retorno = _usuarioRepositorio.ValidarUsuario(usuario);

                if (retorno != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MsgErro"] = "Usuário ou senha incorretos! Tente novamente...";
                }
            }
            catch (Exception)
            {

                TempData["MsgErro"] = "Erro ao buscar dados do usuário";
            }

            return View("Index");

        }
    }
}
