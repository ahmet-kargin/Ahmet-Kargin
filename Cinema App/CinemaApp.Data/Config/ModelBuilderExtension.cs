using CinemaApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Config
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData
                (
                    new Film() { FilmId = 1, FilmName = "Recep İvedik 1", Duration = 120, DirectorName = "Şahan GÖKBAKAR", FilmDescription = "Sevgilinizle izlemeyin!!!", Poster = "url" },
                    new Film() { FilmId = 2, FilmName = "Recep İvedik 2", Duration = 120, DirectorName = "Şahan GÖKBAKAR", FilmDescription = "Sevgilinizle izlemeyin!!!", Poster = "url" },
                    new Film() { FilmId = 3, FilmName = "Recep İvedik 3", Duration = 120, DirectorName = "Şahan GÖKBAKAR", FilmDescription = "Sevgilinizle izlemeyin!!!", Poster = "url" },
                    new Film() { FilmId = 4, FilmName = "Recep İvedik 4", Duration = 120, DirectorName = "Şahan GÖKBAKAR", FilmDescription = "Sevgilinizle izlemeyin!!!", Poster = "url" },
                    new Film() { FilmId = 5, FilmName = "Recep İvedik 5", Duration = 120, DirectorName = "Şahan GÖKBAKAR", FilmDescription = "Sevgilinizle izlemeyin!!!", Poster = "url" },
                    new Film() { FilmId = 6, FilmName = "Recep İvedik 6", Duration = 120, DirectorName = "Şahan GÖKBAKAR", FilmDescription = "Sevgilinizle izlemeyin!!!", Poster = "url" }
                );

            modelBuilder.Entity<Category>().HasData
                (
                new Category() { CategoryId = 1, CategoryName = "Komedi" },
                new Category() { CategoryId = 2, CategoryName = "Aile" },
                new Category() { CategoryId = 3, CategoryName = "Korku" }
                );

            modelBuilder.Entity<FilmCategory>().HasData
                (
                new FilmCategory() { FilmId = 1, CategoryId = 1 },
                new FilmCategory() { FilmId = 1, CategoryId = 2 },
                new FilmCategory() { FilmId = 2, CategoryId = 1 },
                new FilmCategory() { FilmId = 2, CategoryId = 3 },
                new FilmCategory() { FilmId = 3, CategoryId = 1 },
                new FilmCategory() { FilmId = 4, CategoryId = 1 },
                new FilmCategory() { FilmId = 5, CategoryId = 2 },
                new FilmCategory() { FilmId = 6, CategoryId = 2 }


                );
        }
    }
}
