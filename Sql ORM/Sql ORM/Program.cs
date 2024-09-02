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
                bool running = true;
                while (running)
                {
                    Console.WriteLine("Selecteaza o operatie:");
                    Console.WriteLine("1. Adauga un membru");
                    Console.WriteLine("2. Afisează membrii");
                    Console.WriteLine("3. Modifică un membru");
                    Console.WriteLine("4. Sterge un membru");
                    Console.WriteLine("_________________________________________________________");
                    Console.WriteLine("4. Sterge un membru");
                    Console.WriteLine("5. Iesire");

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
                            running = false;
                            break;

                    }
                }

        }   

        
        
        
    }
}
