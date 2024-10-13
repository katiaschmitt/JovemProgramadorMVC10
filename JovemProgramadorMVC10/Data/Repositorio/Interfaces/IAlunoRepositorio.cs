using JovemProgramadorMVC10.Models;

namespace JovemProgramadorMVC10.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessores();
        void InserirProfessor(Professor Professor);
        Professor BuscarId(int id);
        void EditarProfessor(Professor Professor);
        void ExcluirProfessor(Professor Professor);
    }
}
