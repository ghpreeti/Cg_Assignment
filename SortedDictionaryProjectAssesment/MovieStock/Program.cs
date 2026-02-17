// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

public class Movie
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public int Ratings { get; set; }
}

public class Program
{
    // In your template this is already provided.
    public static List<Movie> MovieList = new List<Movie>();

    public void AddMovie(string movieDetails)
    {
        // Expected: Title,Artist,Genre,Ratings
        string[] parts = movieDetails.Split(',');

        Movie m = new Movie
        {
            Title = parts[0].Trim(),
            Artist = parts[1].Trim(),
            Genre = parts[2].Trim(),
            Ratings = int.Parse(parts[3].Trim())
        };

        MovieList.Add(m);
    }

    public List<Movie> ViewMoviesByGenre(string genre)
    {
        // If your evaluation is strictly case-sensitive, replace OrdinalIgnoreCase with Ordinal.
        return MovieList
            .Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Movie> ViewMoviesByRatings()
    {
        return MovieList
            .OrderBy(m => m.Ratings)
            .ToList();
    }

    public static void Main()
    {
        Program p = new Program();

        Console.Write("Enter number of movies: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter movie details (Title,Artist,Genre,Ratings):");
            p.AddMovie(Console.ReadLine());
        }

        Console.Write("Enter genre to search: ");
        string g = Console.ReadLine();

        var byGenre = p.ViewMoviesByGenre(g);
        if (byGenre.Count == 0)
        {
            Console.WriteLine($"No Movies found in genre '{g}'");
        }
        else
        {
            Console.WriteLine("Movies by Genre:");
            foreach (var m in byGenre)
                Console.WriteLine($"{m.Title} | {m.Artist} | {m.Genre} | {m.Ratings}");
        }

        Console.WriteLine("Movies sorted by Ratings:");
        var sorted = p.ViewMoviesByRatings();
        foreach (var m in sorted)
            Console.WriteLine($"{m.Title} | {m.Artist} | {m.Genre} | {m.Ratings}");
    }
}