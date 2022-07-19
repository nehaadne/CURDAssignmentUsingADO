using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CURDAssignmentUsingADO.DAL;
using CURDAssignmentUsingADO.Models;

namespace CURDAssignmentUsingADO.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL db = new EmployeeDAL();

        // GET: EmployeeController
        public ActionResult Index()
        {
            var model = db.GetAllemployees();
            return View(model);

        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = db.GetEmployeeById(id);
            return View(model);

        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                int result = db.AddEmployee(employee);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                int result = db.UpdateEmployee(employee);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = db.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = db.DeleteEmployee(id);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();

            }
            catch
            {
                return View();
            }
        }
    }
}
