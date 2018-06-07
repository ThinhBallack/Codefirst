using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [InverseProperty("Tannins")]
        public virtual Koushi Tannin  //quan he ben Mot
        {
            get; set;
        }
        [InverseProperty("Tannins")]    
        public ICollection<Koushi> Koushi
        {
            get; set;
        }
        [InverseProperty("SenseiKoudo")]
        public ICollection<GakuseiKulasu> Gakusei
        {
            get; set;
        }
    }
}
