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

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();


Album Queen = new Album();
Queen.Nome = "A night at the Opera";


Musica musica1 = new Musica();
musica1.Nome = "Love of my Life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome =  "bohemian rhapsody";
musica2.Duracao = 354;

Queen.AddMusica(musica1);
Queen.AddMusica(musica2);

Queen.ExibirMusicasAlbum();