﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Reservation.Models;

namespace Reservation.Controllers
{
    public class ReservationsController : ApiController
    {
        private ReservationContext db = new ReservationContext();

        // GET: api/Reservations
        public IQueryable<Reservations> GetReservations()
        {
            return db.Reservations;
        }

        // GET: api/Reservations/5
        [ResponseType(typeof(Reservations))]
        public async Task<IHttpActionResult> GetReservations(int id)
        {
            Reservations reservations = await db.Reservations.FindAsync(id);
            if (reservations == null)
            {
                return NotFound();
            }

            return Ok(reservations);
        }

        // PUT: api/Reservations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutReservations(int id, Reservations reservations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reservations.ReservationID)
            {
                return BadRequest();
            }

            db.Entry(reservations).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(reservations);
        }

        // POST: api/Reservations
        [ResponseType(typeof(Reservations))]
        public async Task<IHttpActionResult> PostReservations(Reservations reservations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reservations.Add(reservations);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = reservations.ReservationID }, reservations);
        }

        // DELETE: api/Reservations/5
        [ResponseType(typeof(Reservations))]
        public async Task<IHttpActionResult> DeleteReservations(int id)
        {
            Reservations reservations = await db.Reservations.FindAsync(id);
            if (reservations == null)
            {
                return NotFound();
            }

            db.Reservations.Remove(reservations);
            await db.SaveChangesAsync();

            return Ok(reservations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReservationsExists(int id)
        {
            return db.Reservations.Count(e => e.ReservationID == id) > 0;
        }
    }
}