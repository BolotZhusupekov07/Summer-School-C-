using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SummerSchool.Model;

namespace SummerSchool.Data
{
    public class SummerSchoolContext : DbContext
    {
        public SummerSchoolContext (DbContextOptions<SummerSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<SummerSchool.Model.Job> Job { get; set; } = default!;
    }
}
