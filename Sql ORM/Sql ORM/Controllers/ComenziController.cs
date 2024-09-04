using Sql_ORM.Models;
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
        public void AddComanda()
        {
            Console.WriteLine("Care comanda doriti sa o adaugtati?:");
            string denumire = Console.ReadLine();

            Console.WriteLine("Care este totalul comenzii?:");
            decimal total = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Introduceti descrirea comnezii:");
            string descriere = Console.ReadLine();

            var NewComanda = new Comanda
            {
                Name = denumire,
                Desc = descriere,
                Total = total,
                DataCreare = DateTime.Now,
                DataModificare = DateTime.Now

            };
            _context.Comand.Add(NewComanda);
            _context.SaveChanges();
            Console.WriteLine("Comanda a fost adaugata");
        }
        public void DisplayComanda()
        {
            var comenzi = _context.Comand.ToList();

            Console.WriteLine("Lista comenzi: ");
            if (comenzi.Count != 0)
            {
                foreach (var comanda in comenzi)
                {
                    Console.WriteLine($"ID: {comanda.ComandaId}, ID Membru: {comanda.MemberId}, Denumirea comenzii {comanda.Name}, Descierea comenzii {comanda.Desc} ");
                }
            }
            else
                Console.WriteLine("Nu sunt comenzi!");

        }
        public void DeleteComanda()
        {
            Console.WriteLine("Introdu Id-ul comenzii de sters: ");
            int comandaId = int.Parse(Console.ReadLine());

            var comanda = _context.Comand.FirstOrDefault(c => c.ComandaId == comandaId);

            if (comanda != null)
            {
                _context.Comand.Remove(comanda);
                _context.SaveChanges();
                Console.WriteLine("Comanda a fost stersa cu succes");
            }
            else
            {
                Console.WriteLine("Id-ul comenzii nu a fost gasit.");
            }
        }
    }


}
