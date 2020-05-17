using System.Collections.Generic;
using HotelAccounting.Constants;
using HotelAccounting.Models;

namespace HotelAccounting.InMemoryDb
{
    public static class Rooms
    {
        public static List<RoomModel> List = new List<RoomModel>()
        {
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Econom], "11", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Econom], 2 ),
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Econom], "12", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Econom], 2 ),
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Econom], "13", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Econom]+300, 3 ),
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Econom], "21", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Econom]+300, 3 ),
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Econom], "22", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Econom]+500, 4 ),
                                        
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Standart], "23", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Standart], 2 ),
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Standart], "31", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Standart], 2 ),
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Standart], "32", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Standart], 2 ),
                                        
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Premium], "33", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Premium], 2 ),
            new RoomModel(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Premium], "41", Constants.HotelConstants.Price[Constants.HotelConstants.RoomTypes.Premium]+700, 4 ),
        };
    }
}