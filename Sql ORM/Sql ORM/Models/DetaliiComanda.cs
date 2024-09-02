using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
     public class DetaliiComanda
    {
        [Key]
        public int DetaliiId { get; set; }
        public int ComandaId { get; set; }
        public int ProdusId { get; set; }
        public int Cantitate { get; set; }
        public decimal PretUnitar { get; set; }
        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }
        public Comanda Comanda { get; set; }
        public Produs Produs { get; set; }
    }
}
