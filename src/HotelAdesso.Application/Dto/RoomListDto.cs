namespace HotelAdesso.Application.Dto
{
    public class RoomListDto:BaseEntityDto
    {
        public int Floor { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string RoomStatusDescription { get; set; }
        public string RoomTypeDescription { get; set; }
        public string HotelName { get; set; }
    }
}
