using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Sql_ORM.Models
{
    public class Comanda
    {
        [ForeignKey("Comanda")]
        
        public int ComandaId { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "MemberId este obligatoriu.")]
        [Range(1, int.MaxValue, ErrorMessage = "MemberId trebuie să fie mai mare decât zero.")]
        public int MemberId { get; set; }
        public decimal Total { get; set; }
        public string Desc { get; set; }
        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }

        [Required(ErrorMessage = "Membrul este obligatoriu.")]
        public Member Member { get; set; }
        public ICollection<DetaliiComanda> DetaliiComenzi { get; set; }
        public Comanda()
        {
            DataCreare = DateTime.Now;
            DataModificare = DateTime.Now;
            DetaliiComenzi = new List<DetaliiComanda>();
        }
    }
}
