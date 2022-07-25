using EmpCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EmpCRUD.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EmpCRUD.Interfaces;

namespace EmpCRUD.Controllers
{
    public class EmployeController : Controller
    {
        public IActionResult Index()
        {
            // return all employees
            List<Employe> employeList = _EmployeRepo.GetEmployes();
            return View(employeList);
        }
        // interface object
        private readonly IEmployee _EmployeRepo;
        public EmployeController(EmployeeContext context, IEmployee EmpRepo)
        {
            _EmployeRepo = EmpRepo;
        }

        //employee create HTTP get
        public IActionResult create()
        {
            Employe employe = new Employe();
            return View(employe);
        }
        //employee create HTTP Psot
        [HttpPost]
        public IActionResult create(Employe employe)
        {
            try
            {
                employe = _EmployeRepo.CreateEmp(employe);
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }

        //Return employee details
        public IActionResult detials(int id)
        {
            Employe emp = _EmployeRepo.GetEmploye(id);
            return View(emp);   
        }

        // Edit employee HTTP Get
        public IActionResult Edit(int id)
        {
            Employe emp = _EmployeRepo.GetEmploye(id);
            return View(emp);
        }
        // Edit employee HTTP Post
        [HttpPost]
        public IActionResult Edit(Employe employe)
        {
            try
            {
                employe = _EmployeRepo.Edit(employe);
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }

        // Edit employee HTTP Get
        public IActionResult Delete(int id)
        {
            Employe emp = _EmployeRepo.GetEmploye(id);
            return View(emp);
        }
        // Edit employee HTTP Post
        [HttpPost]
        public IActionResult Delete(Employe employe)
        {
            try
            {
                employe = _EmployeRepo.DeleteEmploye(employe);
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }
    }
}
