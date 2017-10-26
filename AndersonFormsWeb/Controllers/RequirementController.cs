
using System;
using System.Web.Mvc;
using System.Linq;
using AndersonFormsFunction;
using AndersonFormsModel;
using AndersonFormsWeb.Models;
using AndersonCRMFunction;
using AndersonCRMModel;
using System.Collections.Generic;

namespace AndersonFormsWeb.Controllers
{

    public class RequirementController : Controller
    {
        private IFRequestedItem _iFRequestedItem;
        private IFRequirement _iFRequirements;
        private IFEmployee _iFEmployee;

        public RequirementController()
        {
            _iFRequestedItem = new FRequestedItem();
            _iFRequirements = new FRequirement();
            _iFEmployee = new FEmployee();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}