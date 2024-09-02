using Sql_ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Controllers
{
    public class ProdusController
    {
        private readonly BankBD _context;

        public ProdusController()
        {
            _context = new BankBD();
            _context.Database.EnsureCreated();
        }

        public void AddProdus()
        {
            Console.WriteLine("Ce produs doriti sa adaugati? :");
            string numeleProd = Console.ReadLine(); 
            
            Console.WriteLine("Introdu pretul produsului:");
            decimal price = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introdu stocul disponibil:");
            int stoc = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Scrie descrierea produsului:");
            string descriere = Console.ReadLine();
            
            var NewProdus = new Produs
            {
                Denumire = numeleProd,
                Pret = price,
                Stoc = stoc,
                Descriere = descriere

            };

            _context.Produs.Add(NewProdus);
            _context.SaveChanges();
            Console.WriteLine("Produsul a fost adaugat");
        }
        public void DisplayProdus() 
        {
            
            var produse = _context.Produs.ToList();
            
            Console.WriteLine("Lista produselor: ");
            if (produse.Count != 0)
            {
                foreach (var produs in produse)
                {
                    Console.WriteLine($"ID: {produs.ProdusId}, Nume: {produs.Denumire}, Pret: {produs.Pret}, Stoc: {produs.Stoc}, Descriere: {produs.Descriere} ");
                }
            }
            else
                Console.WriteLine("Nu sunt produse!");

        }


    }
}





























