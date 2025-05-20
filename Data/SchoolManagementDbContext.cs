using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementAppMVC.Data;

    public class SchoolManagementDbContext : DbContext
    {
        public SchoolManagementDbContext (DbContextOptions<SchoolManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolManagementAppMVC.Data.Lecturer> Lecturer { get; set; } = default!;

public DbSet<SchoolManagementAppMVC.Data.Student> Student { get; set; } = default!;
    }
