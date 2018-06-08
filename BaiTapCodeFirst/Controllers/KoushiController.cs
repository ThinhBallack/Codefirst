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
    public class KoushiController : ApiController
    {
        private YuriSentaa _db;
        public KoushiController()
        {
            this._db = new YuriSentaa();
        }

        /**
        * @api {Post} /Koushi/CreateKoushi ...tạo một giáo viên mới
        * @apigroup KOUSHI ...định nghĩa api thuộc nhóm nào, nên có /optional
        * @apiPermission none ...nếu không có nghĩa là permission none. /optional
        * @apiVersion 1.0.0
        * 
        * @apiParam {string} SenseiKoudo ...Tên của giáo viên mới tạo
        * @apiParam {string} Namae ...Tên của giáo viên mới tạo
        * @apiParam  {string} [Seibetsu] ...Giới tính của giáo viên vừa mới tạo
        * @apiParam  {DateTime} [Tanjoubi] ...Ngày sinh của giáo viên vừa mới tạo
        * @apiParam  {string} [Juusho] ...Địa chỉ của giáo viên vừa mới tạo
        * @apiParam {string} [GakuseiKoudo] ...Mã giáo viên
        * 
        *@apiParamExample {json} Request-Example:
        * {
        *  SenseiKoudo:"BANNUOC2018",
        *  Namae: "Trần Fuck",
        *  Seibetsu: "Nam",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Thằng ngu làm lãnh đạo",
        *  DenwaBango: "0498359475"
        *}
        * 
        * 
        * @apiSuccess {string} SenseiKoudo ...Mã giáo viên vừa mới tạo
        * @apiSuccess {string} Namae ...Tên của giáo viên mới tạo
        * @apiSuccess {string} Seibetsu ...Giới tính của giáo viên vừa mới tạo
        * @apiSuccess {DateTime} Tanjoubi ...Ngày sinh của giáo viên vừa mới tạo
        * @apiSuccess {long} Id ...Id của giáo viên mới tạo
        * @apiSuccess {string} Juusho ...Địa chỉ của giáo viên vừa mới tạo
        * @apiSuccess {string} DenwaBango ...Số điện thoại của giáo viên mới tạo
        * 
        * @apiSuccessExample {json} Reponse:
        * {
        *  Id :1,
        *  SenseiKoudo:"BANNUOC2018",
        *  Namae: "Trần Fuck",
        *  Seibetsu: "Nam",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Thằng ngu làm lãnh đạo",
        *  DenwaBango: "0498359475"
        *  
        * }
        * 
        * 
        *  (Error 400) {string[]} Errors ...mảng các lỗi
        * 
        * @apiErrorExample: {json}
        * {
        *  "Errors": [
        *      "Namae của giáo viên bắt buộc phải có.",
        *      "SenseiKoudo của giáo viên là bắt buộc phải có."
        *  ]
        * }
        * 
        */
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
                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
            }

            return httpActionResult;
        }
        /**
        * @api {Put} /Koushi/UpdateKoushi ...Cập nhật một giáo viên mới
        * @apigroup KOUSHI ...định nghĩa api thuộc nhóm nào, nên có /optional
        * @apiPermission none ...nếu không có nghĩa là permission none. /optional
        * @apiVersion 1.0.0
        * 
        * @apiParam {long} id ...ID của giáo viên cần cập nhất
        * @apiParam {string} [SenseiKoudo] ...Tên của giáo viên mới cập nhật
        * @apiParam {string} [Namae] ...Tên của giáo viên mới cập nhật
        * @apiParam  {string} [Seibetsu] ...Giới tính của giáo viên vừa mới cập nhật
        * @apiParam  {DateTime} [Tanjoubi] ...Ngày sinh của giáo viên vừa mới cập nhật
        * @apiParam  {string} [Juusho] ...Địa chỉ của giáo viên vừa mới cập nhật
        * @apiParam {string} [GakuseiKoudo] ...Mã giáo viên
        * 
        *@apiParamExample {json} Request-Example:
        * {
        *  Id :1,
        *  SenseiKoudo:"BANNUOC2018",
        *  Namae: "Trần Fuck",
        *  Seibetsu: "Nam",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Thằng ngu làm lãnh đạo",
        *  DenwaBango: "0498359475"
        *}
        * 
        * 
        * @apiSuccess {string} SenseiKoudo ...Mã giáo viên vừa mới tạo
        * @apiSuccess {string} Namae ...Tên của giáo viên mới tạo
        * @apiSuccess {string} Seibetsu ...Giới tính của giáo viên vừa mới tạo
        * @apiSuccess {DateTime} Tanjoubi ...Ngày sinh của giáo viên vừa mới tạo
        * @apiSuccess {long} Id ...Id của giáo viên mới tạo
        * @apiSuccess {string} Juusho ...Địa chỉ của giáo viên vừa mới tạo
        * @apiSuccess {string} DenwaBango ...Số điện thoại của giáo viên mới tạo
        * 
        * @apiSuccessExample {json} Reponse:
        * {
        *  Id :1,
        *  SenseiKoudo:"BANNUOC2018",
        *  Namae: "Trần Fuck",
        *  Seibetsu: "Nam",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Thằng ngu làm lãnh đạo",
        *  DenwaBango: "0498359475"
        *  
        * }
        * 
        * 
        *  (Error 400) {string[]} Errors ...mảng các lỗi
        * 
        * @apiErrorExample: {json}
        * {
        *  "Errors": [
        *   "Không tìm thấy id của giáo viên cần cập nhật.",
        *  ]
        * }
        * 
        */
        [HttpPut]
        public IHttpActionResult UpdateKoushi(UpdateKoushiModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            Koushi koushi = this._db.Koushi.FirstOrDefault(x => x.Id == model.Id);

            if (koushi == null)
            {
                errors.Add("Không tìm thấy giáo viên");

                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
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
        /**
         * @api {Get} /Koushi/GetAll ... lấy tất cả sinh viên
         * @apigroup KOUSHI ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * 
         * 
        * @apiSuccess {string} SenseiKoudo ...Mã giáo viên
        * @apiSuccess {string} Namae ...Tên của giáo viên
        * @apiSuccess {string} Seibetsu ...Giới tính của giáo viên
        * @apiSuccess {DateTime} Tanjoubi ...Ngày sinh của giáo viên
        * @apiSuccess {long} Id ...Id của giáo viên
        * @apiSuccess {string} Juusho ...Địa chỉ của giáo viên
        * @apiSuccess {string} DenwaBango ...Số điện thoại của giáo viên
         * 
         * @apiSuccessExample {json} Reponse:
         * {
        *  Id :1,
        *  SenseiKoudo:"BANNUOC2018",
        *  Namae: "Trần Fuck",
        *  Seibetsu: "Nam",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Thằng ngu làm lãnh đạo",
        *  DenwaBango: "0498359475"
         * }
         * 
         * 
         *  (Error 400) {string[]} Errors ...mảng các lỗi
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
        /**
         * @api {Get} /Koushi/GetById/:id ... lấy tất cả giáo viên
         * @apigroup KOUSHI ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * @apiParam {long} id ...Mã giáo viên cần lấy
         * @apiParamExample {json} Request-Example:
         * {
         *   Id :1
         * }
         * 
         * @apiSuccess {string} SenseiKoudo ...Mã giáo viên
         * @apiSuccess {string} Namae ...Tên của giáo viên
         * @apiSuccess {string} Seibetsu ...Giới tính của giáo viên
         * @apiSuccess {DateTime} Tanjoubi ...Ngày sinh của giáo viên
         * @apiSuccess {long} Id ...Id của giáo viên
         * @apiSuccess {string} Juusho ...Địa chỉ của giáo viên
         * @apiSuccess {string} DenwaBango ...Số điện thoại của giáo viên
         * 
         * @apiSuccessExample {json} Reponse:
         * {
         *  Id :1,
         *  SenseiKoudo:"BANNUOC2018",
         *  Namae: "Trần Fuck",
         *  Seibetsu: "Nam",
         *  Tanjoubi: 2/12/1992,
         *  Juusho: "Thằng ngu làm lãnh đạo",
         *  DenwaBango: "0498359475"
         * }
         * 
         * 
         *  (Error 400) {string[]} Errors ...mảng các lỗi
         * 
         * @apiErrorExample: {json}
         * {
         *  "Errors": [
         *      "Không tìm thấy giáo viên cần tìm."
         *      "Something was wrong."
         *  ]
         * }
         * 
         */
        [HttpGet]
        public IHttpActionResult GetById(long id)
        {
            IHttpActionResult httpActionResult;
            var koushi = _db.Koushi.FirstOrDefault(x => x.Id == id);

            if (koushi == null)
            {
                ErrorModel errors = new ErrorModel();
                errors.Add("Không tìm thấy giáo viên");

                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
            }
            else
            {
                httpActionResult = Ok(new KoushiModel(koushi));
            }
            return httpActionResult;
        }

    }
}
