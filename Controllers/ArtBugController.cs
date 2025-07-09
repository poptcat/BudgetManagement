using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BudgetManagement.Models;

namespace BudgetManagement.Controllers
{
    public class ArtBugController : Controller
    {
        private readonly BudgetContext _context;

        public ArtBugController(BudgetContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ArtBug.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.ArtBug.ToListAsync();
            return Json(data);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _context.ArtBug.FindAsync(id);
            if (item == null) return NotFound();
            return Json(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ArtBug model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return Json(new { success = true, data = model });
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ArtBug model)
        {
            if (ModelState.IsValid)
            {
                _context.Update(model);
                await _context.SaveChangesAsync();
                return Json(new { success = true });
            }
            return BadRequest(ModelState);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.ArtBug.FindAsync(id);
            if (item == null) return NotFound();
            
            _context.ArtBug.Remove(item);
            await _context.SaveChangesAsync();
            return Json(new { success = true });
        }
    }
}
