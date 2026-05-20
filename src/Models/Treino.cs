class Treino
{
    public int Id { get; set; }

    public Professor Professor { get; set; }
    public Aluno Aluno { get; set; }    
    public string Nome { get; set; }
    public string Objetivo { get; set; }
    public NivelTreino Nivel { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataValidade { get; set; }
    public bool Ativo { get; set; }
    public List<TreinoExercicio> Exercicios { get; set; }

    public Treino(Professor professor, Aluno aluno, string nome, string objetivo, NivelTreino nivel, DateTime dataValidade)
    {
        this.Professor = professor;
        this.Aluno = aluno;
        this.Nome = nome;
        this.Objetivo = objetivo;
        this.Nivel = nivel;
        this.DataCriacao = DateTime.Now;
        this.DataValidade = dataValidade;
        this.Ativo = true;
        this.Exercicios = new List<TreinoExercicio>();
    }
}