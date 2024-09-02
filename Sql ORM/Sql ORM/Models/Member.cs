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
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
        public required string Age { get; set; }
        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }
        public int Amount { get; set; }
        public ICollection<Comanda> Comenzi { get; set; }
        public ProfileMember ProfileMember { get; set; }
    }
}
