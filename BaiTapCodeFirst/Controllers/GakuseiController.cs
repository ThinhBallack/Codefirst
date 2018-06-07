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

        /**
        * @api {Post} /Kulasu/CreateGakusei ...tạo một học sinh mới
        * @apigroup GAKUSEI ...định nghĩa api thuộc nhóm nào, nên có /optional
        * @apiPermission none ...nếu không có nghĩa là permission none. /optional
        * @apiVersion 1.0.0
        * 
        * @apiParam {string} Namae ...Tên của học sinh mới tạo
        * @apiParam  {string} Seibetsu ...Giới tính của học sinh vừa mới tạo
        * @apiParam  {DateTime} Tanjoubi ...Ngày sinh của học sinh vừa mới tạo
        * @apiParam  {string} Juusho ...Địa chỉ của học sinh vừa mới tạo
        * @apiParam {long} Id ...Id của học sinh mới tạo
        * @apiParam {string} GakuseiKoudo ...Mã học sinh
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
        * @apiError {string[]} Errors ...mảng các lỗi
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
                httpActionResult = Ok(errors);
            }

            return httpActionResult;
        }
        /**
        * @api {Put} /Kulasu/UpdateGakusei ...cập nhật học sinh
        * @apigroup GAKUSEI ...định nghĩa api thuộc nhóm nào, nên có /optional
        * @apiPermission none ...nếu không có nghĩa là permission none. /optional
        * @apiVersion 1.0.0
        * 
        * @apiParam {string} Namae ...Tên của học sinh mới tạo
        * @apiParam  {string} Seibetsu ...Giới tính của học sinh vừa mới tạo
        * @apiParam  {DateTime} Tanjoubi ...Ngày sinh của học sinh vừa mới tạo
        * @apiParam  {string} Juusho ...Địa chỉ của học sinh vừa mới tạo
        * @apiParam {long} Id ...Id của học sinh mới tạo
        * @apiParam {string} GakuseiKoudo ...Mã học sinh
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
        * @apiError {string[]} Errors ...mảng các lỗi
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
