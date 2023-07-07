using System;
using System.Collections.Generic;

namespace HotelReservation.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? RoomNumber { get; set; }

    public string? CustomerName { get; set; }

    public int? AdultCount { get; set; }

    public int? ChildCount { get; set; }

    public long? PhoneNumber { get; set; }

    public double? RoomCost { get; set; }

    public virtual RoomDetail? RoomNumberNavigation { get; set; }
}
