using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enum;

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
            if(_context.Departments.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; //Banco tem dados
            }

            Departments d1 = new Departments(1, "Computers");
            Departments d2 = new Departments(2, "Eletronics");
            Departments d3 = new Departments(3, "Fashion");
            Departments d4 = new Departments(4, "Books");

            Seller s1 = new Seller(1, "Bob Bro", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Anna Frank", "anna@gmail.com", new DateTime(1988, 12, 1), 3000.0, d2);
            Seller s3 = new Seller(3, "Carlos Slim", "slim@gmail.com", new DateTime(1970, 10, 15), 5000.0, d3);
            Seller s4 = new Seller(4, "Michael Owen", "owen@gmail.com", new DateTime(1990, 1, 30), 2000.0, d4);
            Seller s5 = new Seller(5, "John Mayer", "mayer@gmail.com", new DateTime(1981, 5, 6), 4000.0, d1);
            Seller s6 = new Seller(6, "Kevin Durant", "durant@gmail.com", new DateTime(2000, 8, 13), 6000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 10, 11), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 10, 12), 10000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 11, 15), 9000.0, SaleStatus.Billed, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 11, 11), 7000.0, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 12, 25), 15000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 12, 26), 31000.0, SaleStatus.Billed, s4);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 9, 1), 1500.0, SaleStatus.Billed, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 9, 22), 1000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 8, 5), 4000.0, SaleStatus.Billed, s5);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 8, 20), 800.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 7, 21), 1200.0, SaleStatus.Billed, s6);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 7, 12), 1750.0, SaleStatus.Billed, s5);

            _context.Departments.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12);

            _context.SaveChanges();
        }
    }
}
