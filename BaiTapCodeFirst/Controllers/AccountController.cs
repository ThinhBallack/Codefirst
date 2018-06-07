using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using BaiTapCodeFirst.Models;
using BaiTapCodeFirst.Providers;
using BaiTapCodeFirst.Results;
using BaiTapCodeFirst.Infrastructure;
using CodeFirst;
using BaiTapCodeFirst.ViewModels;
using System.Linq;

namespace BaiTapCodeFirst.Controllers
{
    public class AccountsController : ApiController
    {
        private ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;
        private YuriSentaa db;

        public AccountsController(ApplicationUserManager userManager, ApplicationRoleManager roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            db = new YuriSentaa();
        }

        [HttpPost]
        public IHttpActionResult CreateUser(CreateAccountModel acc)
        {
            IHttpActionResult httpActionResult;

            Account account = new Account()
            {
                UserName = acc.username,
                Email = acc.email,
            };

            IdentityResult result = _userManager.Create(account, acc.password);

            /*
             * 
             */
            if (!result.Succeeded)
            {
                ErrorModel error = new ErrorModel();

                error.Errors = result.Errors.ToList();

                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, error);
            }
            else
            {
                var result_2 = _userManager.AddToRole(account.Id, "User");

                if (!result_2.Succeeded)
                {
                    ErrorModel error = new ErrorModel();

                    error.Errors = result.Errors.ToList();

                    httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, error);
                }
                else
                {

                    AccountModel accountModel = new AccountModel(account);

                    httpActionResult = Ok(accountModel);
                }
            }

            return httpActionResult;
        }
    }
}
