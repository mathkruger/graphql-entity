using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models.GraphQL
{
    public class RodfabType : ObjectGraphType<Rodfab>
    {
        public RodfabType()
        {
            Name = "Rodfab";

            Field(x => x.Codfab, type: typeof(IntGraphType)).Description("Código do fabricante");
            Field(x => x.Descri, type: typeof(StringGraphType)).Description("Descrição do fabricante");
        }
    }
}
