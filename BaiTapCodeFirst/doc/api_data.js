define({ "api": [
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
        "Error 4xx": [
          {
            "group": "Error 4xx",
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
  }
] });