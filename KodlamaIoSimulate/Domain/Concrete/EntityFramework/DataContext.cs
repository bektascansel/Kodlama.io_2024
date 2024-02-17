using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class DataContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-I4EMULH\SQLEXPRESS01;Database=Kodlamaio;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False", b => b.MigrationsAssembly("DataAccess"));
        }


        DbSet<Course> Courses { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Category> Categories { get; set; }



    }
}
