using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.Agents
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public EditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Agent Agent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Agents == null)
            {
                return NotFound();
            }

            var agent =  await _context.Agents.FirstOrDefaultAsync(m => m.Id == id);
            if (agent == null)
            {
                return NotFound();
            }
            Agent = agent;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Agent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgentExists(Agent.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AgentExists(long id)
        {
          return (_context.Agents?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
