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
    public class DetailsModel : PageModel
    {
        private readonly SummerSchool.Data.SummerSchoolContext _context;

        public DetailsModel(SummerSchool.Data.SummerSchoolContext context)
        {
            _context = context;
        }

        public Job Job { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job.FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            else
            {
                Job = job;
            }
            return Page();
        }
    }
}
