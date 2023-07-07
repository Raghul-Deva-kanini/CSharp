using HotelReservation.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Repository.Room_Services
{
    public class RoomService:IRoomService
    {
        public HotelReservationContext _hotelReservationContext;

        public RoomService(HotelReservationContext hotelReservationContext)
        {
            _hotelReservationContext = hotelReservationContext;
        }

        public async Task<List<RoomDetail>?> GetRoomDetails()
        {
            var room = await _hotelReservationContext.RoomDetails.ToListAsync();
            return room;
        }

        public async Task<RoomDetail>? GetRoomDetail(int id)
        {
            var room = await _hotelReservationContext.RoomDetails.FindAsync(id);
            if (room is null)
            {
                return null;
            }
            return room;
        }

        public async Task<List<RoomDetail>?> PutRoomDetail(int id, RoomDetail room)
        {
            var rooms = await _hotelReservationContext.RoomDetails.FindAsync(id);
            if (rooms is null)
            {
                return null;
            }

            rooms.RoomType = room.RoomType;
            rooms.Cost = room.Cost;
            
            await _hotelReservationContext.SaveChangesAsync();
            return await _hotelReservationContext.RoomDetails.ToListAsync();
        }

        public async Task<List<RoomDetail>> PostRoomDetail(RoomDetail room)
        {
            _hotelReservationContext.RoomDetails.Add(room);
            await _hotelReservationContext.SaveChangesAsync();
            return await _hotelReservationContext.RoomDetails.ToListAsync();
        }

        public async Task<List<RoomDetail>> DeleteBooking(int id)
        {
            var room = _hotelReservationContext.RoomDetails.Find(id);
            _hotelReservationContext.Remove(room);
            await _hotelReservationContext.SaveChangesAsync();
            return await _hotelReservationContext.RoomDetails.ToListAsync();
        }
    }
}
