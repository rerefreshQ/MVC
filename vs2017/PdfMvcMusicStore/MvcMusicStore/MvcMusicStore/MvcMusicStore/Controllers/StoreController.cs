using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //P52

        // GET: Store
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {

            return "我是 Hello form Store.Index()";
        }


        public string Browse(int nid)
        {
            //http://localhost:28136/store/Details/5
            string message = "Store.Details, ID = " + nid;
            return message;
        }



        //public string Browse(string genre)
        //{
        //    //http://localhost:28136/store/Browse?genre=xx
        //    string message = HttpUtility.HtmlEncode("Store.Browse,Genre=" + genre);
        //    return message;
        //}

        public string Details(int id)
        {
            //http://localhost:28136/store/Details/5
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}
