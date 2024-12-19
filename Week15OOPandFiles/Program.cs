
List<movie> myMovies = new List<movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    movie newMovie = new movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach (movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\PGRclass_data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);
    return File.ReadAllLines(filePath); // keeps files in memory
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }
    public movie(string title, string year)
    {
        this.title = title;
        this.year = year;
    }

}