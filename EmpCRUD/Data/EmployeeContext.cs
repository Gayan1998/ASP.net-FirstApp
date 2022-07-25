using EmpCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpCRUD.Data
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<Employe> Employes { get; set; }
    }
}
