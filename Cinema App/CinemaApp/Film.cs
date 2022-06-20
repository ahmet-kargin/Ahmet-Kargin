using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Entity
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public int Duration { get; set; }
        public string Poster { get; set; }
        public string FilmDescription { get; set; }
        public string DirectorName { get; set; }
        public List<FilmCategory> FilmCategories { get; set; }
    }
}
