using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models
{
    public class Estpro
    {
        [Key]
        public int Codprod { get; set; }
        public string Descri { get; set; }
        public decimal? Qtdemb { get; set; }
        public string Unidad { get; set; }
        public decimal? Qtpeso { get; set; }
        public decimal? Vlrmax { get; set; }
        public string Locali { get; set; }

        public short? Codfab { get; set; }
        public Rodfab Rodfab { get; set; }
    }
}
