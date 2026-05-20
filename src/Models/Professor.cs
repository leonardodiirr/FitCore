class Professor : Usuario
{
    public string Cref { get; set; }
    public string Especialidade { get; set; }
    public decimal Salario { get; set; }

    public Professor(string nome, string email, string cpf, string telefone,
                     DateTime dataNascimento, string cref, string especialidade, decimal salario)
                     : base(nome, email, cpf, telefone, dataNascimento)
    {
        this.Cref = cref;
        this.Especialidade = especialidade;
        this.Salario = salario;
    }
}