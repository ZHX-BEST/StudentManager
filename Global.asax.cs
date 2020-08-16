using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StudentManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 应用程序开始的地方
        /// 应用程序初始化
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();//注册区域
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//注册全局过滤
            RouteConfig.RegisterRoutes(RouteTable.Routes);//注册路由
            BundleConfig.RegisterBundles(BundleTable.Bundles);//注册打包器
        }
    }
}
