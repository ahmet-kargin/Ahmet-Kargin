using BusReservation.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Concrete
{
    public class TicketContext:DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ChooseSeat> ChooseSeats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TicketDb");
        }
    }
}
