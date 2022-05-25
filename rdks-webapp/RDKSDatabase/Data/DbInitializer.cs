using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RDKSDatabase.Data;
using RDKSDatabase.Models;
using System;
using System.Linq;

namespace RDKSDatabase.Data
{
    public class DbInitializer
    {

        public void Initialize(RDKSDatabaseContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
                {
                    new Customer{StudentID=1,CourseID=1050,Grade=Grade.A},
                    new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                    new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                    new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                    new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                };

            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();




        }
    }
}
