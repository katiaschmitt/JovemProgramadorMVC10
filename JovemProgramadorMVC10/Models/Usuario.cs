﻿using System.ComponentModel.DataAnnotations;

namespace JovemProgramadorMVC10.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
