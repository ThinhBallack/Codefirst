using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeFirst;
using BaiTapCodeFirst.ViewModels;

namespace BaiTapCodeFirst.Controllers
{
    public class GakuseiController : ApiController
    {
        private YuriSentaa _db;
        public GakuseiController()
        {
            this._db = new YuriSentaa();
        }

        [HttpPost]
        public IHttpActionResult CreateGakusei(CreateGakuseiModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            if (string.IsNullOrEmpty(model.GakuseiKoudo))
            {
                errors.Add("Mã học sinh là trường bắt buộc");
            }

            if (string.IsNullOrEmpty(model.Namae))
            {
                errors.Add("Tên học sinh là trường bắt buộc");
            }

            if (errors.Errors.Count == 0)
            {
                Gakusei gakusei = new Gakusei();
                gakusei.Namae = model.Namae;
                gakusei.Seibetsu = model.Seibetsu;
                gakusei.Tanjoubi = model.Tanjoubi; 
                gakusei.Juusho = model.Juusho; //diachi
                gakusei.GakuseiKoudo = model.GakuseiKoudo; //ma sinh vien

                gakusei = _db.Gakusei.Add(gakusei);

                this._db.SaveChanges();

                GakuseiModel viewModel = new GakuseiModel(gakusei);

                httpActionResult = Ok(viewModel);
            }
            else
            {
                httpActionResult = Ok(errors);
            }

            return httpActionResult;
        }
        [HttpPut]
        public IHttpActionResult UpdateGakusei(UpdateGakuseiModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            Gakusei gakusei = this._db.Gakusei.FirstOrDefault(x => x.Id == model.Id);

            if (gakusei == null)
            {
                errors.Add("Không tìm thấy học sinh");

                httpActionResult = Ok(errors);
            }
            else
            {
                gakusei.GakuseiKoudo = model.GakuseiKoudo ?? model.GakuseiKoudo;
                gakusei.Namae = model.Namae ?? model.Namae;
                gakusei.Seibetsu = model.Seibetsu ?? model.Seibetsu;
                gakusei.Juusho = model.Juusho ?? model.Juusho;
                if (model.Tanjoubi != null)
                {
                    gakusei.Tanjoubi = model.Tanjoubi;
                }
                else { }
                

                this._db.Entry(gakusei).State = System.Data.Entity.EntityState.Modified;

                this._db.SaveChanges();

                httpActionResult = Ok(new GakuseiModel(gakusei));
            }

            return httpActionResult;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var listGakusei = this._db.Gakusei.Select(x => new GakuseiModel()
            {
                Namae = x.Namae,
                Seibetsu = x.Seibetsu,
                Tanjoubi = x.Tanjoubi,
                Juusho = x.Juusho, //diachi
                GakuseiKoudo = x.GakuseiKoudo, //ma sinh vien
                Id = x.Id
            });

            return Ok(listGakusei);
        }
        [HttpGet]
        public IHttpActionResult GetById(long id)
        {
            IHttpActionResult httpActionResult;
            var gakusei = _db.Gakusei.FirstOrDefault(x => x.Id == id);

            if (gakusei == null)
            {
                ErrorModel errors = new ErrorModel();
                errors.Add("Không tìm thấy học sinh");

                httpActionResult = Ok(errors);
            }
            else
            {
                httpActionResult = Ok(new GakuseiModel(gakusei));
            }
            return httpActionResult;
        }

    }
}
