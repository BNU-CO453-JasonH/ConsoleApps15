﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUI.Data;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class PhotoPostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhotoPostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PhotoPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Photos.ToListAsync());
        }

        // GET: PhotoPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photoPost = await _context.Photos
                .Include(m => m.Comments)
                .FirstOrDefaultAsync(m => m.PostID == id);
            if (photoPost == null)
            {
                return NotFound();
            }

            HttpContext.Session.SetString("CONTROLLER", "PHOTO");

            return View(photoPost);
        }

        // GET: PhotoPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhotoPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Filename,Caption,PostID,Username,Timestamp,Likes")] PhotoPost photoPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(photoPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(photoPost);
        }

        // GET: PhotoPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photoPost = await _context.Photos.FindAsync(id);
            if (photoPost == null)
            {
                return NotFound();
            }
            return View(photoPost);
        }

        // POST: PhotoPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Filename,Caption,PostID,Username,Timestamp,Likes")] PhotoPost photoPost)
        {
            if (id != photoPost.PostID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photoPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotoPostExists(photoPost.PostID))
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
            return View(photoPost);
        }

        // GET: PhotoPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photoPost = await _context.Photos
                .FirstOrDefaultAsync(m => m.PostID == id);
            if (photoPost == null)
            {
                return NotFound();
            }

            return View(photoPost);
        }

        // POST: PhotoPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photoPost = await _context.Photos.FindAsync(id);
            _context.Photos.Remove(photoPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Like(int id)
        {
            var photoPost = _context.Photos.Find(id);

            if (photoPost == null)
            {
                return NotFound();
            }

            photoPost.Like();

            try
            {
                _context.Update(photoPost);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoPostExists(photoPost.PostID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction("Details", new { id = id });
        }

        public ActionResult Unlike(int id)
        {
            var photoPost = _context.Photos.Find(id);

            if (photoPost == null)
            {
                return NotFound();
            }

            photoPost.Unlike();

            try
            {
                _context.Update(photoPost);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoPostExists(photoPost.PostID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction("Details", new { id = id });
        }

        private bool PhotoPostExists(int id)
        {
            return _context.Photos.Any(e => e.PostID == id);
        }
    }
}
