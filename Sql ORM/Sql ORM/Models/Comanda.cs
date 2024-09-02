using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
    public class Comanda
    {
        public int ComandaId { get; set; }
        public int MemberId { get; set; }
        public decimal Total { get; set; }
        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }
        public Member Member { get; set; }
        public ICollection<DetaliiComanda> DetaliiComenzi { get; set; }
    }
}
