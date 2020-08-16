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
        /// Ӧ�ó���ʼ�ĵط�
        /// Ӧ�ó����ʼ��
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();//ע������
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//ע��ȫ�ֹ���
            RouteConfig.RegisterRoutes(RouteTable.Routes);//ע��·��
            BundleConfig.RegisterBundles(BundleTable.Bundles);//ע������
        }
    }
}
