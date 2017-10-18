
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
    
    public class RollInController : Controller
    {
        private IFRequestedItem _iFRequestedItem;
        private IFRequirement _iFRequirements;
        private IFEmployee _iFEmployee;

        public RollInController()
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

        [HttpGet]
        public ActionResult Create()
        {
            List<Requirement> requirements = new List<Requirement>();
            requirements = _iFRequirements.Read();

            RollInModel rollInModel = new RollInModel
            {
                Employee = new Employee(),
                RequestedItems = new List<RequestedItem>(),
                Requirements = requirements
            };
            return View(rollInModel);
        }

        [HttpPost]
        public ActionResult Create(RollInModel rollInModel)
        {

            try
            {
                var employee = _iFEmployee.Create(rollInModel.Employee);
                //foreach (var rollIn in rollInModel.Requirements)
                //{
                //    rollIn.EmployeeId = employee.EmployeeId;
                //    _iFRequirements.Create(rollIn);
                //}
                return View(rollInModel);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }

        }
        
    }
}