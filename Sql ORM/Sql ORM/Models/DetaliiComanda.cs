using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
     public class DetaliiComanda
    {
        [Key]
        public int DetaliiId { get; set; }

        [Required(ErrorMessage = "ComandaId este obligatoriu.")]
        [ForeignKey("Comanda")]
        public int ComandaId { get; set; }

        [Required(ErrorMessage = "ProdusId este obligatoriu.")]
        [ForeignKey("Produs")]
        public int ProdusId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Cantitatea trebuie să fie mai mare decât zero.")]
        public int Cantitate { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Prețul unitar trebuie să fie mai mare decât zero.")]
        public decimal PretUnitar { get; set; }

        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }

        [Required]
        public Comanda Comand { get; set; }

        [Required]
        public Produs Produs { get; set; }

        
        public DetaliiComanda()
        {
            DataCreare = DateTime.Now;
            DataModificare = DateTime.Now;
        }
    }
}
