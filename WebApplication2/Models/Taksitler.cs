using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Taksitler
    {
        public int Id { get; set; }

        public int TaksitTablolarId { get; set; }

        public int BankalarId { get; set; }

        public int SiparislerId { get; set; }

        public bool Durum { get; set; }
    }
}