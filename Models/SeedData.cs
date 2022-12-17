using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeCrud.Data;
using System;
using System.Linq;

namespace EmployeeCrud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeCrudContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EmployeeCrudContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }
                context.Employee.AddRange(
                    new Employee
                    {
                        EmployeeName = "Jonh Carter",
                        Department = "HR",
                        Salary = 3000
                    },
                    new Employee
                    {
                        EmployeeName = "Michael Bean",
                        Department = "SC",
                        Salary = 1300
                    },
                    new Employee
                    {
                        EmployeeName = "Jimmy Floy",
                        Department = "MD",
                        Salary = 2000
                    },
                    new Employee
                    {
                        EmployeeName = "Mary Brown",
                        Department = "MD",
                        Salary = 2000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
