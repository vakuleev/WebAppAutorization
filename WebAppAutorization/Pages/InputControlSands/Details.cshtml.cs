﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.InputControlSands
{
    [Authorize]
    [Authorize(Policy = "Входной контроль песка")]
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DetailsModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      public InputControlSand InputControlSand { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.InputControlSands == null)
            {
                return NotFound();
            }

            var inputcontrolsand = await _context.InputControlSands.FirstOrDefaultAsync(m => m.Id == id);
            if (inputcontrolsand == null)
            {
                return NotFound();
            }
            else 
            {
                InputControlSand = inputcontrolsand;
            }
            return Page();
        }
    }
}
