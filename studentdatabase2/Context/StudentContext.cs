using Microsoft.EntityFrameworkCore;
using studentdatabase2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentdatabase2.Context
{
    public class StudentContext:DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options): base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
    }
}
