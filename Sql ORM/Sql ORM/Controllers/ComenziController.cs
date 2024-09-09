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
            Console.WriteLine("Introduceti ID-ul membrului asociat comenzii:");
            int memberId = int.Parse(Console.ReadLine());

            
            var memberExists = _context.Members.Any(m => m.MemberId == memberId);
            if (!memberExists)
            {
                Console.WriteLine("ID-ul membrului nu există. Vă rugăm să introduceți un ID valid.");
                return;
            }

            Console.WriteLine("Care comanda doriti sa o adaugati?:");
            string denumire = Console.ReadLine();

            Console.WriteLine("Care este totalul comenzii?:");
            decimal total = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Introduceti descrierea comenzii:");
            string descriere = Console.ReadLine();

            var NewComanda = new Comanda
            {
                Name = denumire,
                Desc = descriere,
                Total = total,
                DataCreare = DateTime.Now,
                DataModificare = DateTime.Now,
                MemberId = memberId 
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
