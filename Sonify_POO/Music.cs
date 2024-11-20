   using System.Collections.Concurrent;

   namespace Sonify_POO;
   
   public class Music // construtor
   {
      
      public Music(Band artist, string name)
      {
         Artist = artist;
         Name = name;
      }
      
      public string Name { get;}
      public Band Artist { get;}
      public int Duration { get; set; }
      public bool Available { get; set; } // Leitura e escrita - Propriedade

      public string Description => $"A Música: {Name} - Pertence a Banda {Artist} - Com a duração de {Duration} Minutos"; // Leitura (Get) - Propriedade, usando lambda function

      public void Play_Tech()
      {
         Console.WriteLine($"A música: {Name} Do Artista: {Artist.Name} Com a Duração de: {Duration} segundos está:");
         if (Available)
         {
            Console.WriteLine("Disponivel para reprodução.");
         }
         else
         {
            Console.WriteLine("Indisponível para reprodução.");
         }
      }
   } 