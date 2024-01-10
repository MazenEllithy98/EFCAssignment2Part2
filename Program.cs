using EFCAssignment2Part2.Contexts;
using EFCAssignment2Part2.Entities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace EFCAssignment2Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using CompanyDbContext dbContext = new CompanyDbContext();
            FullTimeEmployee fullTimeEmployee= new FullTimeEmployee()
            {
                Name = "Ahmed",
                Age = 30,
                Address = "Cairo",
                Salary = 5000,
                StartDate = DateTime.Now,
            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Mazen",
                Age=25,
                Address = "Alexandria",
                HourRate = 40,
                CountOfHours = 100,
            };

            //dbContext.Add(fullTimeEmployee);
            //dbContext.Add(partTimeEmployee);

            //dbContext.SaveChanges();

            var fulltimeEmployees = from F in dbContext.FullTimeEmployee
                                    select F;

            var parttimeEmployees = from P in dbContext.PartTimeEmployee
                                    select P;

            foreach (var f in fulltimeEmployees)
            
                Console.WriteLine($"{f.ID}  , {f.Name}  , {f.Salary}");


            foreach (var p in parttimeEmployees)

                Console.WriteLine($"{p.ID}  , {p.Name}  , {p.HourRate}");

        }
    }
}