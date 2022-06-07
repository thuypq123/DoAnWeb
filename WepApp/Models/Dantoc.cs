using System;
using System.Collections.Generic;

#nullable disable

namespace WepApp.Models
{
    public partial class Dantoc
    {
        public Dantoc()
        {
            Khachhangs = new HashSet<Khachhang>();
        }

        public int Madt { get; set; }
        public string Tendt { get; set; }

        public virtual ICollection<Khachhang> Khachhangs { get; set; }
    }
}
