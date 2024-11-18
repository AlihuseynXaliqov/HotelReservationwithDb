using HotelReservation.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.AppDbContext;

public class DbContextt:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("server=ALIHUSEYN;database=HotelReservation;trusted_connection=true;Encrypt=false");
    }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Room> Rooms { get; set; }
}