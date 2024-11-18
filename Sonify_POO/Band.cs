namespace Sonify_POO;

public class Band
{
    private List<Album> albums = new List<Album>();
    
    public string Name { get; set; }
    
    public void Add_Album(Album album)
    {
        albums.Add(album);
    }
    
    public void Play_Albums()
    {
        Console.WriteLine($"Tocando todos os álbuns da banda: {Name}\n");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Name}, com duração total de {album.Total_Duration} segundos.");
            //album.Play_Musics();
        }
    }
}