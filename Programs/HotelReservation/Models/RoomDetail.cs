using System;
using System.Collections.Generic;

namespace HotelReservation.Models;

public partial class RoomDetail
{
    public int RoomNumber { get; set; }

    public string? RoomType { get; set; }

    public double? Cost { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
