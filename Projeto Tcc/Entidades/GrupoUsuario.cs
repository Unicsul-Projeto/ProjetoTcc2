using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Tcc.Entidades
{
    public class GrupoUsuario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IList<Acesso> Acessos { get; set; }
    }
}
