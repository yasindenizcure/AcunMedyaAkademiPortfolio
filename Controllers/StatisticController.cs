using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;
namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.skillAvgValue = db.TblSkill.Average(x=> x.Value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle1().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.TblProject.Where(x=> x.ProjectCategory==1).Count();
            ViewBag.mvcCategoryProjectCount2 = db.TblProject.Where(x=> x.ProjectCategory==2).Count();
            ViewBag.mvcCategoryProjectCount3 = db.TblProject.Where(x=> x.ProjectCategory==3).Count();
            ViewBag.mvcCategoryProjectCount4 = db.TblProject.Where(x=> x.ProjectCategory==4).Count();
            ViewBag.mvcCategoryProjectCount5 = db.TblProject.Where(x=> x.ProjectCategory==5).Count();
            return View();
        }
    }
}