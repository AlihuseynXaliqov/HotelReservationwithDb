using HotelReservation.AppDbContext;
using HotelReservation.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation;

class Program
{
    static void Main(string[] args)
    {
        DbContextt dbContext = new DbContextt();
        
        Hotel hotel = new Hotel()
        {
            name = "Hotel",
            description = "Hotel description"
        };
        Room room = new Room()
        {
            name = "Room3",
            type = "single",
            HotelId = 1
        };
        
        /*dbContext.Add(hotel);*/
        Hotel hotels;


        // hotel update et
        /*Hotel updateHotel=dbContext.Hotels.FirstOrDefault(x=>x.id==1);

        if (updateHotel != null)
        {
            updateHotel.name = "newHotelName";
            updateHotel.description = "Hotel descriptioni deyisdim ";
            dbContext.SaveChanges();
        }
        else
        {
            Console.WriteLine("Hotel not found");
        }*/
        
        //id gore remove et
        /*dbContext.Hotels.Remove(dbContext.Hotels.FirstOrDefault(x=>x.id==1));*/
        
        //room name gore hotel name tap
        /* room2 =dbContext.Rooms.Include(x=>x.hotel).FirstOrDefault(x=>x.name=="Room3");
        Console.WriteLine(room2.hotel.name);*/
        
//-------------------------------------------------------------------------------------------------
        
        Room room2;
        /*dbContext.Add(room);*/
        
        //room id gore name filter
        /* room2 = dbContext.Rooms.FirstOrDefault(x => x.id == 2);
        Console.WriteLine(room2.name);*/
        
        //hotel in daxilinde ne qeder room var hamisini getir
        /* hotels = dbContext.Hotels.Include(x=>x.rooms).FirstOrDefault(x => x.id == 1);

        foreach (var item in hotels.rooms)
        {
            Console.WriteLine(item.name);
        }*/

        
        //update etmek 
        /*Room updateRooms = dbContext.Rooms.FirstOrDefault(x => x.id == 1);
        if (updateRooms != null)
        {
            updateRooms.name = "new room yaratmaq";
            updateRooms.type = "newType";
            dbContext.SaveChanges();
        }
        else
        {
            Console.WriteLine("Hotel not found");
        }*/
        
        //id gore silmek 
        /*dbContext.Rooms.Remove(dbContext.Rooms.Find(1));*/
        dbContext.SaveChanges();
        
        

    }
}