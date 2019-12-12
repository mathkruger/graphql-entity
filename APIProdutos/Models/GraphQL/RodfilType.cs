using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models.GraphQL
{
    public class RodfilType : ObjectGraphType<Rodfil>
    {
        public RodfilType()
        {
            Field(x => x.Codfil).Description("Código da Filial");
            Field(x => x.Razsoc, type: typeof(StringGraphType)).Description("Razão Social");
            Field(x => x.Codcgc, type: typeof(StringGraphType)).Description("CNPJ");
        }
    }
}
