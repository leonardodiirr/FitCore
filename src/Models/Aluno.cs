class Aluno : Pessoa
{
    public string Plano { get; set; }
    public DateTime DataMatricula { get; set; }

    public Aluno(string nome, int idade, string email, string cpf, string plano)
        : base(nome, idade, email, cpf)
    {
        this.Plano = plano;
        this.DataMatricula = DateTime.Now;
    }
}