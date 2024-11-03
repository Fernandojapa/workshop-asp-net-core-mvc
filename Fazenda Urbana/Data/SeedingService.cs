using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FazendaUrbana.Models;
using FazendaUrbana.Models.Enums;

namespace FazendaUrbana.Data
{
    public class SeedingService
    {
        private FazendaUrbanaContext _context;

        public SeedingService(FazendaUrbanaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
               _context.Seller.Any() ||
               _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Fresh Produce");
            Department d2 = new Department(2, "Organic Products");
            Department d3 = new Department(3, "Farm Tools");
            Department d4 = new Department(4, "Gourmet Products");

            Seller s1 = new Seller(1, "Fernando", "fernando@gmail.com", new DateTime(2005, 03, 18), 5000.0, d1);
            Seller s2 = new Seller(2, "Brenno", "brenno@gmail.com", new DateTime(2001, 11, 20), 5000.0, d2);
            Seller s3 = new Seller(3, "Ewerton", "ewerton@gmail.com", new DateTime(2002, 05, 01), 5000.0, d3);
            Seller s4 = new Seller(4, "Daniel", "daniel@gmail.com", new DateTime(2002, 01, 02), 5000.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2024, 08, 19), 1100.0, SaleStatus.Billed, s2);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2024, 08, 20), 1500.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2024, 09, 02), 2000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2024, 09, 07), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2024, 09, 11), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2024, 09, 15), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2024, 09, 16), 1500.0, SaleStatus.Billed, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2024, 09, 19), 1800.0, SaleStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2024, 09, 21), 1500.0, SaleStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2024, 09, 27), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2024, 10, 05), 2000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11);

            _context.SaveChanges();





















        }
    }
}
