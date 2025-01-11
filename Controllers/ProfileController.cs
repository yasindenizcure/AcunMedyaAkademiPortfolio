using AcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblProfile.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProfile() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProfile(TblProfile p) 
        {
            db.TblProfile.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProfile(int id) 
        {
            var value = db.TblProfile.Find(id);
            db.TblProfile.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProfile(int id) 
        {
            var value = db.TblProfile.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProfile(TblProfile p) 
        {
            var value = db.TblProfile.Find(p.ProfileId);
            value.Name = p.Name;
            value.Adress = p.Adress;
            value.PhoneNumber = p.PhoneNumber;
            value.Email = p.Email;
            value.Birthday = p.Birthday;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}