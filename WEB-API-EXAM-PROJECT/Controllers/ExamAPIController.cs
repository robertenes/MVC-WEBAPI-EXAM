using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API_EXAM_PROJECT.Models;
namespace WEB_API_EXAM_PROJECT.Controllers
{
    public class ExamAPIController : ApiController
    {
        [HttpGet]
        public IHttpActionResult onlineExam()
        {

            var model = DataBase.list.ToList();

            return Ok(model);
        }

    }
}
