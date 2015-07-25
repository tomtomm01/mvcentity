using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcentity.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Anzahl { get; set; }
    }

    public class Einkauf : DbContext
    {
        public Einkauf(): base("name=Einkauf")
        {
        }

        public DbSet<Item> EinkaufListe { get; set; }
    }
}