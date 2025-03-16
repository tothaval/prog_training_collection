using AspNetTraining2.Data;
using AspNetTraining2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.EntityFrameworkCore;

namespace AspNetTraining2.Controllers
{
    public class ItemsController : Controller
    {
        private readonly AspNetTraining2DbContext _AspNetTraining2DbContext;

        public ItemsController(AspNetTraining2DbContext aspNetTraining2DbContext)
        {
            _AspNetTraining2DbContext = aspNetTraining2DbContext;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _AspNetTraining2DbContext.Items.Include(s => s.SerialNumber)
                                                            .Include(c => c.Category)
                                                            .Include(ic => ic.ItemClients)
                                                            .ThenInclude(c => c.Client)
                                                            .ToListAsync();

            return View(item);
        }

        public IActionResult Create()
        {
            ViewData["Categories"] = new SelectList(_AspNetTraining2DbContext.Categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id, Name, Price, CategoryId")] Item item)
        {
            if (ModelState.IsValid)
            {
                _AspNetTraining2DbContext.Items.Add(item);

                await _AspNetTraining2DbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(item);
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewData["Categories"] = new SelectList(_AspNetTraining2DbContext.Categories, "Id", "Name");


            var item = await _AspNetTraining2DbContext.Items.FirstOrDefaultAsync(x => x.Id == id);

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Price, CategoryId")] Item item)
        {
            if (ModelState.IsValid)
            {
                _AspNetTraining2DbContext.Update(item);
                await _AspNetTraining2DbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(item);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _AspNetTraining2DbContext.Items.FirstOrDefaultAsync(x => x.Id == id);

            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _AspNetTraining2DbContext.Items.FindAsync(id);

            if (item != null)
            {
                _AspNetTraining2DbContext.Items.Remove(item);
                await _AspNetTraining2DbContext.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

    }
}
