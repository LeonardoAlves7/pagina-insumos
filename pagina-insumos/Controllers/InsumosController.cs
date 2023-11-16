using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pagina_insumos.Models;

namespace pagina_insumos.Controllers
{
    public class InsumosController : Controller
    {
        private readonly AppDbContext _context;
        public InsumosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Insumos.ToListAsync();
            
            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Insumo insumo)
        {
            if(ModelState.IsValid)
            {
                _context.Insumos.Add(insumo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            return View(insumo);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Insumos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Insumo insumo)
        {
            if (id != insumo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Insumos.Update(insumo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
                return NotFound();

            var dados = await _context.Insumos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
                return NotFound();

            var dados = await _context.Insumos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {

            if (id == null)
                return NotFound();

            var dados = await _context.Insumos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Insumos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
