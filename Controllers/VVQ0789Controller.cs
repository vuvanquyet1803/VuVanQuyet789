#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuVanQuyet789.Models;

namespace VuVanQuyet789.Controllers
{
    public class VVQ0789Controller : Controller
    {
        private readonly VuVanQuyet789Context _context;

        public VVQ0789Controller(VuVanQuyet789Context context)
        {
            _context = context;
        }

        // GET: VVQ0789
        public async Task<IActionResult> Index()
        {
            return View(await _context.VVQ0789.ToListAsync());
        }

        // GET: VVQ0789/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vVQ0789 = await _context.VVQ0789
                .FirstOrDefaultAsync(m => m.VVQId == id);
            if (vVQ0789 == null)
            {
                return NotFound();
            }

            return View(vVQ0789);
        }

        // GET: VVQ0789/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VVQ0789/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VVQId,VVQName,VVQGender")] VVQ0789 vVQ0789)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vVQ0789);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vVQ0789);
        }

        // GET: VVQ0789/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vVQ0789 = await _context.VVQ0789.FindAsync(id);
            if (vVQ0789 == null)
            {
                return NotFound();
            }
            return View(vVQ0789);
        }

        // POST: VVQ0789/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VVQId,VVQName,VVQGender")] VVQ0789 vVQ0789)
        {
            if (id != vVQ0789.VVQId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vVQ0789);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VVQ0789Exists(vVQ0789.VVQId))
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
            return View(vVQ0789);
        }

        // GET: VVQ0789/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vVQ0789 = await _context.VVQ0789
                .FirstOrDefaultAsync(m => m.VVQId == id);
            if (vVQ0789 == null)
            {
                return NotFound();
            }

            return View(vVQ0789);
        }

        // POST: VVQ0789/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vVQ0789 = await _context.VVQ0789.FindAsync(id);
            _context.VVQ0789.Remove(vVQ0789);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VVQ0789Exists(string id)
        {
            return _context.VVQ0789.Any(e => e.VVQId == id);
        }
    }
}
