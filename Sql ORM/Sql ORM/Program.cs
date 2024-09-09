using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql_ORM.Controllers;
namespace Sql_ORM
{
    public class Program
    {
        
        

        
        static void Main(string[] args)
        {

            
                var memberController = new MembersController();
                var comenziController = new ComenziController();
                var produsController = new ProdusController();
                bool running = true;
                while (running)
                {
                    Console.WriteLine("Selecteaza o operatie:");
                    Console.WriteLine("1. Adauga un membru");
                    Console.WriteLine("2. Afisează membrii");
                    Console.WriteLine("3. Modifică un membru");
                    Console.WriteLine("4. Sterge un membru");
                    Console.WriteLine("_________________________________________________________");
                    Console.WriteLine("5. Adauga o comanda");
                    Console.WriteLine("6. Afiseaza comenzile");
                    Console.WriteLine("7. Sterge o comanda");
                    Console.WriteLine("_________________________________________________________");
                    Console.WriteLine("8. Adauga un produs");
                    Console.WriteLine("9. Afiseaza produsele");
                    Console.WriteLine("10. Sterge un produs");
                    Console.WriteLine("11. Iesire");

                    var key = Console.ReadLine();
                    switch (key)
                    {
                        case "1":
                            memberController.AddMember();
                            break;
                        case "2":
                            memberController.DisplayMembers();
                            break;
                        case "3":
                            memberController.UpdateMember();
                            break;
                        case "4":
                            memberController.DeleteMember();
                            break;
                        case "5":
                            comenziController.AddComanda();
                            break;
                        case "6":
                            comenziController.DisplayComanda();
                            break;
                        case "7":
                            comenziController.DeleteComanda();
                            break;
                        case "8":
                            produsController.AddProdus();
                            break;
                        case "9":
                            produsController.DisplayProdus();
                            break;
                        case "10":
                            produsController.DeleteProdus();
                            break;  
                        case "11":
                            running = false;
                            break;

                    }
                }

        }   

        
        
        
    }
}
