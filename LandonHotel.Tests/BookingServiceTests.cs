using LandonHotel.Data;
using LandonHotel.Services;
using System;
using Xunit;

namespace LandonHotel.Tests
{
    public class BookingServiceTests
    {
        [Fact]
        public void IsBookingValid_Nonsmoker_Valid()
        {
            var service = new BookingService(null, null);
            var isValid = service.IsBookingValid(1, new Booking() { IsSmoking = false });

            Assert.True(isValid);
        }

        [Fact]
        public void IsBookingValid_Smoker_Invalid()
        {
            var service = new BookingService(null, null);
            var isValid = service.IsBookingValid(1, new Booking() { IsSmoking = true });

            Assert.False(isValid);
        } 
    }
}
