using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAppLib.Models
{
    public class HomeModel
    {
    }
    public class HomeNowModel
    {

        public string code { get; set; }
        public string msg { get; set; }
        public DateTime totime { get; set; }
        public HomeNowListModel[] data { get; set; }
    }
    public class HomeNowListModel
    {
        public int id { get; set; }
        public int paper_id { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        public int lecturer { get; set; }
        public string teacher_name { get; set; }
        public string avatar { get; set; }
        public int lnum { get; set; }
        public string ytime { get; set; }
    }
}
