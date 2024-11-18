namespace HotelReservation.Model;

public class Room
{
    public int id { get; set; }
    public string name { get; set; }
    public string type { get; set; }
    public int HotelId { get; set; }
    public Hotel hotel  { get; set; }
}