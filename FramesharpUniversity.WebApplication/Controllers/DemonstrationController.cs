using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Framesharp.Core;
using Framesharp.DomainService;
using FramesharpUniversity.DomainService.Interfaces;

namespace FramesharpUniversity.WebApplication.Controllers
{
    public class DemonstrationController : Controller
    {
        private readonly IDemonstrationDomainService _demonstrationDomainService;

        public DemonstrationController()
        {
            _demonstrationDomainService = DomainServiceFactory.Get<IDemonstrationDomainService>(OperationCallContext.Current);
        }

        [HttpGet]
        public ActionResult Index()
        {
            Models.Demonstration demonstration = _demonstrationDomainService.GetDemonstration(1);

            return View(demonstration);
        }
    }
}
