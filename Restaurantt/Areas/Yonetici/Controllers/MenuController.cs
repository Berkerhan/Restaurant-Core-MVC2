﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurantt.Data;
using Restaurantt.Models;

namespace Restaurantt.Areas.Yonetici.Controllers
{
    [Area("Yonetici")]
    [Authorize]
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _whe;

        public MenuController(ApplicationDbContext context, IWebHostEnvironment whe)
        {
            _context = context;
            _whe = whe;
        }

        // GET: Yonetici/Menu
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Menus.Include(m => m.Kategori);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Yonetici/Menu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .Include(m => m.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // GET: Yonetici/Menu/Create
        public IActionResult Create()
        {
            ViewData["KategoriID"] = new SelectList(_context.Kategoris, "Id", "Name");
            return View();
        }

        // POST: Yonetici/Menu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Menu menu)
        {
            if (ModelState.IsValid)

            {

                var files = HttpContext.Request.Form.Files;
                //IF DOSYA KONTROLÜ YAPTIM
                if (files.Count > 0)
                {
                    var fileName = Guid.NewGuid().ToString();
                    //RESİM EKLEMEK İÇİN PATH METODU KULLANILIR
                    //RESMİ KAYDETMEK İSTEDİĞİM DOSYA YOLUNU BELİRTTİM
                    var uploads = Path.Combine(_whe.WebRootPath, @"WebSite\Menu");
                    var extn = Path.GetExtension(files[0].FileName);
                    //MENÜ RESMİNİ IF İLE KONTROL ETTİM
                    //MEN ALANI BOŞ DEĞİLSE RESİMLERİ EKLER.
                    if (menu.Image != null)
                    {
                        var ImagePath = Path.Combine(_whe.WebRootPath, menu.Image.TrimStart('\\'));

                        //MENÜ SİLİNİRSE MENÜYE AİT RESMİ DE MENU DOSYASINDAN SİLMESİNİ SAĞLADIM.
                        if (System.IO.File.Exists(ImagePath))
                        {
                            System.IO.File.Delete(ImagePath);

                        }
                    }
                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extn), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }
                    menu.Image = @"\WebSite\Menu\" + fileName + extn;
                }
                _context.Add(menu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(menu);
        }

        // GET: Yonetici/Menu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
            ViewData["KategoriID"] = new SelectList(_context.Kategoris, "Id", "Name", menu.KategoriID);
            return View(menu);
        }

        // POST: Yonetici/Menu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Menu menu)
        {

            if (ModelState.IsValid)
            {

                var files = HttpContext.Request.Form.Files;
                //IF DOSYA KONTROLÜ YAPTIM
                if (files.Count > 0)
                {
                    var fileName = Guid.NewGuid().ToString();
                    //RESİM EKLEMEK İÇİN PATH METODU KULLANILIR
                    //RESMİ KAYDETMEK İSTEDİĞİM DOSYA YOLUNU BELİRTTİM
                    var uploads = Path.Combine(_whe.WebRootPath, @"WebSite\menu");
                    var extn = Path.GetExtension(files[0].FileName);
                    //MENÜ RESMİNİ IF İLE KONTROL ETTİM
                    //MENÜ ALANI BOŞ DEĞİLSE RESİMLERİ EKLER.
                    if (menu.Image != null)
                    {
                        var ImagePath = Path.Combine(_whe.WebRootPath, menu.Image.TrimStart('\\'));

                        //MENÜ SİLİNİRSE MENÜYE AİT RESMİ DE MENU DOSYASINDAN SİLMESİNİ SAĞLADIM.
                        if (System.IO.File.Exists(ImagePath))
                        {
                            System.IO.File.Delete(ImagePath);

                        }
                    }
                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extn), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }
                    menu.Image = @"\WebSite\menu\" + fileName + extn;
                }


                _context.Update(menu);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(menu);
        }

        // GET: Yonetici/Menu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .Include(m => m.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // POST: Yonetici/Menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
          


            var menu = await _context.Menus.FindAsync(id);
            var ImagePath = Path.Combine(_whe.WebRootPath, menu.Image.TrimStart('\\'));

            //MENÜ SİLİNİRSE MENÜYE AİT RESMİ DE MENU DOSYASINDAN SİLMESİNİ SAĞLADIM.
            if (System.IO.File.Exists(ImagePath))
            {
                System.IO.File.Delete(ImagePath);

            }

            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.Id == id);
        }
    }
}
