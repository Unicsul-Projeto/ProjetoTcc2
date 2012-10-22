using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Tcc.Entidades
{
    public class Cargo
    {
        public int Id { get; set; }
        public Setor Setor { get; set; }
        public string Descricao { get; set; }
    }
}
