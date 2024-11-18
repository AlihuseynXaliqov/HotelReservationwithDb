namespace HotelReservation.Model;

public class Hotel
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public List<Room> rooms { get; set; } 
}