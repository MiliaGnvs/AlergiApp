using System;
using System.Collections.Generic;
using System.Text;

namespace AlergiApp.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DataNasc { get; set; }
    }
}
