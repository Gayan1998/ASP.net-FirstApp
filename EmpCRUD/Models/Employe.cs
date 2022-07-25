using System.ComponentModel.DataAnnotations;

namespace EmpCRUD.Models
{
    public class Employe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Contact { get; set; }

        [Required]
        public int age { get; set; }
    }
}
