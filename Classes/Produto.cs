using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESTUDOS_CSHARP_LINQ
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }

    }
}