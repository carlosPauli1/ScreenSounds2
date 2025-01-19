class Album
{
    private List<Musica> musicaList = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int duracaoTotal => musicaList.Sum(musica => musica.Duracao);

    public void AddMusica(Musica musica)
    {
        musicaList.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}:\n");
        foreach (var musica in musicaList)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"Este album possui {duracaoTotal} segundos");
    }
}