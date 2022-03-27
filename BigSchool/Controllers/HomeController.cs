using System;
using System.Linq;
using System.Web.Mvc;
using BigSchool.Models;
using System.Data.Entity;
using BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                                        //.Include("Lecturer")
                                        //.Include("Category")
                                        .Include(c => c.Lecturer)
                                        .Include(c => c.Category)
                                        .Where(a => a.IsCanceled == false)
                                        .Where(c => c.DateTime > DateTime.Now);
            return View(upcommingCourses);
        }
    }
}
