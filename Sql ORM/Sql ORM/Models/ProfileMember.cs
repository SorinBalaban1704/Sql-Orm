using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
    public class ProfileMember
    {
        [Key]
        public int ProfileId { get; set; }

        [Required(ErrorMessage = "MemberId este obligatoriu.")]
        public int MemberId { get; set; }

        [Required(ErrorMessage = "Adresa este obligatorie.")]
        [StringLength(250, ErrorMessage = "Adresa nu poate depăși 250 de caractere.")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Numărul de telefon este obligatoriu.")]
        [StringLength(20, ErrorMessage = "Numărul de telefon nu poate depăși 20 de caractere.")]
        [Phone(ErrorMessage = "Numărul de telefon nu este valid.")]
        public string PhoneNumber { get; set; }

        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }

        [ForeignKey("MemberId")]
        public Member Member { get; set; }

        
        public ProfileMember()
        {
            DataCreare = DateTime.Now;
            DataModificare = DateTime.Now;
        }
    }
}
