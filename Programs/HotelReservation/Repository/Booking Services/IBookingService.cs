using HotelReservation.Models;

namespace HotelReservation.Repository.Booking_Services
{
    public interface IBookingService
    {
        Task<List<Booking>?> GetBookings();
        Task<Booking>? GetBooking(int id);
        Task<List<Booking>?> PutBooking(int id, Booking book);
        Task<List<Booking>> PostBooking(Booking book);
        Task<List<Booking>> DeleteBooking(int id);
    }
}
