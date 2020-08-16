using Microsoft.Ajax.Utilities;
using StudentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManager.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View(); 
        }
        /// <summary>
        /// 分布视图
        /// 1·用于局部更新
        /// 2·用于一个页面传递多个model
        /// </summary>
        /// <returns></returns>
        public ActionResult PartialViewDemo()
        {
            Student student = new Student();

            return PartialView(student);
        }
    }
}