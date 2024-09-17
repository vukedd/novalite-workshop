namespace LINQ.ProductionCode.Cinemas;

public class Cinema
{
    public List<Movie> Movies { get; private set; }
    
    public Cinema(List<Movie> movies)
    {
        Movies = movies;
    }

    // 01
    public List<Movie> GetMoviesWithRatingGreaterThan(double rating)
    {
        var result = Movies.Where(m => m.Rating > rating).ToList();

        return result;
    }

    // 02
    public List<string> GetTitleOfMoviesOlderThan(int year)
    {
        var result = Movies.Where(m => m.Year < year).Select(m => m.Title).ToList();

        return result;
    }

    // 03
    public Movie GetMovieWithHighestRating()
    {
        var highestRatedMovie = Movies.MaxBy(m => m.Rating);
        
        return highestRatedMovie;
    }

    // 04
    public string GetLowestRatedMovieTitleFromYear(int year)
    {
        var lowestRatedMovie = Movies.Where(m => m.Year == year).MinBy(m => m.Rating).Title;

        return lowestRatedMovie;
    }

    // 05
    public List<Movie> GetMoviesAboveAverageRating()
    {
        double averageRating = Movies.Average(m => m.Rating);

        var moviesAboveAverageRating = Movies.Where(m => m.Rating > averageRating).ToList();

        return moviesAboveAverageRating;
    }

     // 06
     public List<string> GetTopMovieTitlesByRating(int numberOfTitles)
     {
         var topMovieTitles = Movies.OrderByDescending(m => m.Rating).Take(numberOfTitles).Select(m => m.Title).ToList();
     
         return topMovieTitles;
     }
}
