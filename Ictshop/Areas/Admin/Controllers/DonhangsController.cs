using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Areas.Admin.Controllers
{
    // Interface representing the DonhangsController functionality
    public interface IDonhangsController
    {
        ActionResult Index();
        ActionResult Details(int? id);
        ActionResult Create();
        ActionResult Xacnhan(int? id);
        ActionResult Edit(int? id);
        ActionResult Delete(int? id);
        ActionResult DeleteConfirmed(int id);
    }

    // DonhangsController class implementing IDonhangsController interface
    public class DonhangsController : Controller, IDonhangsController
    {
        private Qlbanhang db = new Qlbanhang();

        public ActionResult Index()
        {
            var donhangs = db.Donhangs.Include(d => d.Nguoidung);
            return View(donhangs.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhangs.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }

        public ActionResult Create()
        {
            ViewBag.MaNguoidung = new SelectList(db.Nguoidungs, "MaNguoiDung", "Anhdaidien");
            return View();
        }

        public ActionResult Xacnhan(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhangs.Find(id);
            donhang.Tinhtrang = 1;
            db.SaveChanges();
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Madon,Ngaydat,Tinhtrang,Thanhtoan,MaNguoidung,Diachinhanhang")] Donhang donhang)
        {
            if (ModelState.IsValid)
            {
                db.Donhangs.Add(donhang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNguoidung = new SelectList(db.Nguoidungs, "MaNguoiDung", "Anhdaidien", donhang.MaNguoidung);
            return View(donhang);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhangs.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNguoidung = new SelectList(db.Nguoidungs, "MaNguoiDung", "Anhdaidien", donhang.MaNguoidung);
            return View(donhang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Madon,Ngaydat,Tinhtrang,Thanhtoan,MaNguoidung,Diachinhanhang")] Donhang donhang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donhang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNguoidung = new SelectList(db.Nguoidungs, "MaNguoiDung", "Anhdaidien", donhang.MaNguoidung);
            return View(donhang);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhangs.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Donhang donhang = db.Donhangs.Find(id);
            db.Donhangs.Remove(donhang);
            db.SaveChanges();
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

    // Proxy class for DonhangsController
    public class DonhangsControllerProxy : IDonhangsController
    {
        private DonhangsController _donhangsController = new DonhangsController();

        public ActionResult Index()
        {
            // You can perform pre-processing tasks here
            return _donhangsController.Index();
        }

        public ActionResult Details(int? id)
        {
            // You can perform pre-processing tasks here
            return _donhangsController.Details(id);
        }

        public ActionResult Create()
        {
            // You can perform pre-processing tasks here
            return _donhangsController.Create();
        }

        public ActionResult Xacnhan(int? id)
        {
            // You can perform pre-processing tasks here
            return _donhangsController.Xacnhan(id);
        }

        public ActionResult Edit(int? id)
        {
            // You can perform pre-processing tasks here
            return _donhangsController.Edit(id);
        }

        public ActionResult Delete(int? id)
        {
            // You can perform pre-processing tasks here
            return _donhangsController.Delete(id);
        }

        public ActionResult DeleteConfirmed(int id)
        {
            // You can perform pre-processing tasks here
            return _donhangsController.DeleteConfirmed(id);
        }
    }
}
