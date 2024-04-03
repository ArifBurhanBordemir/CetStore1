using CetStore1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CetStore1.Models
{
    public class MenuViewComponent :ViewComponent
    {
        
        public MenuViewComponent(ApplicationDbContext context)
        {
            Context = context;
        }

        public ApplicationDbContext Context { get; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> categories = await Context.categories.ToListAsync();
            return View(categories);
        }
    }
}
