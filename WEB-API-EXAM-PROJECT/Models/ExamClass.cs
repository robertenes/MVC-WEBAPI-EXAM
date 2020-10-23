using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_EXAM_PROJECT.Models
{
    public class ExamClass
    {
        public int ID { get; set; }
        public string Q { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string A4 { get; set; }
        public string CORRECT_ANSWER { get; set; }
    }
}