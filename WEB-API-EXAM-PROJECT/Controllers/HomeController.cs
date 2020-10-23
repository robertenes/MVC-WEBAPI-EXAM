using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WEB_API_EXAM_PROJECT.Models;
namespace WEB_API_EXAM_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<ExamClass> model = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:62547/api/ExamAPI");
            var consumeap1 = hc.GetAsync("ExamAPI");
            consumeap1.Wait();

            var readdata = consumeap1.Result;
            if(readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IEnumerable<ExamClass>>();
                displaydata.Wait();
                model = displaydata.Result;
            }
          
            return View(model);
        }
    }
}
