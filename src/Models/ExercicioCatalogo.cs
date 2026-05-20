class ExercicioCatalogo
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string GrupoMuscular { get; set; }
    public string Descricao { get; set; }
    public NivelTreino NivelDificuldade { get; set; }

    public ExercicioCatalogo(string nome, string grupoMuscular, string descricao, NivelTreino nivelDificuldade)
    {
        this.Nome = nome;
        this.GrupoMuscular = grupoMuscular;
        this.Descricao = descricao;
        this.NivelDificuldade = nivelDificuldade;
    }
}