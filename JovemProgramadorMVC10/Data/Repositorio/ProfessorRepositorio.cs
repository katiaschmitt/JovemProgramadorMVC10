﻿using JovemProgramadorMVC10.Data.Repositorio.Interfaces;
using JovemProgramadorMVC10.Models;

namespace JovemProgramadorMVC10.Data.Repositorio
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public ProfessorRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Professor> BuscarProfessores()
        {

            return _bancoContexto.Professor.ToList();
        }

        public void InserirProfessor(Professor Professor)
        {
            _bancoContexto.Professor.Add(Professor);
        }

        public Professor BuscarId(int id)
        {
            return _bancoContexto.Professor.FirstOrDefault(x => x.Id == id);
        }

        public void EditarProfessor(Professor Professor)
        {

            _bancoContexto.Professor.Update(Professor);
            _bancoContexto.SaveChanges();
        }

        public void ExcluirProfessor(Professor Professor)
        {
            _bancoContexto.Professor.Remove(Professor);
            _bancoContexto.SaveChanges();
        }
    }
}