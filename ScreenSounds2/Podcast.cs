class Podcast
{

    private List<Episodio> episodioList = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodioList.Count;

    public void AddEpisodio(Episodio episodio)
    {
        episodioList.Add(episodio);
    }

    public void ExibeDetalhes()
    {
        Console.WriteLine($"PodCast {Nome} apresentado por {Host} \n");
        foreach (Episodio episodio in episodioList.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Total de episodios: {TotalEpisodios}");
    }
}