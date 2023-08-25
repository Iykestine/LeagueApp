using LeagueApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LeagueContext _context;

        public IndexModel(ILogger<IndexModel> logger, LeagueContext context)
        {
            _logger = logger;
            _context = context;
        }
        public LeagueApp.Models.League League { get; set; }

        public async Task OnGetAsync()
        {
            League = await _context.Leagues.FirstOrDefaultAsync();
        }
    }
}
