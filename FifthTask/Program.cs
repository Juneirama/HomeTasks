using FifthTask;

namespace FirstTask;

class Program
{
    static void Main(string[] args)
    {
        Composition compositionByLudvig = new Composition(
            name: "5-th sonata",
            author: "Ludvig van Bethoven",
            creationDate: 1797,
            duration: 10,
            genre: CompositionType.Classic,
            musicalInstrument: "multiple"
            );
        
        compositionByLudvig.Description();

        compositionByLudvig.Duration = 15;
        
        compositionByLudvig.Description();

        Console.WriteLine(compositionByLudvig.Duration);

        Composition compositionByAnna = new Composition(null, null, 0, 0, default, null);
        
        compositionByAnna.Description();

        compositionByAnna.Name = "Tsaritsa";
        compositionByAnna.Author = "Anna Asti";
        compositionByAnna.Duration = 5;
        

        Composition[] compositions = new[] { compositionByLudvig, compositionByAnna };
        
        int allDuration = 0;
        foreach (var composition in compositions)
        {
            allDuration += composition.Duration;
        }

        Console.WriteLine("Общая длительность" + allDuration);
    }
}    