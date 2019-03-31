using LandonHotel.Data;
using LandonHotel.Repositories;

namespace LandonHotel.Services
{
    public class BookingService : IBookingService
    {
        public readonly IRoomsRepository _roomRepo;

        public BookingService(IBookingsRepository bookingRepo, IRoomsRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public bool IsBookingValid(int roomId, Booking booking)
        {
            var guestIsSmoking = booking.IsSmoking;
            var guestIsBringingPets = booking.HasPets;
            var numberOfGuests = booking.NumberOfGuests;
            //if (guestIsSmoking)
            //{
            //    return false;
            //}
            //return true;
            return !guestIsSmoking;
        }

        public int CalculateBookingCost(int roomId, Booking booking)
        {
            return 0;
        }
    }
}
