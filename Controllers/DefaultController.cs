using AcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead() 
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar() 
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var SkillCount = db.TblSkill.ToList().Count();
            var TestimonialCount = db.TblTestimonial.ToList().Count();
            var ProjectCount = db.TblProject.ToList().Count();
            var ServiceCount = db.TblService.ToList().Count();
            ViewBag.TestimonialCount = TestimonialCount;
            ViewBag.SkillCount = SkillCount;
            ViewBag.ProjectCount = ProjectCount;
            ViewBag.ServiceCount = ServiceCount;
            return PartialView();
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact y)
        {
            if (ModelState.IsValid)
            {
                db.TblContact.Add(y);
                db.SaveChanges();

                ViewBag.RedirectUrl = Url.Action("Index", "Default");
            }
            return PartialView();
        }
        public PartialViewResult PartialAdress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSocialMedia()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooterService()
            
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHobby()
        {
            var values = db.TblHobby.ToList();
            return PartialView(values);
        }
    }
}