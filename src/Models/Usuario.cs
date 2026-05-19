class Usuario
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
    public string Email { get; set; }
    public string Cpf { get; set; } 
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCriacao { get; set; }

 


  public Usuario(string nome, string email, string cpf, string telefone, DateTime dataNascimento)
    {
        this.Nome = nome;
        this.Email = email;
        this.Cpf = cpf;
        this.Telefone = telefone;
        this.DataNascimento = dataNascimento;
        this.Ativo = true;
        this.DataCriacao = DateTime.Now;
    }

    public int CalcularIdade()
    {
        int idade = DateTime.Now.Year - DataNascimento.Year;
        if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            idade--;

        return idade;
    }

   public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"CPF: {Cpf}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Idade: {CalcularIdade()} anos");
        Console.WriteLine($"Ativo: {Ativo}");
    }
}