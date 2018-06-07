using CodeFirst;
using Autofac;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BaiTapCodeFirst.Infrastructure;


namespace BaiTapCodeFirst.Modules
{
    public class EFModules: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(YuriSentaa)).As(typeof(DbContext)).InstancePerLifetimeScope();

            builder.Register<ApplicationUserManager>(c => HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>()).InstancePerRequest();
            builder.Register<ApplicationRoleManager>(c => HttpContext.Current.GetOwinContext().GetUserManager<ApplicationRoleManager>()).InstancePerRequest();
        }
    }
}