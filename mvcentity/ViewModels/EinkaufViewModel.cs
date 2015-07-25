using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcentity.Models;

namespace mvcentity.ViewModels
{
    public class EinkaufViewModel
    {
        public string Name { get; set; }
        public int Anzahl { get; set; }
        public List<Item> EinkaufListe { get; set; }
    }
}