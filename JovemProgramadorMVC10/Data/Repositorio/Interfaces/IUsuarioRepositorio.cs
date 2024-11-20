using JovemProgramadorMVC10.Models;

namespace JovemProgramadorMVC10.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        public Usuario ValidarUsuario(Usuario usuario);
        public void CadastrarUsuario(Usuario usuario);
    }
}
