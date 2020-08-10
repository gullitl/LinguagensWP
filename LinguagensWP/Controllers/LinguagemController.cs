using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Asp.LinguagensWP.Models;
using LinguagensWP.DataAccess;

namespace Asp.netCoreMVCCRUD.Controllers
{
    public class LinguagemController : Controller
    {
        private readonly AppDbContext _context;

        public LinguagemController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Linguagem
        public async Task<IActionResult> Index()
        {
            return View(await _context.Linguagens.ToListAsync());
        }


        // GET: Linguagem/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Linguagem());
            else
                return View(_context.Linguagens.Find(id));
        }

        // POST: Linguagem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("LinguagemId,Nome,Autor,DataCricao,Descricao")] Linguagem linguagem)
        {
            if (ModelState.IsValid)
            {
                if (linguagem.LinguagemId == 0)
                    _context.Add(linguagem);
                else
                    _context.Update(linguagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linguagem);
        }


        // GET: Linguagem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var linguagem =await _context.Linguagens.FindAsync(id);
            _context.Linguagens.Remove(linguagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
