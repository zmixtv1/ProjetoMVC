using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departments.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Departments d1 = new Departments { Name = "Computers" };
            Departments d2 = new Departments { Name = "Electronics" };
            Departments d3 = new Departments { Name = "Fashion" };
            Departments d4 = new Departments { Name = "Books" };

            Seller s1 = new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, Department = d1 };
            Seller s2 = new Seller { Name = "Maria Green", Email = "maria@gmail.com", BirthDate = new DateTime(2000, 5, 16), BaseSalary = 1000.0, Department = d2 };
            Seller s3 = new Seller { Name = "Rodrigo Alaôr", Email = "rodrigoalaor.lm@gmail.com", BirthDate = new DateTime(2002, 3, 24), BaseSalary = 1000.0, Department = d3 };
            Seller s4 = new Seller { Name = "Maria Célia", Email = "mariacelia.ldm@gmail.com", BirthDate = new DateTime(1973, 8, 28), BaseSalary = 1000.0, Department = d2 };
            Seller s5 = new Seller { Name = "Antônio Alaôr", Email = "antonioalaor@gmail.com", BirthDate = new DateTime(1951, 8, 28), BaseSalary = 1000.0, Department = d4 };
            Seller s6 = new Seller { Name = "Alex Pink", Email = "alexpink@gmail.com", BirthDate = new DateTime(1998, 4, 10), BaseSalary = 1000.0, Department = d1 };

            SalesRecord r1 = new SalesRecord { Date = new DateTime(2025, 02, 04), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r2 = new SalesRecord { Date = new DateTime(2025, 01, 24), Amount = 15000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r3 = new SalesRecord { Date = new DateTime(2024, 02, 04), Amount = 1100.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r4 = new SalesRecord { Date = new DateTime(2024, 01, 13), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r5 = new SalesRecord { Date = new DateTime(2024, 02, 11), Amount = 100.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r6 = new SalesRecord { Date = new DateTime(2024, 05, 26), Amount = 1100.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r7 = new SalesRecord { Date = new DateTime(2024, 06, 22), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s6 };
            SalesRecord r8 = new SalesRecord { Date = new DateTime(2024, 07, 25), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r9 = new SalesRecord { Date = new DateTime(2024, 02, 23), Amount = 1110.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r10 = new SalesRecord { Date = new DateTime(2025, 02, 14), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r11 = new SalesRecord { Date = new DateTime(2025, 01, 23), Amount = 1176.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r12 = new SalesRecord { Date = new DateTime(2025, 02, 03), Amount = 111240.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r13 = new SalesRecord { Date = new DateTime(2025, 01, 11), Amount = 567600.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r14 = new SalesRecord { Date = new DateTime(2025, 02, 04), Amount = 15000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r15 = new SalesRecord { Date = new DateTime(2025, 01, 23), Amount = 1130.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r16 = new SalesRecord { Date = new DateTime(2025, 02, 14), Amount = 1700.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r17 = new SalesRecord { Date = new DateTime(2025, 01, 04), Amount = 1780.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r18 = new SalesRecord { Date = new DateTime(2025, 02, 24), Amount = 1123400.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r19 = new SalesRecord { Date = new DateTime(2025, 01, 04), Amount = 15710.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r20 = new SalesRecord { Date = new DateTime(2025, 03, 24), Amount = 15710.0, Status = SaleStatus.Billed, Seller = s3 };

            _context.Departments.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20);

            _context.SaveChanges();
        }
    }
}
