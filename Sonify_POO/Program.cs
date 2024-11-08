using Sonify_POO;

Music music1 = new Music(); // instanciando um objeto da classe Music
// atribuindo valores aos atributos do objeto music1:
music1.Name = "Roxane";
music1.Artist = "The Police";
music1.Duration = 273;
music1.Available = true;

Music music2 = new Music(); // instanciando um objeto da classe Music
music2.Name = "Bohemian Rhapsody";
music2.Artist = "Queen";
music2.Duration = 6;
music2.Available = false;

// chamando o método Play() para os objetos music1 e music2:
music1.Play();
music2.Play();