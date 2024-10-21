using JovemProgramadorMVC10.Data.Repositorio;
using JovemProgramadorMVC10.Data.Repositorio.Interfaces;
using JovemProgramadorMVC10.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC10.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorRepositorio;
        public ProfessorController(IProfessorRepositorio ProfessorRepositorio)
        {
            _professorRepositorio = ProfessorRepositorio;
        }
        public IActionResult Index()
        {
            var Professor = _professorRepositorio.BuscarProfessores();

            return View(Professor);
        }

        public IActionResult AdicionarProfessor()
        {
            return View();
        }

        public IActionResult InserirProfessor(Professor Professor)
        {
            try
            {
                _professorRepositorio.InserirProfessor(Professor);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            var aluno = _professorRepositorio.BuscarId(id);
            return View(aluno);
        }

        public IActionResult EditarProfessor(Professor professor)
        {
            _professorRepositorio.EditarProfessor(professor);
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(Professor professor)
        {
            _professorRepositorio.ExcluirProfessor(professor);
            return RedirectToAction("Index");
        }

        public IActionResult AlunosdoProfessor(int id)
        {
            var relatorio = _professorRepositorio.BuscarAlunos(id);
            return View(relatorio);
        }
    }
}
