class Aluno : Usuario
{
    public string Matricula { get; set; }
    public string Objetivo { get; set; }
    public NivelTreino NivelTreino { get; set; }
    public DateTime DataInicioPlano { get; set; }
    public DateTime DataFimPlano { get; set; }
    public StatusPlano StatusPlano { get; set; }
    public List<Treino> Treinos { get; set; }
    public List<Pagamento> Pagamentos { get; set; }
    public List<CheckIn> CheckIns { get; set; }

    public Aluno(string nome, string email, string cpf, string telefone,
                 DateTime dataNascimento, string objetivo, NivelTreino nivelTreino)
        : base(nome, email, cpf, telefone, dataNascimento)
    {
        this.Matricula = GerarMatricula();
        this.Objetivo = objetivo;
        this.NivelTreino = nivelTreino;
        this.DataInicioPlano = DateTime.Now;
        this.StatusPlano = StatusPlano.Ativo;
        this.Treinos = new List<Treino>();
        this.Pagamentos = new List<Pagamento>();
        this.CheckIns = new List<CheckIn>();
    }

    private string GerarMatricula()
    {
        return "FIT" + DateTime.Now.ToString("yyyyMMddHHmmss");
    }
}