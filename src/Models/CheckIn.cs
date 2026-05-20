class CheckIn
{
    public int Id { get; set; }
    public DateTime DataHoraEntrada { get; set; }
    public DateTime? DataHoraSaida { get; set; }
    public Aluno Aluno { get; set; }

    public CheckIn(Aluno aluno)
    {
        this.Aluno = aluno;
        this.DataHoraEntrada = DateTime.Now;
        this.DataHoraSaida = null;
    }
}