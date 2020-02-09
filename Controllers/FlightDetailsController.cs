using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hankins_MIS4200.DAL;
using Hankins_MIS4200.Models;

namespace Hankins_MIS4200.Controllers
{
    public class FlightDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: FlightDetails
        public ActionResult Index()
        {
            var flightDetails = db.FlightDetails.Include(f => f.Passenger).Include(f => f.Plane);
            return View(flightDetails.ToList());
        }

        // GET: FlightDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            if (flightDetail == null)
            {
                return HttpNotFound();
            }
            return View(flightDetail);
        }

        // GET: FlightDetails/Create
        public ActionResult Create()
        {
            ViewBag.passengerId = new SelectList(db.Passengers, "passengerId", "passengerName");
            ViewBag.planeId = new SelectList(db.Planes, "planeId", "planeName");
            return View();
        }

        // POST: FlightDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "flightId,depatureAirport,arrivalAirport,departureTime,arrivalTime,planeId,passengerId")] FlightDetail flightDetail)
        {
            if (ModelState.IsValid)
            {
                db.FlightDetails.Add(flightDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.passengerId = new SelectList(db.Passengers, "passengerId", "passengerName", flightDetail.passengerId);
            ViewBag.planeId = new SelectList(db.Planes, "planeId", "planeName", flightDetail.planeId);
            return View(flightDetail);
        }

        // GET: FlightDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            if (flightDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.passengerId = new SelectList(db.Passengers, "passengerId", "passengerName", flightDetail.passengerId);
            ViewBag.planeId = new SelectList(db.Planes, "planeId", "planeName", flightDetail.planeId);
            return View(flightDetail);
        }

        // POST: FlightDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "flightId,depatureAirport,arrivalAirport,departureTime,arrivalTime,planeId,passengerId")] FlightDetail flightDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flightDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.passengerId = new SelectList(db.Passengers, "passengerId", "passengerName", flightDetail.passengerId);
            ViewBag.planeId = new SelectList(db.Planes, "planeId", "planeName", flightDetail.planeId);
            return View(flightDetail);
        }

        // GET: FlightDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            if (flightDetail == null)
            {
                return HttpNotFound();
            }
            return View(flightDetail);
        }

        // POST: FlightDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            db.FlightDetails.Remove(flightDetail);
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
}
