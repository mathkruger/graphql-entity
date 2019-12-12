using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models.GraphQL
{
    public class EstproType : ObjectGraphType<Estpro>
    {
        public EstproType()
        {
            Name = "Estpro";

            Field(x => x.Codprod).Description("Código do Produto");
            Field(x => x.Descri, type: typeof(StringGraphType)).Description("Descrição do Produto");
            Field(x => x.Qtdemb, type: typeof(DecimalGraphType)).Description("Quantidade/Embalagem");
            Field(x => x.Unidad, type: typeof(StringGraphType)).Description("Unidade");
            Field(x => x.Qtpeso, type: typeof(DecimalGraphType)).Description("Peso");
            Field(x => x.Vlrmax, type: typeof(DecimalGraphType)).Description("Valor Máximo");
            Field(x => x.Locali, type: typeof(StringGraphType)).Description("Localização do Produto");
            Field(x => x.Codfab, type: typeof(IntGraphType)).Description("Código do frabricante do Produto");
        }       
    }
}
