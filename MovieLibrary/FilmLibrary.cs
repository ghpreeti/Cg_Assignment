using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public class FilmLibrary : IFilmLibrary
    {
        private List<IFilm> _films = null;

        public void AddFilm(IFilm film)
        {
            _films.Add(film);
        }

        public void RemoveFilm(string title)
        {
            if (_films != null)
            {
                IFilm film = _films.Find(f => f.Title == title);
                if (film != null)
                {
                    _films.Remove(film);
                }
            }
        }
        public List<IFilm> GetFilms()
        {
            return _films; 
        }

        public List<IFilm> SearchFilm(string query) { 
        
            return _films.FindAll(f => f.Title.Equals(query) || f.Director.Equals(query));
        }

        public int GetTotalCount()
        {
            return _films.Count;    
        }

    }
}
