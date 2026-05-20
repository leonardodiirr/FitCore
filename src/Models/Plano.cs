class Plano
{
    public int Id { get; set; }

    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int DuracaoMeses { get; set; }   
    public bool Ativo { get; set; }

    public Plano(string nome, string descricao, decimal preco, int duracaoMeses)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco;
        this.DuracaoMeses = duracaoMeses;
        this.Ativo = true;
    }

}