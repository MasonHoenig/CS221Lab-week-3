using System;
public class Movie
{
    private string title;
    private int year;
    private double rating;
    public Movie(string title, int year, double rating)
    {
        Title = title;
        Year = year;
        Rating = rating;
    }
    public override string ToString()
    {
        return $"{Title} ({Year}) - {Rating} / 5.0";
    }
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Title cannot be null or empty");
            }
            title = value;
        }
    }
    public int Year
    {
        get => year;
        set
        {
            if (value < 1900 || value > DateTime.Now.Year)
            {
                throw new Exception($"Year must be between 1900 and { DateTime.Now.Year }");
            }
            year = value;
        }
    }
    public double Rating
    {
        get => rating;
        set
        {
            if (value < 0d || value > 5d)
            {
                throw new Exception("Rating must be between 0 and 5");
            }
            rating = value;
        }
    }
}
