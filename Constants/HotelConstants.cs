using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HotelAccounting.Constants
{
    public static class HotelConstants
    {
        public enum RoomTypes
        {
            Econom = 1,
            Standart = 2,
            Premium = 3
        }
        public enum ReservationTypes
        {
            In = 1,
            Out = 2,
        }

        public static Dictionary<RoomTypes, double> Price = new Dictionary<RoomTypes, double>()
        {
            {RoomTypes.Econom, 500 },
            {RoomTypes.Standart, 1200 },
            {RoomTypes.Premium, 3000 },
        };

        public static Dictionary<RoomTypes, string> RoomType = new Dictionary<RoomTypes, string>()
        {
            {RoomTypes.Econom, "Економ" },
            {RoomTypes.Standart, "Стандарт" },
            {RoomTypes.Premium, "Преміум" },
        };

        public static Dictionary<ReservationTypes, string> ReservationType = new Dictionary<ReservationTypes, string>()
        {
            {ReservationTypes.In, "Заселено" },
            {ReservationTypes.Out, "Виселено" },
        };
    }
}