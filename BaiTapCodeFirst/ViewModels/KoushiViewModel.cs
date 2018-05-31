using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirst;

namespace BaiTapCodeFirst.ViewModels
{
    public class KoushiModel
    {
        public string SenseiKoudo { get; set; } //ma giao vien
        public string Namae { get; set; } //Hoten
        public string Seibetsu { get; set; } //Gioitinh
        public DateTime Tanjoubi { get; set; } //NgaySinh
        public string Juusho { get; set; } //DiaChi
        public string DenwaBango { get; set; } //SDT
        public long Id { get; set; }
        public KoushiModel() { }
        public KoushiModel(Koushi koushi)
        {
            
            this.SenseiKoudo = koushi.SenseiKoudo;
            this.Namae = koushi.Namae;
            this.Seibetsu = koushi.Seibetsu;
            this.Tanjoubi = koushi.Tanjoubi;
            this.Juusho = koushi.Juusho;
            this.DenwaBango = koushi.DenwaBango;
            this.Id = koushi.Id;
        }
    }
    public class CreateKoushiModel
    {
        public string SenseiKoudo { get; set; } //ma giao vien
        public string Namae { get; set; } //Hoten
        public string Seibetsu { get; set; } //Gioitinh
        public DateTime Tanjoubi { get; set; } //NgaySinh
        public string Juusho { get; set; } //DiaChi
        public string DenwaBango { get; set; } //SDT
    }
    public class UpdateKoushiModel : CreateKoushiModel
    {
        public long Id { get; set; }
    }
}