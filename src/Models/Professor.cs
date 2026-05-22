class Professor : Usuario, IExibeTreino
{
    public string Cref { get; set; }
    public string Especialidade { get; set; }
    public decimal Salario { get; set; }
    public List<Treino> Treinos { get; set; }

    public Professor(string nome, string email, string cpf, string telefone,
                     DateTime dataNascimento, string cref, string especialidade, decimal salario)
                     : base(nome, email, cpf, telefone, dataNascimento)
    {
        this.Cref = cref;
        this.Especialidade = especialidade;
        this.Salario = salario;
        this.Treinos = new List<Treino>();
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"CREF: {Cref}");
        Console.WriteLine($"Especialidade: {Especialidade}");
        Console.WriteLine($"Salário: R$ {Salario:F2}");
    }

    public void ExibirTreino()
    {
        if (Treinos.Count == 0)
        {
            Console.WriteLine($"Professor {Nome} não montou nenhum treino ainda.");
            return;
        }

        Console.WriteLine($"Treinos montados por Professor {Nome}:");
        foreach (Treino treino in Treinos)        {
            Console.WriteLine($"--> {treino.Nome} | Aluno: {treino.Aluno?.Nome ?? "Não especificado"} | Validade: {treino.DataValidade:dd/MM/yyyy}");
        }
    }
}