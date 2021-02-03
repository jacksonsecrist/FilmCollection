using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public static class TempStorage
    {
        private static List<Film> filmCollection = new List<Film>();

        public static IEnumerable<Film> FilmCollection => filmCollection;

        public static void AddFilm(Film newFilm)
        {
            filmCollection.Add(newFilm);
        }
    }
}
