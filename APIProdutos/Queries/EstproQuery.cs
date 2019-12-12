using APIProdutos.Data;
using APIProdutos.Models.GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using APIProdutos.Models;

namespace APIProdutos.Queries
{
    public class EstproQuery : ObjectGraphType
    {
        public EstproQuery(ApplicationDbContext db)
        {
            Field<ListGraphType<EstproType>>(
                "estpro",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "codprod", Description = "Código do produto" }
                ),
                resolve: context =>
                {
                    int codprod = context.GetArgument<int>("codprod", 0);
                    DbSet<Estpro> estpros;

                    if (codprod != 0)
                    {
                        return db.Estpro.Where(x => x.Codprod == codprod);
                    }

                    estpros = db.Estpro;

                    return estpros;
                });

            Field<ListGraphType<RodfabType>>(
                "rodfab",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "codfab", Description = "Código do Fabricante" }
                ),
                resolve: context =>
                {
                    int codfab = context.GetArgument<int>("codfab", 0);
                    DbSet<Rodfab> estpros;

                    if (codfab != 0)
                    {
                        return db.Rodfab.Where(x => x.Codfab == codfab);
                    }

                    estpros = db.Rodfab;

                    return estpros;
                });

            Field<ListGraphType<RodfilType>>(
                "rodfil",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "codfil", Description = "Código da Filial" }
                ),
                resolve: context =>
                {
                    int codfil = context.GetArgument<int>("codfil", 0);
                    DbSet<Rodfil> rodfils;

                    if (codfil != 0)
                    {
                        return db.Rodfil.Where(x => x.Codfil == codfil);
                    }

                    rodfils = db.Rodfil;

                    return rodfils;
                });

        }
    }
}
