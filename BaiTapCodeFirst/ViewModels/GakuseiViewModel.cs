using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirst;
namespace BaiTapCodeFirst.ViewModels
{
    public class GakuseiModel
    {
        public string Namae { get; set; } //Ten
        public string Seibetsu { get; set; } //Gioitinh
        public DateTime Tanjoubi { get; set; } //SinhNhat
        public string Juusho { get; set; } //DiaChi
        public string GakuseiKoudo { get; set; }//MSSV
        public long Id { get; set; }
        public GakuseiModel() { }
        public GakuseiModel(Gakusei gakusei)
        {
            this.Namae = gakusei.Namae;
            this.Seibetsu = gakusei.Seibetsu;
            this.Tanjoubi = gakusei.Tanjoubi;
            this.Juusho = gakusei.Juusho;
            this.GakuseiKoudo = gakusei.GakuseiKoudo;
            this.Id = gakusei.Id;
        }
    }
    public class CreateGakuseiModel
    {
        public string Namae { get; set; } //Ten
        public string Seibetsu { get; set; } //Gioitinh
        public DateTime Tanjoubi { get; set; } //SinhNhat
        public string Juusho { get; set; } //DiaChi
        public string GakuseiKoudo { get; set; }//MSSV

        //public GakuseiKulasu Kulasu { get; set; }
    }

    public class UpdateGakuseiModel : CreateGakuseiModel
    {
        public long Id { get; set; }
    }
}