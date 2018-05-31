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
    public class KoushiController : ApiController
    {
        private YuriSentaa _db;
        public KoushiController()
        {
            this._db = new YuriSentaa();
        }

        [HttpPost]
        public IHttpActionResult CreateKoushi(CreateKoushiModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            if (string.IsNullOrEmpty(model.SenseiKoudo))
            {
                errors.Add("Mã giáo viên là trường bắt buộc");
            }

            if (string.IsNullOrEmpty(model.Namae))
            {
                errors.Add("Tên giáo viên là trường bắt buộc");
            }

            if (errors.Errors.Count == 0)
            {
                Koushi koushi = new Koushi();
                koushi.SenseiKoudo = model.SenseiKoudo;
                koushi.Namae = model.Namae;
                koushi.Seibetsu = model.Seibetsu;
                koushi.Tanjoubi = model.Tanjoubi;
                koushi.Juusho = model.Juusho;
                koushi.DenwaBango = model.DenwaBango;

                koushi = _db.Koushi.Add(koushi);

                this._db.SaveChanges();

                KoushiModel viewModel = new KoushiModel(koushi);

                httpActionResult = Ok(viewModel);
            }
            else
            {
                httpActionResult = Ok(errors);
            }

            return httpActionResult;
        }
        [HttpPut]
        public IHttpActionResult UpdateKoushi(UpdateKoushiModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            Koushi koushi = this._db.Koushi.FirstOrDefault(x => x.Id == model.Id);

            if (koushi == null)
            {
                errors.Add("Không tìm thấy giáo viên");

                httpActionResult = Ok(errors);
            }
            else
            {
                koushi.SenseiKoudo = model.SenseiKoudo ?? model.SenseiKoudo;
                koushi.Namae = model.Namae ?? model.Namae;
                koushi.Seibetsu = model.Seibetsu ??  model.Seibetsu;
                if (model.Tanjoubi != null)
                {
                    koushi.Tanjoubi = model.Tanjoubi;
                }
                else { }
                koushi.Juusho = model.Juusho ?? model.Juusho;
                koushi.DenwaBango = model.DenwaBango ?? model.DenwaBango;

                this._db.Entry(koushi).State = System.Data.Entity.EntityState.Modified;

                this._db.SaveChanges();

                httpActionResult = Ok(new KoushiModel(koushi));
            }

            return httpActionResult;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var listKoushi = this._db.Koushi.Select(x => new KoushiModel()
            {
                SenseiKoudo = x.SenseiKoudo,
                Namae = x.Namae,
                Seibetsu = x.Seibetsu,
                Tanjoubi = x.Tanjoubi,
                Juusho = x.Juusho,
                DenwaBango = x.DenwaBango,
                Id = x.Id
            });

            return Ok(listKoushi);
        }
        [HttpGet]
        public IHttpActionResult GetById(long id)
        {
            IHttpActionResult httpActionResult;
            var koushi = _db.Koushi.FirstOrDefault(x => x.Id == id);

            if (koushi == null)
            {
                ErrorModel errors = new ErrorModel();
                errors.Add("Không tìm thấy giáo viên");

                httpActionResult = Ok(errors);
            }
            else
            {
                httpActionResult = Ok(new KoushiModel(koushi));
            }
            return httpActionResult;
        }

    }
}
