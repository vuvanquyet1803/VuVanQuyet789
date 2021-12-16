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
    public class CompanyController : Controller
    {
        private readonly VuVanQuyet789Context _context;

        public CompanyController(VuVanQuyet789Context context)
        {
            _context = context;
        }

        // GET: Company
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyVVQ789.ToListAsync());
        }

        // GET: Company/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyVVQ789 = await _context.CompanyVVQ789
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVVQ789 == null)
            {
                return NotFound();
            }

            return View(companyVVQ789);
        }

        // GET: Company/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyVVQ789 companyVVQ789)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyVVQ789);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyVVQ789);
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyVVQ789 = await _context.CompanyVVQ789.FindAsync(id);
            if (companyVVQ789 == null)
            {
                return NotFound();
            }
            return View(companyVVQ789);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyVVQ789 companyVVQ789)
        {
            if (id != companyVVQ789.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyVVQ789);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyVVQ789Exists(companyVVQ789.CompanyId))
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
            return View(companyVVQ789);
        }

        // GET: Company/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyVVQ789 = await _context.CompanyVVQ789
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVVQ789 == null)
            {
                return NotFound();
            }

            return View(companyVVQ789);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyVVQ789 = await _context.CompanyVVQ789.FindAsync(id);
            _context.CompanyVVQ789.Remove(companyVVQ789);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyVVQ789Exists(string id)
        {
            return _context.CompanyVVQ789.Any(e => e.CompanyId == id);
        }
    }
}
