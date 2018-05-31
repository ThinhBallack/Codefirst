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
    public class KulasuController : ApiController
    {
        private YuriSentaa _db;
        public KulasuController()
        {
            this._db = new YuriSentaa();
        }

        [HttpPost]
        public IHttpActionResult CreateKulasu(CreateKulasuModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            if (string.IsNullOrEmpty(model.Koudo))
            {
                errors.Add("Mã lớp là trường bắt buộc");
            }

            if (string.IsNullOrEmpty(model.Namae))
            {
                errors.Add("Tên lớp là trường bắt buộc");
            }

            if (errors.Errors.Count == 0)
            {
                Kulasu kulasu = new Kulasu();
                kulasu.Namae = model.Namae;
                kulasu.Koudo = model.Koudo;
                kulasu.JugyouRyou = model.JugyouRyou;
                kulasu.GakuseiSuo = model.GakuseiSuo;

                kulasu = _db.Kulasu.Add(kulasu);

                this._db.SaveChanges();

                KulasuModel viewModel = new KulasuModel(kulasu);

                httpActionResult = Ok(viewModel);
            }
            else
            {
                httpActionResult = Ok(errors);
            }

            return httpActionResult;
        }
        [HttpPut]
        public IHttpActionResult UpdateKulasu(UpdateKulasuModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            Kulasu kulasu = this._db.Kulasu.FirstOrDefault(x => x.Id == model.Id);

            if (kulasu == null)
            {
                errors.Add("Không tìm thấy lớp");

                httpActionResult = Ok(errors);
            }
            else
            {
                kulasu.Koudo = model.Koudo ?? model.Koudo;
                kulasu.Namae = model.Namae ?? model.Namae;
                if(model.JugyouRyou >= 0)
                {
                    kulasu.JugyouRyou = model.JugyouRyou;
                }
                else
                {
                    model.JugyouRyou = 0;
                }
                kulasu.GakuseiSuo = model.GakuseiSuo;

                this._db.Entry(kulasu).State = System.Data.Entity.EntityState.Modified;

                this._db.SaveChanges();

                httpActionResult = Ok(new KulasuModel(kulasu));
            }

            return httpActionResult;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var listKulasu = this._db.Kulasu.Select(x => new KulasuModel()
            {
                Koudo = x.Koudo,
                Namae = x.Namae,
                JugyouRyou = x.JugyouRyou,
                GakuseiSuo = x.GakuseiSuo,
                Id = x.Id
            });

            return Ok(listKulasu);
        }
        [HttpGet]
        public IHttpActionResult GetById(long id)
        {
            IHttpActionResult httpActionResult;
            var kulasu = _db.Kulasu.FirstOrDefault(x => x.Id == id);

            if (kulasu == null)
            {
                ErrorModel errors = new ErrorModel();
                errors.Add("Không tìm thấy lớp");

                httpActionResult = Ok(errors);
            }
            else
            {
                httpActionResult = Ok(new KulasuModel(kulasu));
            }
            return httpActionResult;
        }

    }
}
