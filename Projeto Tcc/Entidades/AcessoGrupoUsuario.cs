using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Projeto_Tcc.Entidades
{
    public class AcessoGrupoUsuario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public GrupoUsuario GrupoUsuario { get; set; }
        public Acesso Acesso { get; set; }
    }
}
