using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_ORM.Models
{
    public class Produs
    {
        [Key]
        public int ProdusId { get; set; }
        public required string Denumire { get; set; }
        public decimal Pret { get; set; }
        public int Stoc { get; set; }
        public required string Descriere { get; set; }
        public DateTime DataCreare { get; set; }
        public DateTime DataModificare { get; set; }

        public Produs()
        {
            DataCreare = DateTime.Now;
            DataModificare = DateTime.Now;
        }

        private void ActualizeazaDataModificare()
        {
            DataModificare = DateTime.Now;
        }

        public void CrestereStoc(int cantitate)
        {
            if (cantitate <= 0)
            {
                throw new ArgumentException("Cantitatea este pe zero");
            }

            Stoc += cantitate;
            ActualizeazaDataModificare();
        }


        public void ReducereStoc(int cantitate)
        {
            if (cantitate <= 0)
            {
                throw new ArgumentException("Cantitatea trebuie sa fie mai mare");
            }

            if(Stoc < cantitate)
            {
                throw new ArgumentException("Stoc insuficient");
            }
            Stoc -= cantitate;
            ActualizeazaDataModificare();
        }

        public void SetPret(decimal pret)
        {
            if (pret < 0)
            {
                throw new ArgumentException("Prețul nu poate fi negativ.");
            }

            Pret = pret;
            ActualizeazaDataModificare();
        }
    }
}
