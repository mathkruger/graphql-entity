using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models
{
    public class Rodfil
    {
        [Key]
        public short Codfil { get; set; }
        public string Razsoc { get; set; }
        public string Codcgc { get; set; }
    }
}
