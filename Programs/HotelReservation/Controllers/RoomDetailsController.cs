using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelReservation.Models;
using HotelReservation.Repository.Room_Services;

namespace HotelReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomDetailsController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomDetailsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        // GET: api/RoomDetails
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Booking>?>> GetRoomDetails()
        {
            return Ok(await _roomService.GetRoomDetails());
        }

        // GET: api/RoomDetails/5
        [HttpGet("{id}")]
        


        public async Task<ActionResult<RoomDetail>> GetRoomDetail(int id)
        {
            var room = await _roomService.GetRoomDetail(id);

            if (room == null)
            {
                return NotFound("Room id not matching");
            }

            return Ok(room);
        }

        // PUT: api/RoomDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]

        public async Task<List<RoomDetail>?> PutRoomDetail(int id, RoomDetail room)
        {
            return await _roomService.PutRoomDetail(id, room);
        }

        // POST: api/RoomDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]

        public async Task<ActionResult<RoomDetail>> PostRoomDetail(RoomDetail room)
        {
            var rooms = await _roomService.PostRoomDetail(room);
            return Ok(rooms);
        }

        // DELETE: api/RoomDetails/5
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<RoomDetail>>> DeleteBooking(int id)
        {
            var room = await _roomService.DeleteBooking(id);

            if (room == null)
            {
                return NotFound("Room id not matching");
            }
            return Ok(room);
        }
    }
}
