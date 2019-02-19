using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static PetroTech.Common.Resource.EnumTools;
using static PetroTech.Common.Resource.Helper.Enum;
using PetroTech.Common.Resource;

namespace PetroTech.Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}