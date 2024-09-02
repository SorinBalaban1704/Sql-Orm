using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
    public class ProfileMember
    {
        [Key]
        public int ProfileId { get; set; }
        public int MemberId { get; set; }
        public required string Adress { get; set; }
        public required string PhoneNumber { get; set; }
        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }
        public Member Member { get; set; }
    }
}
