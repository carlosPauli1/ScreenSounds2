class Album
{
    private List<Musica> musicaList = new List<Musica>();
    public string Nome { get; set; }

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