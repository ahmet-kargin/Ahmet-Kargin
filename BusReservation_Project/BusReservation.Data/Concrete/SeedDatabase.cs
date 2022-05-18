using BusReservation.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Concrete
{
    public class SeedDatabase
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


                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);

                }
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);

                }

                context.SaveChanges();
            }
        }

        private static Direction[] Directions =
        {
            new Direction(){ DirectionId=1, Date="10.05.2022", Time="18.00",Price=500},
            new Direction(){ DirectionId=2, Date="11.05.2022", Time="19.00",Price=600},
            new Direction(){ DirectionId=3, Date="12.05.2022", Time="20.00",Price=700},
            };

        private static Ticket[] Tickets =
        {
            new Ticket(){TicketId=1, PassengerName="Ahmet", PassengerSurname="Metin,", PassengerMail="ahmetmetin@gmail.com",PassengerTel="05533656555", TicketDepartureCity="İstanbul", TicketArrivalCity="Malatya", SeatNo=1, Price=500, DirectionId=1},
            new Ticket(){TicketId=2, PassengerName="Furkan", PassengerSurname="Kaya", PassengerMail="furkan@gmail.com",PassengerTel="05533656555", TicketDepartureCity="İstanbul", TicketArrivalCity="Ankara", SeatNo=2, Price=600, DirectionId=2},
            new Ticket(){TicketId=3, PassengerName="Lale", PassengerSurname="Kar", PassengerMail="lale@gmail.com",PassengerTel="05533656555",TicketDepartureCity="Malatya", TicketArrivalCity="İstanbul", SeatNo=3, Price=500, DirectionId=1},
            new Ticket(){TicketId=4, PassengerName="Osman", PassengerSurname="Lale", PassengerMail="osman@gmail.com",PassengerTel="05533656555", TicketDepartureCity="İstanbul", TicketArrivalCity="Trabzon", SeatNo=4, Price=700, DirectionId=3},
            new Ticket(){TicketId=5, PassengerName="Şerif", PassengerSurname="Boz", PassengerMail="şerif@gmail.com",PassengerTel="05533656555",TicketDepartureCity="Trabzon", TicketArrivalCity="İstanbul", SeatNo=5, Price=700, DirectionId=3},
            new Ticket(){TicketId=6, PassengerName="Meltem", PassengerSurname="Derin", PassengerMail="derin@gmail.com",PassengerTel="05533656555", TicketDepartureCity="İstanbul", TicketArrivalCity="Malatya", SeatNo=6, Price=500, DirectionId=1},
            new Ticket(){TicketId=7, PassengerName="Ali", PassengerSurname="Metin", PassengerMail="metin@gmail.com",PassengerTel="05533656555", TicketDepartureCity="İstanbul", TicketArrivalCity="Malatya", SeatNo=7, Price=500, DirectionId=1},
            new Ticket(){TicketId=8, PassengerName="Şule", PassengerSurname="Beyaz", PassengerMail="beyaz@gmail.com",PassengerTel="05533656555", TicketDepartureCity="İstanbul", TicketArrivalCity="Trabzon", SeatNo=8, Price=700, DirectionId=3},
            new Ticket(){TicketId=9, PassengerName="Beyazit", PassengerSurname="Lale", PassengerMail="beyazit@gmail.com",PassengerTel="05533656555", TicketDepartureCity="İstanbul", TicketArrivalCity="Ankara", SeatNo=9, Price=600, DirectionId=2}

        };
        private static Sehir[] Sehirs =
        {
            new Sehir(){ SehirId=1, SehirAd= "İstanbul"},
            new Sehir(){ SehirId=2, SehirAd= "Kocaeli"},
            new Sehir(){ SehirId=3, SehirAd= "Kütahya"},
            new Sehir(){ SehirId=4, SehirAd= "Afyon"},
            new Sehir(){ SehirId=5, SehirAd= "Isparta"},

            new Sehir(){ SehirId=6, SehirAd= "Samsun"},
            new Sehir(){ SehirId=7, SehirAd= "Ordu"},
            new Sehir(){ SehirId=8, SehirAd= "Rize"}
        };
    }
}
