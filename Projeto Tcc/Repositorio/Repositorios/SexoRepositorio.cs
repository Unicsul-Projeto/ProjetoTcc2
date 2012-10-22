﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projeto_Tcc.Entidades;
using Projeto_Tcc.Repositorio.Helpers;

namespace Projeto_Tcc.Repositorio.Repositorios
{
    public interface ISexoRepositorio :IRepositorio<Sexo>
    {
        
    }
    public class SexoRepositorio:DAO<Sexo>, ISexoRepositorio
    {
        public SexoRepositorio(SessionProvider sessionProvider) : base(sessionProvider)
        {
        }
    }
}
