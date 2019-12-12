using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIProdutos.Models
{
    public class Rodfab
    {
        [Key]
        public short Codfab { get; set; }
        public string Descri { get; set; }
    }
}
