class ExercicioCatalogo
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set
        {
            if (value > 0)
                _id = value;
            else
                throw new ArgumentException("Id deve ser maior que zero.");
        }
    }

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