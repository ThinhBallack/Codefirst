using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Kulasu : Entity<int>
    {
        public string Koudo { get; set; } //malop
        public string Namae { get; set; } //tenlop
        public double JugyouRyou { get; set; } //hocphi
        public int GakuseiSuo { get; set; } //si so
        public virtual Koushi Tannin  //quan he ben Mot
        {
            get; set;
        }
        public ICollection<Koushi> Koushi
        {
            get; set;
        }
        public ICollection<GakuseiKulasu> Gakusei
        {
            get; set;
        }
    }
}
