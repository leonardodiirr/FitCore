Aluno aluno1 = new Aluno("Leonardo", 20, "leo@email.com", "123.456.789-00", "Mensal");

aluno1.ExibirInformacoes(); // método herdado de Pessoa
Console.WriteLine($"Plano: {aluno1.Plano}");
Console.WriteLine($"Matrícula: {aluno1.DataMatricula}");