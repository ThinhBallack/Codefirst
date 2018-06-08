define({ "api": [
  {
    "type": "Post",
    "url": "/Account/CreateUser",
    "title": "...Tạo một User mới",
    "group": "ACCOUNT______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "username",
            "description": "<p>...Tên User</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "password",
            "description": "<p>...password</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "email",
            "description": "<p>...Email cuả user</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n username:\"BANNUOC2018\",\n password: \"dmcongsan\",\n email: \"congsansucvat@mail.com\"\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "username",
            "description": "<p>...Tên User</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "password",
            "description": "<p>...Mật khẩu</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "email",
            "description": "<p>...Email của user</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n id :1,\n username:\"BANNUOC2018\",\n password: \"dmcongsan\",\n email: \"congsansucvat@mail.com\"\n \n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"username bắt buộc phải có.\",\n     \"passowrd bắt buộc phải có.\",\n     \"emails bắt buộc phải có.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/AccountController.cs",
    "groupTitle": "ACCOUNT______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "PostAccountCreateuser"
  },
  {
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "optional": false,
            "field": "varname1",
            "description": "<p>No type.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "varname2",
            "description": "<p>With type.</p>"
          }
        ]
      }
    },
    "type": "",
    "url": "",
    "version": "0.0.0",
    "filename": "./doc/main.js",
    "group": "C__Users_QUANGCOMPUTER_Documents_Visual_Studio_2015_Projects_Sources_BaiTapCodeFirst_BaiTapCodeFirst_doc_main_js",
    "groupTitle": "C__Users_QUANGCOMPUTER_Documents_Visual_Studio_2015_Projects_Sources_BaiTapCodeFirst_BaiTapCodeFirst_doc_main_js",
    "name": ""
  },
  {
    "type": "Get",
    "url": "/Gakusei/GetAll",
    "title": "... lấy tất cả sinh viên",
    "group": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...giới tính của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>... ngày sinh</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>... địa chỉ của sinh viên</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n GakuseiKoudo: \"D12CQCN01\",\n Namae: \"Trọng lú bán nước\",\n Seibetsu: \"Súc sinh\",\n Tanjoubi: 12/2/1987,\n Juusho: \"chuồng chó trung cộng\"\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Không có gì cả.\"\n     \"Something was wrong.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/GakuseiController.cs",
    "groupTitle": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "GetGakuseiGetall"
  },
  {
    "type": "Get",
    "url": "/Gakusei/GetById/:id",
    "title": "... lấy sinh viên theo id",
    "group": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "long",
            "optional": false,
            "field": "id",
            "description": "<p>...ID của sinh viên cần lấy ra</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n Id :1\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...giới tính của sinh viên</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>... ngày sinh</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>... địa chỉ của sinh viên</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n GakuseiKoudo: \"D12CQCN01\",\n Namae: \"Trọng lú bán nước\",\n Seibetsu: \"Súc sinh\",\n Tanjoubi: 12/2/1987,\n Juusho: \"chuồng chó trung cộng\"\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Không có gì cả.\"\n     \"Something was wrong.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/GakuseiController.cs",
    "groupTitle": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "GetGakuseiGetbyidId"
  },
  {
    "type": "Post",
    "url": "/Gakusei/CreateGakusei",
    "title": "...tạo một học sinh mới",
    "group": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của học sinh mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã học sinh</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n Namae: \"Tèo Thị Ngân\",\n Seibetsu: \"Nữ\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Đảng Cộng sản bán nước\",\n GakuseiKoudo: \"1511HFG12\"\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của học sinh mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của học sinh mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã học sinh</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n Namae: \"Tèo Thị Ngân\",\n Seibetsu: \"Nữ\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Đảng Cộng sản bán nước\",\n GakuseiKoudo: \"1511HFG12\"\n \n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Namae của học sinh bắt buộc phải có.\",\n     \"Seibetsu của học sinh là bắt buộc phải có.\",\n     \"Tanjoubi của học sinh là bắt buộc phải có.\",\n     \"Juusho của học sinh là bắt buộc phải có.\",\n     \"GakuseiKoudo của học sinh là bắt buộc phải có.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/GakuseiController.cs",
    "groupTitle": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "PostGakuseiCreategakusei"
  },
  {
    "type": "Put",
    "url": "/Gakusei/UpdateGakusei",
    "title": "...cập nhật học sinh",
    "group": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của học sinh mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "DateTime",
            "optional": true,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của học sinh vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của học sinh mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã học sinh</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n Id :1,\n Namae: \"Tèo Thị Ngân\",\n Seibetsu: \"Nữ\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Đảng Cộng sản bán nước\",\n GakuseiKoudo: \"1511HFG12\"\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của học sinh mới cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của học sinh vừa mới cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của học sinh vừa mới cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của học sinh vừa mới cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của học sinh cần được được cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã học sinh vừa mới cập nhật</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n Namae: \"Tèo Thị Ngân\",\n Seibetsu: \"Nữ\",\n Tanjoubi: 2/12/1992,\n Juusho: \"mất mẹ nước rồi còn đâu địa chỉ mà ghi\",\n GakuseiKoudo: \"1511HFG12\"\n \n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Namae của học sinh bắt buộc phải có.\",\n     \"Seibetsu của học sinh là bắt buộc phải có.\",\n     \"Tanjoubi của học sinh là bắt buộc phải có.\",\n     \"Juusho của học sinh là bắt buộc phải có.\",\n     \"GakuseiKoudo của học sinh là bắt buộc phải có.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/GakuseiController.cs",
    "groupTitle": "GAKUSEI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "PutGakuseiUpdategakusei"
  },
  {
    "type": "Get",
    "url": "/Koushi/GetAll",
    "title": "... lấy tất cả sinh viên",
    "group": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "SenseiKoudo",
            "description": "<p>...Mã giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "DenwaBango",
            "description": "<p>...Số điện thoại của giáo viên</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n SenseiKoudo:\"BANNUOC2018\",\n Namae: \"Trần Fuck\",\n Seibetsu: \"Nam\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Thằng ngu làm lãnh đạo\",\n DenwaBango: \"0498359475\"\n}\n\n\n (Error 400) {string[]} Errors ...mảng các lỗi",
          "type": "json"
        }
      ]
    },
    "error": {
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Không có gì cả.\"\n     \"Something was wrong.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KoushiController.cs",
    "groupTitle": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "GetKoushiGetall"
  },
  {
    "type": "Get",
    "url": "/Koushi/GetById/:id",
    "title": "... lấy tất cả giáo viên",
    "group": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "long",
            "optional": false,
            "field": "id",
            "description": "<p>...Mã giáo viên cần lấy</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n  Id :1\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "SenseiKoudo",
            "description": "<p>...Mã giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của giáo viên</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "DenwaBango",
            "description": "<p>...Số điện thoại của giáo viên</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n SenseiKoudo:\"BANNUOC2018\",\n Namae: \"Trần Fuck\",\n Seibetsu: \"Nam\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Thằng ngu làm lãnh đạo\",\n DenwaBango: \"0498359475\"\n}\n\n\n (Error 400) {string[]} Errors ...mảng các lỗi",
          "type": "json"
        }
      ]
    },
    "error": {
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Không tìm thấy giáo viên cần tìm.\"\n     \"Something was wrong.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KoushiController.cs",
    "groupTitle": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "GetKoushiGetbyidId"
  },
  {
    "type": "Post",
    "url": "/Koushi/CreateKoushi",
    "title": "...tạo một giáo viên mới",
    "group": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "SenseiKoudo",
            "description": "<p>...Tên của giáo viên mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của giáo viên mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "DateTime",
            "optional": true,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã giáo viên</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n SenseiKoudo:\"BANNUOC2018\",\n Namae: \"Trần Fuck\",\n Seibetsu: \"Nam\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Thằng ngu làm lãnh đạo\",\n DenwaBango: \"0498359475\"\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "SenseiKoudo",
            "description": "<p>...Mã giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của giáo viên mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của giáo viên mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "DenwaBango",
            "description": "<p>...Số điện thoại của giáo viên mới tạo</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n SenseiKoudo:\"BANNUOC2018\",\n Namae: \"Trần Fuck\",\n Seibetsu: \"Nam\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Thằng ngu làm lãnh đạo\",\n DenwaBango: \"0498359475\"\n \n}\n\n\n (Error 400) {string[]} Errors ...mảng các lỗi",
          "type": "json"
        }
      ]
    },
    "error": {
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Namae của giáo viên bắt buộc phải có.\",\n     \"SenseiKoudo của giáo viên là bắt buộc phải có.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KoushiController.cs",
    "groupTitle": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "PostKoushiCreatekoushi"
  },
  {
    "type": "Put",
    "url": "/Koushi/UpdateKoushi",
    "title": "...Cập nhật một giáo viên mới",
    "group": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "long",
            "optional": false,
            "field": "id",
            "description": "<p>...ID của giáo viên cần cập nhất</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "SenseiKoudo",
            "description": "<p>...Tên của giáo viên mới cập nhật</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Namae",
            "description": "<p>...Tên của giáo viên mới cập nhật</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của giáo viên vừa mới cập nhật</p>"
          },
          {
            "group": "Parameter",
            "type": "DateTime",
            "optional": true,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của giáo viên vừa mới cập nhật</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của giáo viên vừa mới cập nhật</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "GakuseiKoudo",
            "description": "<p>...Mã giáo viên</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n Id :1,\n SenseiKoudo:\"BANNUOC2018\",\n Namae: \"Trần Fuck\",\n Seibetsu: \"Nam\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Thằng ngu làm lãnh đạo\",\n DenwaBango: \"0498359475\"\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "SenseiKoudo",
            "description": "<p>...Mã giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của giáo viên mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Seibetsu",
            "description": "<p>...Giới tính của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "Tanjoubi",
            "description": "<p>...Ngày sinh của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của giáo viên mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Juusho",
            "description": "<p>...Địa chỉ của giáo viên vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "DenwaBango",
            "description": "<p>...Số điện thoại của giáo viên mới tạo</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n SenseiKoudo:\"BANNUOC2018\",\n Namae: \"Trần Fuck\",\n Seibetsu: \"Nam\",\n Tanjoubi: 2/12/1992,\n Juusho: \"Thằng ngu làm lãnh đạo\",\n DenwaBango: \"0498359475\"\n \n}\n\n\n (Error 400) {string[]} Errors ...mảng các lỗi",
          "type": "json"
        }
      ]
    },
    "error": {
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n  \"Không tìm thấy id của giáo viên cần cập nhật.\",\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KoushiController.cs",
    "groupTitle": "KOUSHI______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "PutKoushiUpdatekoushi"
  },
  {
    "type": "Get",
    "url": "/Kulasu/GetAll",
    "title": "... lấy tất cả danh sách lớp",
    "group": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Koudo",
            "description": "<p>...Mã của Kulasu</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của Kulasu</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của Kulasu</p>"
          },
          {
            "group": "Success 200",
            "type": "double",
            "optional": false,
            "field": "JugyouRyou",
            "description": "<p>...học phí của lớp</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "GakuseiSuo",
            "description": "<p>... sĩ số của lớp</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n Koudo: \"D12CQCN01\",\n Namae: \"Công nghệ thông tin 1\",\n JugyouRyou: 5000000,\n GakuseiSuo: 20\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Không có gì cả.\"\n     \"Something was wrong.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KulasuController.cs",
    "groupTitle": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "GetKulasuGetall"
  },
  {
    "type": "Get",
    "url": "/Kulasu/GetById/:id",
    "title": "... lấy ra lớp theo id",
    "group": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "int",
            "optional": false,
            "field": "id",
            "description": "<p>lớp cần lấy</p>"
          }
        ]
      }
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Koudo",
            "description": "<p>...Mã của Kulasu</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của Kulasu</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của Kulasu</p>"
          },
          {
            "group": "Success 200",
            "type": "double",
            "optional": false,
            "field": "JugyouRyou",
            "description": "<p>...học phí của lớp</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "GakuseiSuo",
            "description": "<p>... sĩ số của lớp</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n Koudo: \"D12CQCN01\",\n Namae: \"Công nghệ thông tin 1\",\n JugyouRyou: 5000000,\n GakuseiSuo: 20\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Không tìm thấy.\"\n     \"ID không tồn tại.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KulasuController.cs",
    "groupTitle": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "GetKulasuGetbyidId"
  },
  {
    "type": "Post",
    "url": "/Kulasu/CreateKulasu",
    "title": "...tạo một Kulasu mới",
    "group": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Koudo",
            "description": "<p>Mã của kulasu mới</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>Tên của lớp mới</p>"
          },
          {
            "group": "Parameter",
            "type": "double",
            "optional": true,
            "field": "JugyouRyou",
            "description": "<p>học phí của lớp, optional</p>"
          },
          {
            "group": "Parameter",
            "type": "int",
            "optional": true,
            "field": "GakuseiSuo",
            "description": "<p>sĩ số của lớ optional</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n Koudo: \"D12CQCN01\",\n Namae: \"Công nghệ thông tin 1\"\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Koudo",
            "description": "<p>...Mã của Kulasu vừa mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của Kulasu mới tạo</p>"
          },
          {
            "group": "Success 200",
            "type": "long",
            "optional": false,
            "field": "Id",
            "description": "<p>...Id của Kulasu mới tạo</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n Koudo: \"D12CQCN01\",\n Namae: \"Công nghệ thông tin 1\"\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Koudo của Kulasu là bắt buộc phải có.\",\n     \"Namae của Kulasu là bắt buộc phải có.\"\n ]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KulasuController.cs",
    "groupTitle": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "PostKulasuCreatekulasu"
  },
  {
    "type": "Put",
    "url": "/Kulasu/UpdateKulasu",
    "title": "...cập nhật một Kulasu",
    "group": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "permission": [
      {
        "name": "none ...nếu không có nghĩa là permission none. /optional"
      }
    ],
    "version": "1.0.0",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "long",
            "optional": false,
            "field": "id",
            "description": "<p>Id của lớp cần sửa</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Koudo",
            "description": "<p>Mã của lớp cấn sửa /optional</p>"
          },
          {
            "group": "Parameter",
            "type": "string",
            "optional": true,
            "field": "Namae",
            "description": "<p>Tên của lớp cần sửa /optional</p>"
          },
          {
            "group": "Parameter",
            "type": "double",
            "optional": true,
            "field": "JugyouRyou",
            "description": "<p>học phí của lớp cần sửa /optional</p>"
          },
          {
            "group": "Parameter",
            "type": "int",
            "optional": true,
            "field": "GakuseiSuo",
            "description": "<p>sĩ số của lớp /optional</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Request-Example:",
          "content": "{\n Id: 2,\n Koudo: \"D12CQCN01\",\n Namae: \"Công nghệ thông tin 1\",\n JugyouRyou: 5000000,\n GakuseiSuo: 20\n}",
          "type": "json"
        }
      ]
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Koudo",
            "description": "<p>...Mã của Kulasu vừa mới cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "string",
            "optional": false,
            "field": "Namae",
            "description": "<p>...Tên của Kulasu mới cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "double",
            "optional": false,
            "field": "JugyouRyou",
            "description": "<p>... Học phí của một lớp vừa mới cập nhật</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "GakuseiSuo",
            "description": "<p>... Sĩ số của lớp vừa mới được cập nhật</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Reponse:",
          "content": "{\n Id :1,\n Koudo: \"D12CQCN01\",\n Namae: \"Công nghệ thông tin 1\",\n JugyouRyou: 5000000,\n GakuseiSuo: 30\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 400": [
          {
            "group": "Error 400",
            "type": "string[]",
            "optional": false,
            "field": "Errors",
            "description": "<p>...mảng các lỗi</p>"
          }
        ]
      },
      "examples": [
        {
          "title": ": {json}",
          "content": "{\n \"Errors\": [\n     \"Id của Kulasu là bắt buộc phải có.\",\n\n]\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Controllers/KulasuController.cs",
    "groupTitle": "KUALSU______nh_ngh_a_api_thu_c_nh_m_n_o__n_n_c___optional",
    "name": "PutKulasuUpdatekulasu"
  }
] });
