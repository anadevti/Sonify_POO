using Sonify_POO;

Band Queen_Band = new Band("Queen");

Album Queen = new Album("A night at the opera");

Music Love_Of_My_Life = new Music(Queen_Band, "Love of my life")
{
    // inicializando propriedades de leitura e escrita
    Duration = 213,
    Available = true,
};

Music Bohemian_Rhapsody = new Music(Queen_Band, "Bohemian Rhapsody")
{
    // inicializando propriedades de leitura e escrita
    Duration = 354,
    Available = false,
};

Queen.Add_Music(Love_Of_My_Life);
Queen.Add_Music(Bohemian_Rhapsody);
Queen_Band.Add_Album(Queen);
Queen_Band.Play_Albums();
Love_Of_My_Life.Play_Tech();
Bohemian_Rhapsody.Play_Tech();

