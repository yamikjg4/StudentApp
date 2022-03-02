using Microsoft.EntityFrameworkCore;
using StudentWebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebapp.Context
{
    public class StudentDbcontext:DbContext
    {
        
        public StudentDbcontext(DbContextOptions<StudentDbcontext> options):base(options)
        {

        }
        public DbSet<Student> tblstudent { get; set; }
    }
}
