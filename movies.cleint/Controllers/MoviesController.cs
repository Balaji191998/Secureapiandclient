using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using movies.cleint.Apimodels;
using movies.cleint.Data;
using movies.cleint.Models;

namespace movies.cleint.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly IMoviesservices _context;

        public MoviesController(IMoviesservices context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            await LogTokenAndClaims();
            return View(await _context.GetCustomers());
        }

        public async Task LogTokenAndClaims()
        {
            var identitytoken = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.IdToken);
            Debug.WriteLine($"Identity Token:{identitytoken}");
            foreach (var claim in User.Claims)
            {
                Debug.WriteLine($"claim Type:{claim.Type}-claim value:{claim.Value}");
            }
        }
        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var movies = await _context.Movies
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (movies == null)
            //{
            //    return NotFound();
            //}

            //return View(movies);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Genere,Releasedate,Owner")] Movies movies)
        {
            return View();
            //if (ModelState.IsValid)
            //{
            //    _context.Add(movies);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(movies);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var movies = await _context.Movies.FindAsync(id);
            //if (movies == null)
            //{
            //    return NotFound();
            //}
            //return View(movies);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Genere,Releasedate,Owner")] Movies movies)
        {
            return View();
            ////if (id != movies.Id)
            ////{
            ////    return NotFound();
            ////}

            ////if (ModelState.IsValid)
            ////{
            ////    try
            ////    {
            ////        _context.Update(movies);
            ////        await _context.SaveChangesAsync();
            ////    }
            ////    catch (DbUpdateConcurrencyException)
            ////    {
            ////        if (!MoviesExists(movies.Id))
            ////        {
            ////            return NotFound();
            ////        }
            ////        else
            ////        {
            ////            throw;
            ////        }
            ////    }
            ////    return RedirectToAction(nameof(Index));
            ////}
            ////return View(movies);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var movies = await _context.Movies
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (movies == null)
            //{
            //    return NotFound();
            //}

            //return View(movies);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();
            //var movies = await _context.Movies.FindAsync(id);
            //_context.Movies.Remove(movies);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        private bool MoviesExists(int id)
        {
            return true;
            //return _context.Movies.Any(e => e.Id == id);
        }
    }
}
