using HotelReservation.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Repository.Booking_Services
{
    public class BookingService:IBookingService
    {
        public HotelReservationContext _hotelReservationContext;

        public BookingService(HotelReservationContext hotelReservationContext)
        {
            _hotelReservationContext= hotelReservationContext;
        }

        public async Task<List<Booking>?> GetBookings()
        {
            var booking = await _hotelReservationContext.Bookings.ToListAsync();
            return booking;
        }

        public async Task<Booking>? GetBooking(int id)
        {
            var booking = await _hotelReservationContext.Bookings.FindAsync(id);
            if (booking is null)
            {
                return null;
            }
            return booking;
        }

        public async Task<List<Booking>?> PutBooking(int id, Booking book)
        {
            var booking = await _hotelReservationContext.Bookings.FindAsync(id);
            if (booking is null)
            {
                return null;
            }

            booking.RoomNumber = book.RoomNumber;
            booking.CustomerName = book.CustomerName;
            booking.AdultCount = book.AdultCount;
            booking.ChildCount = book.ChildCount;
            booking.PhoneNumber = book.PhoneNumber;
            booking.RoomNumber = book.RoomNumber;

            await _hotelReservationContext.SaveChangesAsync();
            return await _hotelReservationContext.Bookings.ToListAsync();
        }

        public async Task<List<Booking>> PostBooking(Booking book)
        {
            _hotelReservationContext.Bookings.Add(book);
            await _hotelReservationContext.SaveChangesAsync();
            return await _hotelReservationContext.Bookings.ToListAsync();
        }

        public async Task<List<Booking>> DeleteBooking(int id)
        {
            var book = _hotelReservationContext.Bookings.Find(id);
            _hotelReservationContext.Remove(book);
            await _hotelReservationContext.SaveChangesAsync();
            return await _hotelReservationContext.Bookings.ToListAsync();
        }
    }
}
