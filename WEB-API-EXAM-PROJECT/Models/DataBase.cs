using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_EXAM_PROJECT.Models
{
    public class DataBase
    {
        private static Dictionary<string, ExamClass> _list;
        static DataBase()
        {
            _list = new Dictionary<string, ExamClass>();
            _list.Add("Türkiyenin Başkenti Neresidir?", new ExamClass
            {
                ID = 1,
                Q = "Türkiyenin Başkenti Neresidir?",
                A1 = "İstanbul",
                A2 = "İstanbul",
                A3 = "Ankara",
                A4 = "Bayburt",
                CORRECT_ANSWER = "Ankara"
            });
            _list.Add("Türkiyede kaç bölge vardır?", new ExamClass
            {
                ID = 2,
                Q = "Türkiyede kaç bölge vardır?",
                A1 = "2",
                A2 = "3",
                A3 = "7",
                A4 = "8",
                CORRECT_ANSWER = "7"
            });
            _list.Add("Türkiyenin en güzel şehri neresidir?", new ExamClass
            {
                ID = 3,
                Q = "Türkiyenin en güzel şehri neresidir?",
                A1 = "İstanbul",
                A2 = "İstanbul",
                A3 = "Ankara",
                A4 = "Bayburt",
                CORRECT_ANSWER = "İstanbul"
            });
            _list.Add("Atatürkün doğum yılı kaçtır?", new ExamClass
            {
                ID = 4,
                Q = "Atatürkün doğum yılı kaçtır?",
                A1 = "1880",
                A2 = "1881",
                A3 = "1920",
                A4 = "1938",
                CORRECT_ANSWER = "1938"
            });
        }
        
        public static IEnumerable<ExamClass> list
        {
            get { return _list.Values; }
        }
    }
}