   using System.Collections.Concurrent;

   namespace Sonify_POO;

   class Music
   {
      public string Name { get; set; }
      public string Artist { get; set; }
      public int Duration { get; set; }
      public bool Available { get; set; } // Leitura e escrita - Propriedade

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