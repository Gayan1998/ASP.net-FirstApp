using EmpCRUD.Data;
using EmpCRUD.Interfaces;
using EmpCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpCRUD.Repositories
{
    public class EmployeRepository : IEmployee
    {
        private readonly EmployeeContext _Context;

        public EmployeRepository(EmployeeContext context)
        {
            _Context = context;
        }

      // Method for create new employee
        public Employe CreateEmp(Employe emp)
        {
            _Context.Employes.Add(emp);
            _Context.SaveChanges();
            return emp;
        }

        // Method for delete employee
        public Employe DeleteEmploye(Employe emp)
        {
            _Context.Employes.Attach(emp);
            _Context.Entry(emp).State = EntityState.Deleted;
            _Context.SaveChanges();
            return emp;
        }

        // Method for edit employee
        public Employe Edit(Employe emp)
        {
            _Context.Employes.Attach(emp);
            _Context.Entry(emp).State = EntityState.Modified;
            _Context.SaveChanges();
            return emp;
        }

        // Method for get single employee
        public Employe GetEmploye(int id)
        {
            Employe emp = _Context.Employes.Where(u => u.Id == id).FirstOrDefault();
            return emp;
        }

        // Method for get all employee
        public List<Employe> GetEmployes()
        {
            List<Employe> employeList = _Context.Employes.ToList();
            return employeList;
        }
    }
}
