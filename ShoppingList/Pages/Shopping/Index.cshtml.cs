using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShoppingList.Data;
using ShoppingList.Models;

namespace ShoppingList.Pages.Shopping
{
    public class IndexModel : PageModel
    {
        private readonly ShoppingList.Data.ShoppingListContext _context;

        public IndexModel(ShoppingList.Data.ShoppingListContext context)
        {
            _context = context;
        }

        public IList<List> List { get;set; }

        public async Task OnGetAsync()
        {
            List = await _context.List.ToListAsync();
        }
    }
}
