
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlbumFiguritas.Models;
using AlbumFiguritas.Context;

public class FiguritaController : Controller
{
    private readonly AlbumDatabaseContext _context;

    public FiguritaController(AlbumDatabaseContext context)
    {
        _context = context;
    }

    // GET: FIGURITAS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Figuritas.ToListAsync());
    }

    // GET: FIGURITAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var figurita = await _context.Figuritas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (figurita == null)
        {
            return NotFound();
        }

        return View(figurita);
    }

    // GET: FIGURITAS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: FIGURITAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Numero,NombreJugador,Seleccion,UrlFotoJugador,UsuariosPoseen")] Figurita figurita)
    {
        if (ModelState.IsValid)
        {
            _context.Add(figurita);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(figurita);
    }

    // GET: FIGURITAS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var figurita = await _context.Figuritas.FindAsync(id);
        if (figurita == null)
        {
            return NotFound();
        }
        return View(figurita);
    }

    // POST: FIGURITAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Numero,NombreJugador,Seleccion,UrlFotoJugador,UsuariosPoseen")] Figurita figurita)
    {
        if (id != figurita.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(figurita);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiguritaExists(figurita.Id))
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
        return View(figurita);
    }

    // GET: FIGURITAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var figurita = await _context.Figuritas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (figurita == null)
        {
            return NotFound();
        }

        return View(figurita);
    }

    // POST: FIGURITAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var figurita = await _context.Figuritas.FindAsync(id);
        if (figurita != null)
        {
            _context.Figuritas.Remove(figurita);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool FiguritaExists(int? id)
    {
        return _context.Figuritas.Any(e => e.Id == id);
    }
}
