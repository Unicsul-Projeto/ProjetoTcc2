using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Projeto_Tcc.Repositorio.Helpers;
using Projeto_Tcc.Repositorio.Repositorios;
using Projeto_Tcc.Visualizacao;

namespace Projeto_Tcc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = ContainerWindsor.InicializarContainer();
            container.Resolve<IPessoaFisicaRepositorio>();
            container.Resolve<IEnderecoRepositorio>();
            container.Resolve<ISexoRepositorio>();
            container.Resolve<IUfRepositorio>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Consultar_Cliente());


        }
    }
}
