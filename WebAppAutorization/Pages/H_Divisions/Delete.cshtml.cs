﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_Divisions
{
    [Authorize]
    [Authorize(Policy = "ХАБ Дивизионы")]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public H_Division H_Division { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.H_Division == null)
            {
                return NotFound();
            }

            var h_division = await _context.H_Division.FirstOrDefaultAsync(m => m.id_division == id);

            if (h_division == null)
            {
                return NotFound();
            }
            else 
            {
                H_Division = h_division;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.H_Division == null)
            {
                return NotFound();
            }
            var h_division = await _context.H_Division.FindAsync(id);

            if (h_division != null)
            {
                H_Division = h_division;
                _context.H_Division.Remove(H_Division);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
