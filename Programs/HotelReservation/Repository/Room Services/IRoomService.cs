using HotelReservation.Models;

namespace HotelReservation.Repository.Room_Services
{
    public interface IRoomService
    {
        Task<List<RoomDetail>?> GetRoomDetails();

        Task<RoomDetail>? GetRoomDetail(int id);

        Task<List<RoomDetail>?> PutRoomDetail(int id, RoomDetail room);

        Task<List<RoomDetail>> PostRoomDetail(RoomDetail room);

        Task<List<RoomDetail>> DeleteBooking(int id);
    }
}
