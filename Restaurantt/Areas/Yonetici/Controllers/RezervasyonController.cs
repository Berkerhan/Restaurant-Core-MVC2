﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurantt.Data;
using Restaurantt.Models;

namespace Restaurantt.Areas.Yonetici.Controllers
{
    [Area("Yonetici")]
    [Authorize]
    public class RezervasyonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RezervasyonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Yonetici/Rezervasyon
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rezervasyons.ToListAsync());
        }

        // GET: Yonetici/Rezervasyon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervasyon = await _context.Rezervasyons
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rezervasyon == null)
            {
                return NotFound();
            }

            return View(rezervasyon);
        }

        // GET: Yonetici/Rezervasyon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Yonetici/Rezervasyon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,TelefonNo,Sayi,Saat,Tarih")] Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rezervasyon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rezervasyon);
        }

        // GET: Yonetici/Rezervasyon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervasyon = await _context.Rezervasyons.FindAsync(id);
            if (rezervasyon == null)
            {
                return NotFound();
            }
            return View(rezervasyon);
        }

        // POST: Yonetici/Rezervasyon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,TelefonNo,Sayi,Saat,Tarih")] Rezervasyon rezervasyon)
        {
            if (id != rezervasyon.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rezervasyon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezervasyonExists(rezervasyon.ID))
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
            return View(rezervasyon);
        }

        // GET: Yonetici/Rezervasyon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervasyon = await _context.Rezervasyons
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rezervasyon == null)
            {
                return NotFound();
            }

            return View(rezervasyon);
        }

        // POST: Yonetici/Rezervasyon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezervasyon = await _context.Rezervasyons.FindAsync(id);
            _context.Rezervasyons.Remove(rezervasyon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RezervasyonExists(int id)
        {
            return _context.Rezervasyons.Any(e => e.ID == id);
        }
    }
}
