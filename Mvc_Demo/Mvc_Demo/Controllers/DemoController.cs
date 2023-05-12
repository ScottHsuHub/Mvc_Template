using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Demo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // 在執行控制器動作方法之前執行的邏輯
            // 可以在此進行驗證、記錄等操作
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // 在執行控制器動作方法之後執行的邏輯
            // 可以在此進行後續處理、日誌記錄等操作
        }
    }
}