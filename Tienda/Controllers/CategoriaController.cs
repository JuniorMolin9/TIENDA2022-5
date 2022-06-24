﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tienda.Datos;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class CategoriaController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoriaController(ApplicationDbContext db)
        {
            _db= db;
        }


        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = _db.Categoria;
            return View(lista);
        }



        public IActionResult Crear()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Categoria categoria)
        {
            _db.Categoria.Add(categoria);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }












        public IActionResult Edit()
        {
            return View();
        }




    }
}
