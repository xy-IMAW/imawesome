using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Text.RegularExpressions;
using IMAW.Model;
using IMAW.BLL;
using COMMON;

namespace imaw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //获取数据
            IMAW.BLL.newsBLL newbll = new IMAW.BLL.newsBLL();
            List<IMAW.Model.news> topnew = new List<IMAW.Model.news>(1);
            List<IMAW.Model.news> hotnew = new List<IMAW.Model.news>(3);
            COMMON.newsdeal newsdeal = new newsdeal();

            //封装viewbag
            topnew = newbll.GetModelList("news_state = 0");
            ViewBag.topnew_title = topnew[0].news_title;
            ViewBag.topnew_abstract = topnew[0].news_abstract;
            ViewBag.topnew_imgurl = newsdeal.getimgurl(topnew[0].news_content);

            hotnew = newbll.GetModelList("news_state = 1");
            ViewBag.hotnew1_title = hotnew[0].news_title;
            ViewBag.hotnew1_abstract = hotnew[0].news_abstract;
            ViewBag.hotnew1_imgrul = newsdeal.getimgurl(hotnew[0].news_content);

            ViewBag.hotnew2_title = hotnew[1].news_title;
            ViewBag.hotnew2_abstract = hotnew[1].news_abstract;
            ViewBag.hotnew2_imgrul = newsdeal.getimgurl(hotnew[1].news_content);

            ViewBag.hotnew3_title = hotnew[2].news_title;
            ViewBag.hotnew3_abstract = hotnew[2].news_abstract;
            ViewBag.hotnew3_imgrul = newsdeal.getimgurl(hotnew[2].news_content);





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