using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagementApp.Data;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.Controllers
{
    public class BookRequestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookRequestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookRequest
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookRequests.ToListAsync());
        }

        // GET: BookRequest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookRequest = await _context.BookRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookRequest == null)
            {
                return NotFound();
            }

            return View(bookRequest);
        }

        // GET: BookRequest/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookRequest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookTitle,AuthorName,AuthorSurname")] BookRequest bookRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookRequest);
        }

        // GET: BookRequest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookRequest = await _context.BookRequests.FindAsync(id);
            if (bookRequest == null)
            {
                return NotFound();
            }
            return View(bookRequest);
        }

        // POST: BookRequest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookTitle,AuthorName,AuthorSurname")] BookRequest bookRequest)
        {
            if (id != bookRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookRequestExists(bookRequest.Id))
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
            return View(bookRequest);
        }

        // GET: BookRequest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookRequest = await _context.BookRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookRequest == null)
            {
                return NotFound();
            }

            return View(bookRequest);
        }

        // POST: BookRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookRequest = await _context.BookRequests.FindAsync(id);
            _context.BookRequests.Remove(bookRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookRequestExists(int id)
        {
            return _context.BookRequests.Any(e => e.Id == id);
        }
    }
}
