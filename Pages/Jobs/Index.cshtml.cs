using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SummerSchool.Data;
using SummerSchool.Model;

namespace SummerSchool.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly SummerSchool.Data.SummerSchoolContext _context;

        public IndexModel(SummerSchool.Data.SummerSchoolContext context)
        {
            _context = context;
        }

        public IList<Job> Job { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Job = await _context.Job.ToListAsync();
        }
    }
}
