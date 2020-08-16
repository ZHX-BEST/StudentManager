using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManager.Controllers
{
    //MVC：M(Models)——数据传递;V(Views)——视图(显示的内容);C(Controller)——控制器(决定我们是用哪个视图和逻辑)

    //控制器—>动作方法—>视图
    #region 控制器的创建与动作方法的返回值StudentController
    //1·约定优于配置
    //2·创建控制器
    //3·动作方法返回值
    #endregion//动作方法Action控制视图
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}