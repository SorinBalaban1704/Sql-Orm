using Sql_ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sql_ORM.Program;

namespace Sql_ORM.Controllers
{
    public class MembersController
    {
        private readonly BankBD _context;

        public MembersController()          
        {
            _context = new BankBD();
            _context.Database.EnsureCreated();
        }

        //Comanda de adaugare a unui noi membru
        public void AddMember()
        {
            Console.Write("Introdu numele de familie: ");
            string lastName = Console.ReadLine();

            Console.Write("Introdu prenumele: ");
            string firstName = Console.ReadLine();

            Console.Write("Introdu varsta: ");
            string age = Console.ReadLine();

            Console.Write("Introdu suma initială: ");
            int amount = int.Parse(Console.ReadLine());
            
            var NewMember = new Member
            {
                LastName = lastName,
                FirstName = firstName,
                Age = age,
                Amount = amount,
                DataCreare = DateTime.Now,
                DataModificare = DateTime.Now
            };

            _context.Members.Add(NewMember);
            _context.SaveChanges();
            Console.WriteLine("Membrul a fost adaugat cu succes!");
        }

        //Comanda de afisare a membrilor 
        public void DisplayMembers()
        {
            var members = _context.Members.ToList();

            Console.WriteLine("Lista membrilor:");
            if (members.Count != 0)
            {
                foreach (var member in members)
                {
                    Console.WriteLine($"ID: {member.MemberId}, Nume: {member.LastName}, Prenume: {member.FirstName}, Vârstă: {member.Age}, Suma: {member.Amount}");
                }
            }
            else
                Console.WriteLine("Nu mai sunt Membri"); 
   
        }

        //Comanda de actualizare a unui membru
        public void UpdateMember()
        {
            Console.Write("Introdu ID-ul membrului de actualizat: ");
            int memberId = int.Parse(Console.ReadLine());

            var member = _context.Members.FirstOrDefault(m => m.MemberId == memberId);

            if (member != null)
            {
                Console.Write("Introdu noul nume de familie: ");
                member.LastName = Console.ReadLine();

                Console.Write("Introdu noul prenume: ");
                member.FirstName = Console.ReadLine();

                Console.Write("Introdu noua varstă: ");
                member.Age = Console.ReadLine();

                Console.Write("Introdu noua suma: ");
                member.Amount = int.Parse(Console.ReadLine());

                member.DataModificare = DateTime.Now;

                _context.SaveChanges();
                Console.WriteLine("Membrul a fost actualizat cu succes!");
            }
            else
            {
                Console.WriteLine("Membrul cu ID-ul specificat nu a fost găsit.");
            }
        }

        public void DeleteMember()
        {
            Console.Write("Introdu ID-ul membrului de șters: ");
            int memberId = int.Parse(Console.ReadLine());

            // Găsește membrul în baza de date
            var member = _context.Members.FirstOrDefault(m => m.MemberId == memberId);

            if (member != null)
            {
                // Șterge membrul găsit
                _context.Members.Remove(member);
                _context.SaveChanges();
                Console.WriteLine("Membrul a fost sters cu succes!");
            }
            else
            {
                Console.WriteLine("Membrul cu ID-ul specificat nu a fost găsit.");
            }
        }
    }

}
