using System;
using System.Linq;
using System.Collections.Generic;
using assignment1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using assignment1.Data;

namespace assignment1.Data
{
    public class SampleData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (context.Students.Any())
                {
                    return;
                }


                var Students = GetStudents(context).ToArray();
                context.Students.AddRange(Students);
                context.SaveChanges();
            }
        }

        public static List<Student> GetStudents(ApplicationDbContext context)
        {
            List<Student> Students = new List<Student>() {
            new Student {
                FirstName = "Jim",
                LastName = "Potter",
                MobileNumber = "778-123-4556",
                EmailAddress = "jim@gmail.com",
                City = "Vancouver",
                Specialization = "IT"
            },
            new Student {
                FirstName = "Jane",
                LastName = "Douglas",
                MobileNumber = "778-678-9876",
                EmailAddress = "jane@gmail.com",
                City = "Surrey",
                Specialization = "Nursing"
            },
            new Student {
                FirstName = "Tom",
                LastName = "Gardner",
                MobileNumber = "778-898-5678",
                EmailAddress = "tom@gmail.com",
                City = "Kamloops",
                Specialization = "Architect"
            },
            new Student {
                FirstName = "Ann",
                LastName = "Lee",
                MobileNumber = "778-676-1234",
                EmailAddress = "ann@gmail.com",
                City = "Edmonton",
                Specialization = "Doctor"
            },
            new Student {
                FirstName = "James",
                LastName = "Jones",
                MobileNumber = "778-888-4567",
                EmailAddress = "james@gmail.com",
                City = "Langley",
                Specialization = "Plumber"
            },
            new Student {
                FirstName = "Susan",
                LastName = "Taylor",
                MobileNumber = "778-656-0999",
                EmailAddress = "susan@gmail.com",
                City = "Kelowna",
                Specialization = "Singer"
            },
            new Student {
                FirstName = "Peter",
                LastName = "White",
                MobileNumber = "778-666-9090",
                EmailAddress = "peter@gmail.com",
                City = "White Rock",
                Specialization = "Teacher"
            },
            new Student {
                FirstName = "Philip",
                LastName = "Fox",
                MobileNumber = "778-557-8765",
                EmailAddress = "philip@gmail.com",
                City = "Vancouver",
                Specialization = "Athlete"
            },
            new Student {
                FirstName = "Donna",
                LastName = "Ray",
                MobileNumber = "778-678-3457",
                EmailAddress = "donna@gmail.com",
                City = "Surrey",
                Specialization = "Cashier"
            },
        };

            return Students;
        }
    }
}
