using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;
using System.Configuration;

namespace SalesWebMvc.Models
{
    public class Seller
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3,ErrorMessage ="{0} size should be between {2} and {1}")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s]+$", ErrorMessage = "{0} should contain only letters")]
        public string Name { get; set; }


        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [Required(ErrorMessage = "{0} required")]
        public string Email { get; set; }


        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        [Range(100.0,50000.0,ErrorMessage ="{0} must be from {1} to {2}")]
        public double BaseSalary { get; set; }


        public Departments Department { get; set; }


        [Display(Name = "Department ID")]
        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public Seller()
        {

        }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departments department, int departmentId)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
            DepartmentId = departmentId;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date >= final).Sum(sr => sr.Amount);
        }
    }
}
