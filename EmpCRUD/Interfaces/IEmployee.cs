using EmpCRUD.Models;
namespace EmpCRUD.Interfaces
{
    public interface IEmployee
    {
        List<Employe> GetEmployes();

        Employe GetEmploye(int id);

        Employe CreateEmp( Employe emp);
        Employe Edit(Employe emp);

        Employe DeleteEmploye(Employe emp);
    }
}
