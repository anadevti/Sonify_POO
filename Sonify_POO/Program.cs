using Sonify_POO;

Album Queen = new Album();
Queen.Name = "A night at the opera";

Music Love_Of_My_Life = new Music();
Love_Of_My_Life.Name = "Love of my life";
Love_Of_My_Life.Duration = 213;

Music Bohemian_Rhapsody = new Music();
Bohemian_Rhapsody.Name = "Bohemian Rhapsody";
Bohemian_Rhapsody.Duration = 354;

Queen.Add_Music(Love_Of_My_Life);
Queen.Add_Music(Bohemian_Rhapsody);

//Queen.Play_Musics();
Band Queen_Band = new Band();
Queen_Band.Name = "Queen";
Queen_Band.Add_Album(Queen);
Queen_Band.Play_Albums();