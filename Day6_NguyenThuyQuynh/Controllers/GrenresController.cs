
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Day6_NguyenThuyQuynh.Models;

public class GrenresController : Controller
{
    private readonly Day6_NguyenThuyQuynhContext _context;

    public GrenresController(Day6_NguyenThuyQuynhContext context)
    {
        _context = context;
    }

    // GET: GRENRES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Grenres.ToListAsync());
    }

    // GET: GRENRES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var grenre = await _context.Grenres
            .FirstOrDefaultAsync(m => m.Id == id);
        if (grenre == null)
        {
            return NotFound();
        }

        return View(grenre);
    }

    // GET: GRENRES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: GRENRES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Description,Movies")] Grenre grenre)
    {
        if (ModelState.IsValid)
        {
            _context.Add(grenre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(grenre);
    }

    // GET: GRENRES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var grenre = await _context.Grenres.FindAsync(id);
        if (grenre == null)
        {
            return NotFound();
        }
        return View(grenre);
    }

    // POST: GRENRES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Description,Movies")] Grenre grenre)
    {
        if (id != grenre.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(grenre);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrenreExists(grenre.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(grenre);
    }

    // GET: GRENRES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var grenre = await _context.Grenres
            .FirstOrDefaultAsync(m => m.Id == id);
        if (grenre == null)
        {
            return NotFound();
        }

        return View(grenre);
    }

    // POST: GRENRES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var grenre = await _context.Grenres.FindAsync(id);
        if (grenre != null)
        {
            _context.Grenres.Remove(grenre);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GrenreExists(int? id)
    {
        return _context.Grenres.Any(e => e.Id == id);
    }
}
