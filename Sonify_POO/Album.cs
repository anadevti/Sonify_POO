namespace Sonify_POO;


public class Album
{
    private List<Music> Musics = new List<Music>();
    
    public string Name { get; set; }
    
    
    public int Total_Duration => Musics.Sum(m => m.Duration);
    
    
    public void Add_Music(Music music)
    {
        Musics.Add(music);
    }
    
    public void Play_Musics()
    {
        Console.WriteLine($"Tocando todas as músicas do álbum: {Name}:\n");
        foreach (var music in Musics)
        {
            Console.WriteLine($"Música: {music.Name}");
            
        }
        
        Console.WriteLine($"\nPara ouvir este álbum por inteiro você precisa de: {Total_Duration} segundos.");
    }   
}