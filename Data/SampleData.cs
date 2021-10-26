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

        public static List<Province> GetProvinces()
        {
            List<Province> Provinces = new List<Province>() {
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
            new Province() {
                ProvinceCode="QC",
                ProvinceName="Quebec",
            },
        };

            return Provinces;
        }

        public static List<Student> GetStudents(ApplicationDbContext context)
        {
            List<Student> Students = new List<Student>() {
            new Student {
                CityName = "Vancouver",
                Population = 2000000,
                ProvinceCode = "BC",
            },
            new Student {
                CityName = "Victoria",
                Population = 500000,
                ProvinceCode = "BC",
            },
            new Student {
                CityName = "Kamloops",
                Population = 50000,
                ProvinceCode = "BC",
            },
            new City {
                CityName = "Toronto",
                Population = 6000000,
                ProvinceCode = "ON",
            },
            new City {
                CityName = "Hamilton",
                Population = 30000,
                ProvinceCode = "ON",
            },
            new City {
                CityName = "Ottawa",
                Population = 1000000,
                ProvinceCode = "ON",
            },
            new City {
                CityName = "Montreal",
                Population = 4000000,
                ProvinceCode = "QC",
            },
            new City {
                CityName = "Quebec City",
                Population = 50000,
                ProvinceCode = "QC",
            },
            new City {
                CityName = "Gatineau",
                Population = 30000,
                ProvinceCode = "QC",
            },
        };

            return Cities;
        }
    }
}
