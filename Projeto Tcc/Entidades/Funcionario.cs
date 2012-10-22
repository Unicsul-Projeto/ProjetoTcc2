using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Tcc.Entidades
{
    public class Funcionario
    {
        public int Id { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public Cargo Cargo { get; set; }
        public string NumCarteira { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }
    }
}
