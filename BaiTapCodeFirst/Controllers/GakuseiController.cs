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
    public class GakuseiController : ApiController
    {
        private YuriSentaa _db;
        public GakuseiController()
        {
            this._db = new YuriSentaa();
        }

        /**
        * @api {Post} /Gakusei/CreateGakusei ...tạo một học sinh mới
        * @apigroup GAKUSEI ...định nghĩa api thuộc nhóm nào, nên có /optional
        * @apiPermission none ...nếu không có nghĩa là permission none. /optional
        * @apiVersion 1.0.0
        * 
        * @apiParam {string} Namae ...Tên của học sinh mới tạo
        * @apiParam  {string} Seibetsu ...Giới tính của học sinh vừa mới tạo
        * @apiParam  {DateTime} Tanjoubi ...Ngày sinh của học sinh vừa mới tạo
        * @apiParam  {string} Juusho ...Địa chỉ của học sinh vừa mới tạo
        * @apiParam {string} GakuseiKoudo ...Mã học sinh
        * 
        *@apiParamExample {json} Request-Example:
        * {
        *  Namae: "Tèo Thị Ngân",
        *  Seibetsu: "Nữ",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Đảng Cộng sản bán nước",
        *  GakuseiKoudo: "1511HFG12"
        *}
        * 
        * 
        * @apiSuccess {string} Namae ...Tên của học sinh mới tạo
        * @apiSuccess  {string} Seibetsu ...Giới tính của học sinh vừa mới tạo
        * @apiSuccess  {DateTime} Tanjoubi ...Ngày sinh của học sinh vừa mới tạo
        * @apiSuccess  {string} Juusho ...Địa chỉ của học sinh vừa mới tạo
        * @apiSuccess {long} Id ...Id của học sinh mới tạo
        * @apiSuccess {string} GakuseiKoudo ...Mã học sinh
        * 
        * @apiSuccessExample {json} Reponse:
        * {
        *  Id :1,
        *  Namae: "Tèo Thị Ngân",
        *  Seibetsu: "Nữ",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Đảng Cộng sản bán nước",
        *  GakuseiKoudo: "1511HFG12"
        *  
        * }
        * 
        * 
        * @apiError (Error 400) {string[]} Errors ...mảng các lỗi
        * 
        * @apiErrorExample: {json}
        * {
        *  "Errors": [
        *      "Namae của học sinh bắt buộc phải có.",
        *      "Seibetsu của học sinh là bắt buộc phải có.",
        *      "Tanjoubi của học sinh là bắt buộc phải có.",
        *      "Juusho của học sinh là bắt buộc phải có.",
        *      "GakuseiKoudo của học sinh là bắt buộc phải có."
        *  ]
        * }
        * 
        */
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
                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
            }

            return httpActionResult;
        }
        /**
        * @api {Put} /Gakusei/UpdateGakusei ...cập nhật học sinh
        * @apigroup GAKUSEI ...định nghĩa api thuộc nhóm nào, nên có /optional
        * @apiPermission none ...nếu không có nghĩa là permission none. /optional
        * @apiVersion 1.0.0
        * 
        * @apiParam {string} Namae ...Tên của học sinh mới tạo
        * @apiParam {string} [Seibetsu] ...Giới tính của học sinh vừa mới tạo
        * @apiParam {DateTime} [Tanjoubi] ...Ngày sinh của học sinh vừa mới tạo
        * @apiParam {string} Juusho ...Địa chỉ của học sinh vừa mới tạo
        * @apiParam {long} Id ...Id của học sinh mới tạo
        * @apiParam {string} [GakuseiKoudo] ...Mã học sinh
        * 
        *@apiParamExample {json} Request-Example:
        * {
        *  Id :1,
        *  Namae: "Tèo Thị Ngân",
        *  Seibetsu: "Nữ",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "Đảng Cộng sản bán nước",
        *  GakuseiKoudo: "1511HFG12"
        *}
        * 
        * 
        * @apiSuccess {string} Namae ...Tên của học sinh mới cập nhật
        * @apiSuccess  {string} Seibetsu ...Giới tính của học sinh vừa mới cập nhật
        * @apiSuccess  {DateTime} Tanjoubi ...Ngày sinh của học sinh vừa mới cập nhật
        * @apiSuccess  {string} Juusho ...Địa chỉ của học sinh vừa mới cập nhật
        * @apiSuccess {long} Id ...Id của học sinh cần được được cập nhật
        * @apiSuccess {string} GakuseiKoudo ...Mã học sinh vừa mới cập nhật
        * 
        * @apiSuccessExample {json} Reponse:
        * {
        *  Id :1,
        *  Namae: "Tèo Thị Ngân",
        *  Seibetsu: "Nữ",
        *  Tanjoubi: 2/12/1992,
        *  Juusho: "mất mẹ nước rồi còn đâu địa chỉ mà ghi",
        *  GakuseiKoudo: "1511HFG12"
        *  
        * }
        * 
        * 
        * @apiError (Error 400) {string[]} Errors ...mảng các lỗi
        * 
        * @apiErrorExample: {json}
        * {
        *  "Errors": [
        *      "Namae của học sinh bắt buộc phải có.",
        *      "Seibetsu của học sinh là bắt buộc phải có.",
        *      "Tanjoubi của học sinh là bắt buộc phải có.",
        *      "Juusho của học sinh là bắt buộc phải có.",
        *      "GakuseiKoudo của học sinh là bắt buộc phải có."
        *  ]
        * }
        * 
        */
        [HttpPut]
        public IHttpActionResult UpdateGakusei(UpdateGakuseiModel model)
        {
            IHttpActionResult httpActionResult;
            ErrorModel errors = new ErrorModel();

            Gakusei gakusei = this._db.Gakusei.FirstOrDefault(x => x.Id == model.Id);

            if (gakusei == null)
            {
                errors.Add("Không tìm thấy học sinh");

                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
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
        /**
         * @api {Get} /Gakusei/GetAll ... lấy tất cả sinh viên
         * @apigroup GAKUSEI ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * 
         * 
         * @apiSuccess  {string} GakuseiKoudo ...Mã của sinh viên
         * @apiSuccess {string} Namae ...Tên của sinh viên
         * @apiSuccess {long} Id ...Id của sinh viên 
         * @apiSuccess {string} Seibetsu ...giới tính của sinh viên
         * @apiSuccess {DateTime} Tanjoubi ... ngày sinh
         * @apiSuccess {string} Juusho ... địa chỉ của sinh viên
         * 
         * @apiSuccessExample {json} Reponse:
         * {
         *  Id :1,
         *  GakuseiKoudo: "D12CQCN01",
         *  Namae: "Trọng lú bán nước",
         *  Seibetsu: "Súc sinh",
         *  Tanjoubi: 12/2/1987,
         *  Juusho: "chuồng chó trung cộng"
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
        /**
         * @api {Get} /Gakusei/GetById/:id ... lấy sinh viên theo id
         * @apigroup GAKUSEI ...định nghĩa api thuộc nhóm nào, nên có /optional
         * @apiPermission none ...nếu không có nghĩa là permission none. /optional
         * @apiVersion 1.0.0
         * 
         * @apiParam {long} id ...ID của sinh viên cần lấy ra
         * 
         * @apiParamExample {json} Request-Example:
         * {
         *  Id :1
         *}
         * 
         * @apiSuccess {string} GakuseiKoudo ...Mã của sinh viên
         * @apiSuccess {string} Namae ...Tên của sinh viên
         * @apiSuccess {long} Id ...Id của sinh viên 
         * @apiSuccess {string} Seibetsu ...giới tính của sinh viên
         * @apiSuccess {DateTime} Tanjoubi ... ngày sinh
         * @apiSuccess {string} Juusho ... địa chỉ của sinh viên
         * 
         * @apiSuccessExample {json} Reponse:
         * {
         *  Id :1,
         *  GakuseiKoudo: "D12CQCN01",
         *  Namae: "Trọng lú bán nước",
         *  Seibetsu: "Súc sinh",
         *  Tanjoubi: 12/2/1987,
         *  Juusho: "chuồng chó trung cộng"
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
        public IHttpActionResult GetById(long id)
        {
            IHttpActionResult httpActionResult;
            var gakusei = _db.Gakusei.FirstOrDefault(x => x.Id == id);

            if (gakusei == null)
            {
                ErrorModel errors = new ErrorModel();
                errors.Add("Không tìm thấy học sinh");

                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, errors);
            }
            else
            {
                httpActionResult = Ok(new GakuseiModel(gakusei));
            }
            return httpActionResult;
        }

    }
}
