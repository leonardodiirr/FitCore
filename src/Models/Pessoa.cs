class Pessoa
{
    private int _idade;
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; } 
    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value >= 0)
            {
                _idade = value;
            }
            else
            {
                throw new ArgumentException("Idade não pode ser negativa.");
            }
        }
    }


    public Pessoa(string nome, int idade, string email, string cpf)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Email = email;
        this.Cpf = cpf;
    }

  

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"CPF: {Cpf}");
    }
}