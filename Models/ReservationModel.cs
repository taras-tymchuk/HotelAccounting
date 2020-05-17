using System;
using HotelAccounting.Models;

namespace HotelAccounting.Models
{
    public class ReservationModel
    {
        public ReservationModel(string nameOfPerson, RoomModel room, string type, DateTime dateIn, DateTime dateOut, double totalPrice)
        {
            NameOfPerson = nameOfPerson;
            Room = room;
            Type = type;
            DateIn = dateIn;
            DateOut = dateOut;
            TotalPrice = totalPrice;
        }

        public string NameOfPerson { get; }
        public RoomModel Room { get; }
        public string Type { get; set; }
        public DateTime DateIn { get; }
        public DateTime DateOut { get; }
        public double TotalPrice { get;  }
    }
}