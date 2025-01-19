//// Objeto para a Musica
//Musica musica1 =  new Musica();
//Musica musica2 =  new Musica();

//// Informaçoes da musica
//musica1.Nome = "the emptiness machine";
//musica1.Artista = "Linking Park";
//musica1.Duracao = 255;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.DescricaoResumida);

//musica2.Nome = "Vertigo";
//musica2.Artista = "U2";
//musica2.Duracao = 267;
//musica2.Disponivel = false;
//Console.WriteLine(musica2.DescricaoResumida);



//Banda queen = new Banda("Queen");

//Album Queen = new Album("A night at the Opera");


//Musica musica1 = new Musica(queen, "Love of my Life")
//{
//    Duracao = 213,
//    Disponivel = true
//};

//Musica musica2 = new Musica(queen, "bohemian rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false
//};

//Queen.AddMusica(musica1);
//Queen.AddMusica(musica2);

//Queen.ExibirMusicasAlbum();

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//queen.AdicionarAlbum(Queen);
//queen.ExibirDisocgrafia();


Episodio ep1 = new(1, "Piloto", 45);
ep1.AddConvidado("Priscila");
ep1.AddConvidado("Carlos");


Episodio ep2 = new(2, "Umbanda", 87);
ep2.AddConvidado("Antonio");
ep2.AddConvidado("Rosangela");

Podcast podcast = new("um bom papo podcast", "Carlos");
podcast.AddEpisodio(ep1);
podcast.AddEpisodio(ep2);
podcast.ExibeDetalhes();