using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetNewsApp.Models
{
    public class Haber
    {
        public int id { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }
        public DateTime tarih { get; set; }
        public string kaynak { get; set; }
        public string kategori { get; set; }
        public string gorsel { get; set; }
        public int okunmaSayisi { get; set; }

    }
}
