   using System.Collections.Concurrent;

   namespace Sonify_POO;
   
   public class Music
   {
      
      public Music(Band artist)
      {
         Artist = artist;
      }
      
      public string Name { get; set; }
      public Band Artist { get;}
      public int Duration { get; set; }
      public bool Available { get;} // Leitura e escrita - Propriedade

      public string Description => $"A Música: {Name} - Pertence a Banda {Artist} - Com a duração de {Duration} Minutos"; // Leitura (Get) - Propriedade, usando lambda function

      public void Play()
      {
         Console.WriteLine($"Nome: {Name} - Artista: {Artist} - Duração: {Duration} - Disponível: {Available}");
         if (Available)
         {
            Console.WriteLine("Disponivel para reprodução.");
         }
         else
         {
            Console.WriteLine("Música indisponível.");
         }
      }
   } 