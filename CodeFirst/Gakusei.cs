using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Gakusei: Entity<long>
    {
        public string Namae { get; set; } //Ten
        public string Seibetsu { get; set; } //Gioitinh
        public DateTime Tanjoubi { get; set; } //SinhNhat
        public string Juusho { get; set; } //DiaChi
        public string GakuseiKoudo { get; set; }//MSSV
        public ICollection<GakuseiKulasu> Kulasu { get; set; }
    }
}
