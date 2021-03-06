﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CajaPopular;

namespace CajaPopular.Controllers.Vistas
{
    public class balancesController : Controller
    {
        private caja_popular2Entities db = new caja_popular2Entities();

        // GET: balances
        public async Task<ActionResult> Index()
        {
            var balances = db.balances.Include(b => b.solicitante).Include(b => b.usuario);
            return View(await balances.ToListAsync());
        }

        // GET: balances/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            balance balance = await db.balances.FindAsync(id);
            if (balance == null)
            {
                return HttpNotFound();
            }
            return View(balance);
        }

        // GET: balances/Create
        public ActionResult Create()
        {
            ViewBag.id_solicitante = new SelectList(db.solicitantes, "uid", "num_solicitante");
            ViewBag.capturista = new SelectList(db.usuarios, "uid", "departamento");
            return View();
        }

        // POST: balances/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id_solicitante,factura,num_documento,descripcion,cantidad,fecha_captura,fecha_vencimiento,fecha_pago,capturista,borrado,cubierto")] balance balance)
        {
            if (ModelState.IsValid)
            {
                db.balances.Add(balance);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.id_solicitante = new SelectList(db.solicitantes, "uid", "num_solicitante", balance.id_solicitante);
            ViewBag.capturista = new SelectList(db.usuarios, "uid", "departamento", balance.capturista);
            return View(balance);
        }

        // GET: balances/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            balance balance = await db.balances.FindAsync(id);
            if (balance == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_solicitante = new SelectList(db.solicitantes, "uid", "num_solicitante", balance.id_solicitante);
            ViewBag.capturista = new SelectList(db.usuarios, "uid", "departamento", balance.capturista);
            return View(balance);
        }

        // POST: balances/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id_solicitante,factura,num_documento,descripcion,cantidad,fecha_captura,fecha_vencimiento,fecha_pago,capturista,borrado,cubierto")] balance balance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(balance).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.id_solicitante = new SelectList(db.solicitantes, "uid", "num_solicitante", balance.id_solicitante);
            ViewBag.capturista = new SelectList(db.usuarios, "uid", "departamento", balance.capturista);
            return View(balance);
        }

        // GET: balances/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            balance balance = await db.balances.FindAsync(id);
            if (balance == null)
            {
                return HttpNotFound();
            }
            return View(balance);
        }

        // POST: balances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            balance balance = await db.balances.FindAsync(id);
            db.balances.Remove(balance);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
