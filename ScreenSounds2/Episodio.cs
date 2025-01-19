class Episodio
{
    private List<string> Convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Duracao = duracao;
        Titulo = titulo;
        Ordem = ordem;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo}. ({Duracao}min) - {string.Join(", ", Convidados)}";

    public void AddConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}