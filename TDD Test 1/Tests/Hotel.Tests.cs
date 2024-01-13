using Xunit;

namespace Tests
{

    public class BookingTests
    {
        [Fact]
        public void Reserve_a_Room_for_a_single_occupant()
        {
            // Arrange
            var room = new Room(roomName, maxOccupancy)
    
        // Act
        var reservation = room.Reserve(arrivalDate, departureDate, occupant)
    
        // Assert
        Assert.Equal(?, reservation.)
    }

        [Fact]
        public void Reserve_a_Room_for_multiple_occupants()
        {

        }

        [Fact]
        public void Reserving_an_unavailable_room_is_invalid()
        {

        }

        [Fact]
        public void Reserve_a_Room_in_the_past_date_is_invalid()
        {

        }

        public void Reserve_a_Room_with_no_primary_occupant_is_invalid()
        {

        }

        public void Reserve_a_Room_with_no_payment_details_is_invalid()
        {

        }

        // [Fact]
        // public void CheckIn_to_a_Room()
        // {

        // }

        //     [Fact]
        // public void Checkout_from_a_Room()
        // {

        // }

        // [Fact]
        // public void Find_Todays_Arrivals()
        // {

        // }

        // [Fact]
        // public void Find_Tomorrows_Arrivals()
        // {

        // }

        // [Fact]
        // public void Find_Todays_Arrivals()
        // {

        // }

        // [Fact]
        // public void Find_Todays_Departures()
        // {

        // }
    }
}
