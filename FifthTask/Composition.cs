namespace FifthTask;

public class Composition

{ 
    public string Name { get; set; }
    public string Author { get; set; }
    public int CreationDate { get; set; }
    public int Duration { get; set; }
    public CompositionType Genre { get; set; }
    public string MusicalInstrument { get; set; }
    public Composition(string name, string author, int creationDate, int duration, CompositionType genre,
        string musicalInstrument)
    {
        Name = name;
        Author = author;
        CreationDate = creationDate;
        Duration = duration;
        Genre = genre;
        MusicalInstrument = musicalInstrument;
    }

    public void Description()
    {
        Console.WriteLine("Название композиции: " + Name);
        Console.WriteLine("Автор композиции: " + Author);
        Console.WriteLine("Дата создания композиции: " + CreationDate);
        Console.WriteLine("Длительность: " + Duration);
        Console.WriteLine("Жанр: " + Genre);
        Console.WriteLine("Музыкальный инструмент: " + MusicalInstrument);
    }

    public void Play()
    {
        Console.WriteLine("Играю" + Duration + "минут");
    }
}