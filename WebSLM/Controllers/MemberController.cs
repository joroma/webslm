using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSLMMembership;
using WebSLMDatabase;
using WebSLMDomain;
using WebSLM.Models.ViewModels;



namespace WebSLM.Controllers
{
    public class MemberController : Controller
    {
        private readonly WebSLMContext db = new WebSLMContext();
        
        // GET: Member
        public ActionResult Index()
        {
            var members = db.Members.ToList();
            var memberViewModels = members.Select(member => member.ToViewModel()).ToList();
            
            return View(memberViewModels);
        }
    }
}