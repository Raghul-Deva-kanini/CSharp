using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelReservation.Models;
using HotelReservation.Repository.Booking_Services;

namespace HotelReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService= bookingService;
        }

        // GET: api/Bookings
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Booking>?>> GetBookings()
        {
            return Ok(await _bookingService.GetBookings());
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]

        public async Task<ActionResult<Booking>> GetBooking(int id)
        {
            var book = await _bookingService.GetBooking(id);

            if (book == null)
            {
                return NotFound("Booking id not matching");
            }

            return Ok(book);
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<Booking>?> PutBooking(int id, Booking book)
        {
            return await _bookingService.PutBooking(id, book);  
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking book)
        {
            var books = await _bookingService.PostBooking(book);
            return Ok(books);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Booking>>> DeleteBooking(int id)
        {
            var book = await _bookingService.DeleteBooking(id);

            if (book == null)
            {
                return NotFound("Booking id not matching");
            }
            return Ok(book);
        }
    }
}
