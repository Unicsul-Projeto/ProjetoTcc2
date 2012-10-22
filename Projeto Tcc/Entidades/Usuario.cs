using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Tcc.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public string NomeLogin { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public char Situacao { get; set; }
        public GrupoUsuario GrupoUsuario { get; set; }

    }
}
