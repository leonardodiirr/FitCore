class Pagamento
{
    public Aluno Aluno { get; set; }
    public Plano Plano { get; set; }
    public int Id { get; set; }
    public decimal Valor { get; set; }
    public DateTime? DataPagamento { get; set; }
    public StatusPagamento Status { get; set; }
    public FormaPagamento FormaPagamento { get; set; }
    public DateTime DataVencimento { get; set; }

    public Pagamento(Aluno aluno, Plano plano, decimal valor, FormaPagamento formaPagamento, DateTime dataVencimento)
    {
        this.Aluno = aluno;
        this.Plano = plano;
        this.Valor = valor;
        this.FormaPagamento = formaPagamento;
        this.DataVencimento = dataVencimento;
        this.DataPagamento = null;
        this.Status = StatusPagamento.Pendente;
    }

    public void Confirmar()
    {
        this.Status = StatusPagamento.Pago;
        this.DataPagamento = DateTime.Now;
    }

    public void Cancelar()
    {
        this.Status = StatusPagamento.Cancelado;
        this.DataPagamento = null;
    }


}