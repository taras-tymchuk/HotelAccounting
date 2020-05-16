using HotelAccounting.Constants;

namespace HotelAccounting.Models
{
    public class RoomModel
    {
        public RoomModel(string type, string number, double price, int numberOfSeats)
        {
            Type = type;
            Number = number;
            Price = price;
            NumberOfSeats = numberOfSeats;
        }

        public RoomModel()
        {
            
        }

        public string Type { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public int NumberOfSeats { get; set; }
    }
}