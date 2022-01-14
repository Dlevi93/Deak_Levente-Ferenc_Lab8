using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Deak_Levente_Ferenc_Lab8.Models;

namespace Deak_Levente_Ferenc_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Data.Deak_Levente_Ferenc_Lab8Context _context;

        public IndexModel(Data.Deak_Levente_Ferenc_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
