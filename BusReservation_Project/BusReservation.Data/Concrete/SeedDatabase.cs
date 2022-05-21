﻿using BusReservation.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new TicketContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Directions.Count() == 0)
                {
                    context.Directions.AddRange(Directions);
                }


                //if (context.Tickets.Count() == 0)S
                //{
                //    context.Tickets.AddRange(Tickets);

                //}
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);

                }

                context.SaveChanges();
            }
        }

        private static Direction[] Directions =
        {
            new Direction(){ DirectionId=1, StartCity="İstanbul", FinishCity="Malatya", Date=DateTime.Now.Date,Price=500},
            new Direction(){ DirectionId=2, StartCity="Malatya", FinishCity="İstanbul", Date=DateTime.Now.Date,Price=600},
            new Direction(){ DirectionId=3, StartCity="Ankara", FinishCity="Malatya", Date=DateTime.Now.Date,Price=700},
            };

        private static Ticket[] Tickets =
        {
            new Ticket(){TicketId=1, PassengerName="Ahmet", PassengerSurname="Metin,", PassengerMail="ahmetmetin@gmail.com",PassengerTel="05533656555", SeatNo=1, Price=500, DirectionId=1},
            new Ticket(){TicketId=2, PassengerName="Furkan", PassengerSurname="Kaya", PassengerMail="furkan@gmail.com",PassengerTel="05533656555", SeatNo=2, Price=600, DirectionId=2},
            new Ticket(){TicketId=3, PassengerName="Lale", PassengerSurname="Kar", PassengerMail="lale@gmail.com",PassengerTel="05533656555", SeatNo=3, Price=500, DirectionId=1},
            new Ticket(){TicketId=4, PassengerName="Osman", PassengerSurname="Lale", PassengerMail="osman@gmail.com",PassengerTel="05533656555",  SeatNo=4, Price=700, DirectionId=3},
            new Ticket(){TicketId=5, PassengerName="Şerif", PassengerSurname="Boz", PassengerMail="şerif@gmail.com",PassengerTel="05533656555", SeatNo=5, Price=700, DirectionId=3},
            new Ticket(){TicketId=6, PassengerName="Meltem", PassengerSurname="Derin", PassengerMail="derin@gmail.com",PassengerTel="05533656555", SeatNo=6, Price=500, DirectionId=1},
            new Ticket(){TicketId=7, PassengerName="Ali", PassengerSurname="Metin", PassengerMail="metin@gmail.com",PassengerTel="05533656555",  SeatNo=7, Price=500, DirectionId=1},
            new Ticket(){TicketId=8, PassengerName="Şule", PassengerSurname="Beyaz", PassengerMail="beyaz@gmail.com",PassengerTel="05533656555",  SeatNo=8, Price=700, DirectionId=3},
            new Ticket(){TicketId=9, PassengerName="Beyazit", PassengerSurname="Lale", PassengerMail="beyazit@gmail.com",PassengerTel="05533656555", SeatNo=9, Price=600, DirectionId=2}

        };
        private static City[] Cities =
        {
            new City(){ CityId=1, CityName= "İstanbul"},
            new City(){ CityId=2, CityName= "Ankara"},
            new City(){ CityId=3, CityName= "Malatya"},
            new City(){ CityId=4, CityName= "Trabzon"},
            new City(){ CityId=5, CityName= "Muğla"},
            new City(){ CityId=6, CityName= "İzmir"},
            new City(){ CityId=7, CityName= "Samsun"},
            new City(){ CityId=8, CityName= "Kastamonu"},
            new City(){ CityId=9, CityName= "Mardin"}
        };
    }
}
