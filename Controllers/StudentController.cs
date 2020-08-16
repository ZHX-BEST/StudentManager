using StudentManager.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudentManager.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students=new List<Student>()
        {
            new Student(){id=1,age=17,name="张三" },
            new Student(){id=2,age=18,name="李四" },
            new Student(){id=3,age=19,name="王五" }
        };

        // GET: Student
        //ActionResult-->ViewResult-->ViewResultBase

        
        public ActionResult Index()
        {
            //return View();//默认情况返回与动作方法同名的视图（View文件夹下与控制器同名的目录下）
            //return View("NoIndex");//启动Views文件夹下与当前控制器同名的文件夹中的对应视图
            return View("~/Views/Home/About.cshtml");//启动其他目录下的视图--输入完整路径名
        }

        /// <summary>
        /// 给动作方法传值
        /// /Student/Student/xxx 默认传参方式，只有参数为id的时候可以用
        /// /Student/Student?yyy=xxx 标准传参格式
        /// 默认参数:Student(type yyy=xxx)
        /// 参数可空:Student(type？ yyy)
        /// 多参数传递:Student/Student?y1=x1&y2=x2
        /// </summary>
        /// <returns></returns>
        public JsonResult Student(int id,int age,string name)
        {
            JsonResult json = new JsonResult()
            {
                Data = new
                {
                    Id = id,
                    Age = age,
                    Name = name
                },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
            return json;
        }
        #region Action传递数据到视图（ViewBag/Model）
        public ActionResult Create()
        {
            ViewBag.viewName = "创建";
            return View();
        }
        //ViewBag--dynamic类型编译不检查类型，运行时检查，也常用于传递下拉列表，自定义属性（viewName），没有智能提示
        //model强类型传值--优点是可以传递大量的复杂的数据，有智能提示
        //ViewData字典传值
        //TempData跨控制器传值，临时数据放在Session中，使用一次就删除
        public ActionResult studentlist()
        {
            ViewBag.stulist = students;//viewbag传值
            ViewData["Student"] = students[1];  //ViewData字典传值
            TempData["tip"] = "这里是TempData";
            return RedirectToAction("TempDataShow");            
        }
        /// <summary>
        /// TempData跨控制器传值
        /// 值独立，作为临时数据存放在session中
        /// </summary>
        /// <returns></returns>
        public ActionResult TempDataShow()
        {
            return View();
        }
        #endregion

    }
}