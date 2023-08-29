using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueApp.Data;
using LeagueApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LeagueApp.Pages.Players
{
    public class PlayerModel : PageModel
    {
        // inject the Entity Framework context

        private readonly LeagueContext _context;

        public PlayerModel(LeagueContext context)
        {
            _context = context;
        }

        // load a single player based on Id

        public Player Player { get; set; }

        public async Task OnGetAsync(string Id)
        {
            Player = await _context.Players.FindAsync(Id);
        }
    }
}
