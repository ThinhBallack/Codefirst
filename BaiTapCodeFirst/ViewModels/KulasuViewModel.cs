using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirst;

namespace BaiTapCodeFirst.ViewModels
{
    public class KulasuModel
    {
        public string Koudo { get; set; } //malop
        public string Namae { get; set; } //tenlop
        public double JugyouRyou { get; set; } //hocphi
        public int GakuseiSuo { get; set; } //si so
        public long Id { get; set; }
        public KulasuModel() { }
        public KulasuModel(Kulasu kulasu)
        {
            this.Namae = kulasu.Namae;
            this.Koudo = kulasu.Koudo;
            this.JugyouRyou = kulasu.JugyouRyou;
            this.GakuseiSuo = kulasu.GakuseiSuo;
            this.Id = kulasu.Id;
        }
    }
    public class CreateKulasuModel
    {
        public string Koudo { get; set; } //malop
        public string Namae { get; set; } //tenlop
        public double JugyouRyou { get; set; } //hocphi
        public int GakuseiSuo { get; set; } //si so
    }
        public class UpdateKulasuModel : CreateKulasuModel
    {
        public long Id { get; set; }
    }
}
