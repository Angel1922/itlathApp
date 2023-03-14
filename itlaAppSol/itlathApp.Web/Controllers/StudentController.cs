using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace itlathApp.Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            List<Models.StudentModel> students
                = new List<Models.StudentModel>()
                {
                    new Models.StudentModel()
                    {
                        Id = 1, EnrollmentDate = System.DateTime.Now, FirstName = "Angel", LastName = "Ortega", Email = "qweqws@gmail.com"
                    },
                    new Models.StudentModel()
                    {
                        Id = 2, EnrollmentDate = System.DateTime.Now, FirstName = "Carlos", LastName = "Valdez", Email = "uqiyququ@gmail.com"
                    },
                    new Models.StudentModel()
                    {
                        Id = 3, EnrollmentDate = System.DateTime.Now, FirstName = "Angie", LastName = "Vargas", Email = "nbiahbfd@gmail.com"
                    }
                };
            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
