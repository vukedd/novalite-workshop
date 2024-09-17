using LINQ.ProductionCode.Cinemas;

namespace LINQ.Tests;

public class CinemaTests
{
      List<Movie> movies = new List<Movie> {
         new Movie("The Shawshank Redemption", 9.3, 1994),
         new Movie("The Godfather", 9.2, 1972),
         new Movie("Inception", 8.8, 2010),
         new Movie("The Dark Knight", 9.0, 2008),
         new Movie("Parasite", 8.6, 2019),
         new Movie("Interstellar", 8.6, 2014),
         new Movie("The Grand Budapest Hotel", 8.1, 2014),
         new Movie("Joker", 8.4, 2019),
         new Movie("Mad Max: Fury Road", 8.1, 2015),
         new Movie("The Social Network", 7.7, 2010)
     };

    [Test]
    public async Task GetMoviesWithRatingGreaterThanTest()
    {
        double testRating = 8.5;
        Cinema testCinema = new Cinema(movies);

        List<Movie> result = testCinema.GetMoviesWithRatingGreaterThan(testRating);

        await Verify(result);
    }

    [Test]
    public async Task GetTitleOfMoviesOlderThanTest()
    {
        int testYear = 2005;
        Cinema testCinema = new Cinema(movies);

        List<string> result = testCinema.GetTitleOfMoviesOlderThan(testYear);

        await Verify(result);
    }

    [Test]
    public async Task GetMovieWithHighestRatingTest()
    {
        Cinema testCinema = new Cinema(movies);

        Movie result = testCinema.GetMovieWithHighestRating();

        await Verify(result);
    }

    [Test]
    public async Task GetLowestRatedMovieTitleFromYearTest()
    {
        Cinema testCinema = new Cinema(movies);
        int testYear = 2014;

        string result = testCinema.GetLowestRatedMovieTitleFromYear(testYear);

        await Verify(result);
    }

    [Test]
    public async Task GetMoviesAboveAverageRatingTest()
    {
        Cinema testCinema = new Cinema(movies);

        List<Movie> result = testCinema.GetMoviesAboveAverageRating();

        await Verify(result);
    }

    [Test]
    public async Task GetTopMovieTitlesByRating()
    {
        Cinema testCinema = new Cinema(movies);
        int testNumberOfTitles = 3;

        List<string> result = testCinema.GetTopMovieTitlesByRating(testNumberOfTitles);

        await Verify(result);
    }
}
