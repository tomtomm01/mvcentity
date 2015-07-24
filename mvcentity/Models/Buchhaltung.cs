namespace mvcentity.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Buchhaltung : DbContext
    {
        public Buchhaltung()
            : base("name=Buchhaltung")
        {
        }

        public virtual DbSet<Transaktion> Transaktionen { get; set; }
    }

    public class Transaktion
    {
        public int Id { get; set; }
        public decimal Summe { get; set; }
        public DateTime Datum { get; set; }
        public bool IstAusgabe { get; set; }
        public string Information { get; set; }
    }
}