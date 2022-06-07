using System;
using System.Collections.Generic;

#nullable disable

namespace WepApp.Models
{
    public partial class Loaitk
    {
        public Loaitk()
        {
            Khachhangs = new HashSet<Khachhang>();
        }

        public int Maloaitk { get; set; }
        public string Tenloaitk { get; set; }

        public virtual ICollection<Khachhang> Khachhangs { get; set; }
    }
}
