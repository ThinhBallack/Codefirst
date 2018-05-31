using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Koushi: Entity<long>
    {
        public string SenseiKoudo { get; set; } //ma giao vien
        public string Namae { get; set; } //Hoten
        public string Seibetsu { get; set; } //Gioitinh
        public DateTime Tanjoubi { get; set; } //NgaySinh
        public string Juusho { get; set; } //DiaChi
        public string DenwaBango { get; set; } //SDT
        public ICollection<Kulasu> Tannins { get; set; } //quan he ben Nhieu
        public virtual Kulasu Kulasu { get; set; }
    }
}
