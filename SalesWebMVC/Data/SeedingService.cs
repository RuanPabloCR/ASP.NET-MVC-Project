using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System.Diagnostics;
namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;
        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departament.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                Debug.WriteLine("Database has been seeded or Database has informations");
                return; // DB has been seeded
            }
            Departament d1 = new Departament(4, "Construction materials");
            Departament d2 = new Departament(5, "Fashion");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1996, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s2);

            _context.Departament.AddRange(d1, d2);
            _context.Seller.AddRange(s1, s2);
            _context.SalesRecord.AddRange(r1, r2);
            _context.SaveChanges();
        }
    }
}
