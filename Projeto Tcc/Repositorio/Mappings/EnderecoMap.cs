using FluentNHibernate.Mapping;
using Projeto_Tcc.Entidades;

namespace Projeto_Tcc.Repositorio.Mappings
{
    public class EnderecoMap:ClassMap<Endereco>
    {
        public EnderecoMap()
        {
            Id(x => x.Id).GeneratedBy.Native();

            Map(x => x.Cep);
            Map(x => x.Logradouro);
            Map(x => x.Bairro);
            Map(x => x.Cidade);
            
            References(x => x.Uf);

            //References(x => x.PessoaFisica);
            //References(x => x.PessoaJuridica);
        }
    }
}
