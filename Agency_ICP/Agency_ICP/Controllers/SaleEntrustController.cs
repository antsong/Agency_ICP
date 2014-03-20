using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agency_ICP.App_Start;

namespace Agency_ICP.Controllers
{
    [AuthorizeFilter(Message = "SaleEntrust")]
    public class SaleEntrustController : Controller
    {

        
        public SaleEntrustController()
        { 

        }

        //
        // GET: /SaleEntrust/

        public ActionResult Index()
        {
            return RedirectToAction("SaleEntrustList");
        }


        public ActionResult SaleEntrustList()
        {

            return View();
        }


        public ActionResult SaleEntrustDetial(object id)
        {
            throw new Exception();
            return View();
        }
    }
}
