using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required(ErrorMessage = "Numele de familie este obligatoriu.")]
        [StringLength(50, ErrorMessage = "Numele de familie nu poate depăși 50 de caractere.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Prenumele este obligatoriu.")]
        [StringLength(50, ErrorMessage = "Prenumele nu poate depăși 50 de caractere.")]
        public string FirstName { get; set; }

        [Range(0, 120, ErrorMessage = "Vârsta trebuie să fie între 0 și 120.")]
        public int Age { get; set; }

        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Suma nu poate fi negativă.")]
        public int Amount { get; set; }

        public ICollection<Comanda> Comenzi { get; set; }

        [Required(ErrorMessage = "Profilul este obligatoriu.")]
        public ProfileMember ProfileMember { get; set; }

        
        public Member()
        {
            DataCreare = DateTime.Now;
            DataModificare = DateTime.Now;
            Comenzi = new List<Comanda>();
        }
    }
}
