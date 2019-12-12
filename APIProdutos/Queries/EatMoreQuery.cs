using APIProdutos.Data;
using APIProdutos.Models.GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIProdutos.Queries
{
    public class EatMoreQuery : ObjectGraphType
    {
        public EatMoreQuery(ApplicationDbContext db)
        {

            Field<ListGraphType<ProdutoType>>(
                "produtos",
                resolve: context =>
                {
                    var produtos = db
                    .Produtos;
                    return produtos;
                });

            Field<ProdutoType>(
                "produto",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "codigoBarras", Description = "Código de Barras do Produto" }
                ),
                resolve: (context) => 
                {
                    var codigoBarras = context.GetArgument<string>("codigoBarras");

                    var produto = db.Produtos.Where(
                    p => p.CodigoBarras == codigoBarras).FirstOrDefault();
                    return produto;
                }
            );

        }
    }
}
