using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BudgetManagement.Models;

namespace BudgetManagement.Controllers
{
    public class SurseFinController : Controller
    {
        private readonly BudgetContext _context;

        public SurseFinController(BudgetContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SurseFin.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.SurseFin.ToListAsync();
            return Json(data);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _context.SurseFin.FindAsync(id);
            if (item == null) return NotFound();
            return Json(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SurseFin model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                //await _context.SaveChangesAsync();
                var sql = @"INSERT INTO SurseFin (an, cod, denumire, colectie, tipsrs, cod_afis, tipbuget, ordine, blocat) 
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})";
                await _context.Database.ExecuteSqlRawAsync(sql, 
                    model.An, model.Cod, model.Denumire, model.Colectie, model.TipSrs, model.CodAfis, model.TipBuget,
                    model.Ordine, model.Blocat);
                return Json(new { success = true, data = model });
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SurseFin model)
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
            var item = await _context.SurseFin.FindAsync(id);
            if (item == null) return NotFound();
            
            _context.SurseFin.Remove(item);
            await _context.SaveChangesAsync();
            return Json(new { success = true });
        }
    }
}