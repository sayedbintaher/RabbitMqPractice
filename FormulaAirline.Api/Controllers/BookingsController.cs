using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaAirline.Api.Data;
using FormulaAirline.Api.models;
using FormulaAirline.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaAirline.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly IMessageProducer _messageProducer;
        private readonly ApplicationDbContext _db;
        public BookingsController(IMessageProducer messageProducer, ApplicationDbContext db)
        {
            _messageProducer = messageProducer;
            _db = db;
        }

        [HttpPost]
        public IActionResult CreatingBooking(Booking newBooking)
        {
            if (!ModelState.IsValid) return BadRequest();

            _db.Bookings.Add(newBooking);
            _messageProducer.SendMessages<Booking>(newBooking);
            return Ok();
        }
    }
}