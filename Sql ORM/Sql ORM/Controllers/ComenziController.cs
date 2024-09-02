using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Controllers
{
    public class ComenziController
    {
        private readonly BankBD _context;

        public ComenziController()
        {
            _context = new BankBD();
            _context.Database.EnsureCreated();
        }
    }
}
