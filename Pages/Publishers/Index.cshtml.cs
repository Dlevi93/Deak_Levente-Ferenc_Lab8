using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Deak_Levente_Ferenc_Lab8.Data;
using Deak_Levente_Ferenc_Lab8.Models;

namespace Deak_Levente_Ferenc_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Deak_Levente_Ferenc_Lab8.Data.Deak_Levente_Ferenc_Lab8Context _context;

        public IndexModel(Deak_Levente_Ferenc_Lab8.Data.Deak_Levente_Ferenc_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
