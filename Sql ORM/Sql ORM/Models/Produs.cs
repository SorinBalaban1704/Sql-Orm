using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
    public class Produs
    {
        public int ProdusId { get; set; }
        public required string Denumire { get; set; }
        public decimal Pret { get; set; }
        public int Stoc { get; set; }
        public required string Descriere { get; set; }
        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }
        public ICollection<DetaliiComanda> DetaliiComenzi { get; set; }
    }
}
