class TreinoExercicio
{
    public int Id { get; set; }
    public ExercicioCatalogo Exercicio { get; set; }
    public int Ordem { get; set; }
    public int Series { get; set; }
    public int Repeticoes { get; set; }
    public double Carga { get; set; }
    public int TempoDescanso { get; set; }
    public string Observacoes { get; set; }

    public TreinoExercicio(ExercicioCatalogo exercicio, int ordem, int series,
                            int repeticoes, double carga, int tempoDescanso)
    {
        this.Exercicio = exercicio;
        this.Ordem = ordem;
        this.Series = series;
        this.Repeticoes = repeticoes;
        this.Carga = carga;
        this.TempoDescanso = tempoDescanso;
        this.Observacoes = "";
    }

    public void ExibirExercicio()
    {
        Console.WriteLine($"Exercício {Ordem}: {Exercicio.Nome}");
        Console.WriteLine($"Grupo Muscular: {Exercicio.GrupoMuscular}");
        Console.WriteLine($"Séries: {Series} | Repetições: {Repeticoes} | Carga: {Carga}kg");
        Console.WriteLine($"Descanso: {TempoDescanso} segundos");
        if (Observacoes != "")
            Console.WriteLine($"Obs: {Observacoes}");
    }
}