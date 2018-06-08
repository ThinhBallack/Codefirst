using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeFirst;
using BaiTapCodeFirst.ViewModels;
using BaiTapCodeFirst.Infrastructure;

namespace BaiTapCodeFirst.Controllers
{
    public class KulasuController : ApiController
    {
        private YuriSentaa _db;
        public KulasuController()
        {
            this._db = new YuriSentaa();
        }


        /**
         * @api {Post} /Kulasu/CreateKulasu ...tạo một Kulasu mới
         * @apigroup KUALSU ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * @apiParam {string} Koudo Mã của kulasu mới
         * @apiParam {string} Namae Tên của lớp mới
         * @apiParam {double} [JugyouRyou] học phí của lớp, optional
         * @apiParam {int} [GakuseiSuo] sĩ số của lớ optional
         * 
         *@apiParamExample {json} Request-Example:
         * {
         *  Koudo: "D12CQCN01",
         *  Namae: "Công nghệ thông tin 1"
         *}
         * 
         * @apiSuccess  {string} Koudo ...Mã của Kulasu vừa mới tạo
         * @apiSuccess {string} Namae ...Tên của Kulasu mới tạo
         * @apiSuccess {long} Id ...Id của Kulasu mới tạo
         * 
         * @apiSuccessExample {json} Reponse:
         * {
         *  Id :1,
         *  Koudo: "D12CQCN01",
         *  Namae: "Công nghệ thông tin 1"
         * }
         * 
         * 
         * @apiError (Error 400) {string[]} Errors ...mảng các lỗi
         * 
         * @apiErrorExample: {json}
         * {
         *  "Errors": [
         *      "Koudo của Kulasu là bắt buộc phải có.",
         *      "Namae của Kulasu là bắt buộc phải có."
         *  ]
         * }
         * 
         */

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
                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
            }

            return httpActionResult;
        }
        /**
         * @api {Put} /Kulasu/UpdateKulasu ...cập nhật một Kulasu
         * @apigroup KUALSU ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * @apiParam {long} id Id của lớp cần sửa
         * @apiParam {string} [Koudo] Mã của lớp cấn sửa /optional
         * @apiParam {string} [Namae] Tên của lớp cần sửa /optional
         * @apiParam {double} [JugyouRyou] học phí của lớp cần sửa /optional
         * @apiParam {int} [GakuseiSuo] sĩ số của lớp /optional
         * 
         *@apiParamExample {json} Request-Example:
         * {
         *  Id: 2,
         *  Koudo: "D12CQCN01",
         *  Namae: "Công nghệ thông tin 1",
         *  JugyouRyou: 5000000,
         *  GakuseiSuo: 20
         *}
         * 
         * @apiSuccess  {string} Koudo ...Mã của Kulasu vừa mới cập nhật
         * @apiSuccess {string} Namae ...Tên của Kulasu mới cập nhật
         * @apiSuccess {double} JugyouRyou ... Học phí của một lớp vừa mới cập nhật
         * @apiSuccess {int} GakuseiSuo ... Sĩ số của lớp vừa mới được cập nhật
         * 
         * @apiSuccessExample {json} Reponse:
         * {
         *  Id :1,
         *  Koudo: "D12CQCN01",
         *  Namae: "Công nghệ thông tin 1",
         *  JugyouRyou: 5000000,
         *  GakuseiSuo: 30
         * }
         * 
         * 
         * @apiError (Error 400) {string[]} Errors ...mảng các lỗi
         * 
         * @apiErrorExample: {json}
         * {
         *  "Errors": [
         *      "Id của Kulasu là bắt buộc phải có.",
         *
         *]
         * }
         * 
         */
        [HttpPut]
        public IHttpActionResult UpdateKulasu(UpdateKulasuModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            Kulasu kulasu = this._db.Kulasu.FirstOrDefault(x => x.Id == model.Id);

            if (kulasu == null)
            {
                errors.Add("Không tìm thấy lớp");

                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
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
        /**
         * @api {Get} /Kulasu/GetAll ... lấy tất cả danh sách lớp
         * @apigroup KUALSU ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * 
         * 
         * @apiSuccess  {string} Koudo ...Mã của Kulasu 
         * @apiSuccess {string} Namae ...Tên của Kulasu 
         * @apiSuccess {long} Id ...Id của Kulasu 
         * @apiSuccess {double} JugyouRyou ...học phí của lớp
         * @apiSuccess {int} GakuseiSuo ... sĩ số của lớp
         * 
         * @apiSuccessExample {json} Reponse:
         * {
         *  Id :1,
         *  Koudo: "D12CQCN01",
         *  Namae: "Công nghệ thông tin 1",
         *  JugyouRyou: 5000000,
         *  GakuseiSuo: 20
         * }
         * 
         * 
         * @apiError (Error 400) {string[]} Errors ...mảng các lỗi
         * 
         * @apiErrorExample: {json}
         * {
         *  "Errors": [
         *      "Không có gì cả."
         *      "Something was wrong."
         *  ]
         * }
         * 
         */
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
        /**
         * @api {Get} /Kulasu/GetById/:id ... lấy ra lớp theo id
         * @apigroup KUALSU ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * @apiParam {int} id lớp cần lấy
         * 
         * @apiSuccess  {string} Koudo ...Mã của Kulasu 
         * @apiSuccess {string} Namae ...Tên của Kulasu 
         * @apiSuccess {long} Id ...Id của Kulasu 
         * @apiSuccess {double} JugyouRyou ...học phí của lớp
         * @apiSuccess {int} GakuseiSuo ... sĩ số của lớp
         * 
         * @apiSuccessExample {json} Reponse:
         * {
         *  Id :1,
         *  Koudo: "D12CQCN01",
         *  Namae: "Công nghệ thông tin 1",
         *  JugyouRyou: 5000000,
         *  GakuseiSuo: 20
         * }
         * 
         * 
         * @apiError (Error 400) {string[]} Errors ...mảng các lỗi
         * 
         * @apiErrorExample: {json}
         * {
         *  "Errors": [
         *      "Không tìm thấy."
         *      "ID không tồn tại."
         *  ]
         * }
         * 
         */
        [HttpGet]
        public IHttpActionResult GetById(long id)
        {
            IHttpActionResult httpActionResult;
            var kulasu = _db.Kulasu.FirstOrDefault(x => x.Id == id);

            if (kulasu == null)
            {
                ErrorModel errors = new ErrorModel();
                errors.Add("Không tìm thấy lớp");

                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
            }
            else
            {
                httpActionResult = Ok(new KulasuModel(kulasu));
            }
            return httpActionResult;
        }

    }
}
