using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UrunOzellik
    {
        public int Id { get; set; }

        public int UrunlerId { get; set; }

        public int UrunOlculerId { get; set; }

        public bool Durum { get; set; }
        public int UrunRenklerId { get; set; }

        public int UrunMateriyallerId { get; set; }

    }
}