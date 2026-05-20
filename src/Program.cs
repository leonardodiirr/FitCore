List<Aluno> alunos = new List<Aluno>();
List<Professor> professores = new List<Professor>();
List<Plano> planos = new List<Plano>();
List<ExercicioCatalogo> exercicios = new List<ExercicioCatalogo>();

bool rodando = true;

while (rodando)
{
    Console.Clear();
    Console.WriteLine("╔════════════════════=══╗");
    Console.WriteLine("║      FitCore          ║");
    Console.WriteLine("╠════════════════════=══╣");
    Console.WriteLine("║ 1. Cadastrar Aluno    ║");
    Console.WriteLine("║ 2. Cadastrar Professor║");
    Console.WriteLine("║ 3. Cadastrar Plano    ║");
    Console.WriteLine("║ 4. Cadastrar Exercício║");
    Console.WriteLine("║ 5. Montar Treino      ║");
    Console.WriteLine("║ 6. Ver Treino         ║");
    Console.WriteLine("║ 7. Registrar Check-in ║");
    Console.WriteLine("║ 0. Sair               ║");
    Console.WriteLine("╚══════════════════==═══╝");
    Console.Write("\nEscolha: ");

    string opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            CadastrarAluno(alunos, planos);
            break;
        case "2":
            CadastrarProfessor(professores);
            break;
        case "3":
            CadastrarPlano(planos);
            break;
        case "4":
            CadastrarExercicio(exercicios);
            break;
        case "5":
            MontarTreino(alunos, professores, exercicios);
            break;
        case "6":
            VerTreino(alunos);
            break;
        case "7":
            RegistrarCheckIn(alunos);
            break;
        case "0":
            rodando = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            Console.ReadKey();
            break;
    }
}

void CadastrarPlano(List<Plano> planos)
{
    Console.Clear();
    Console.WriteLine("=== Cadastrar Plano ===\n");

    Console.Write("Nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Descrição: ");
    string descricao = Console.ReadLine()!;

    Console.Write("Preço: ");
    decimal preco = decimal.Parse(Console.ReadLine()!);

    Console.Write("Duração em meses: ");
    int duracao = int.Parse(Console.ReadLine()!);

    Plano plano = new Plano(nome, descricao, preco, duracao);
    planos.Add(plano);

    Console.WriteLine("\nPlano cadastrado com sucesso!");
    Console.ReadKey();
}

void CadastrarExercicio(List<ExercicioCatalogo> exercicios)
{
    Console.Clear();
    Console.WriteLine("=== Cadastrar Exercício ===\n");

    Console.Write("Nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Grupo Muscular: ");
    string grupoMuscular = Console.ReadLine()!;

    Console.Write("Descrição: ");
    string descricao = Console.ReadLine()!;

    Console.WriteLine("Nível de Dificuldade:");
    Console.WriteLine("0 - Iniciante");
    Console.WriteLine("1 - Intermediario");
    Console.WriteLine("2 - Avancado");
    Console.Write("Escolha: ");
    NivelTreino nivel = (NivelTreino)int.Parse(Console.ReadLine()!);

    ExercicioCatalogo exercicio = new ExercicioCatalogo(nome, grupoMuscular, descricao, nivel);
    exercicios.Add(exercicio);

    Console.WriteLine("\nExercício cadastrado com sucesso!");
    Console.ReadKey();
}

void CadastrarProfessor(List<Professor> professores)
{
    Console.Clear();
    Console.WriteLine("=== Cadastrar Professor ===\n");

    Console.Write("Nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Email: ");
    string email = Console.ReadLine()!;

    Console.Write("CPF: ");
    string cpf = Console.ReadLine()!;

    Console.Write("Telefone: ");
    string telefone = Console.ReadLine()!;

    Console.Write("Data de Nascimento (dd/MM/yyyy): ");
    DateTime dataNascimento = DateTime.Parse(Console.ReadLine()!);

    Console.Write("CREF: ");
    string cref = Console.ReadLine()!;

    Console.Write("Especialidade: ");
    string especialidade = Console.ReadLine()!;

    Console.Write("Salário: ");
    decimal salario = decimal.Parse(Console.ReadLine()!);

    Professor professor = new Professor(nome, email, cpf, telefone, dataNascimento, cref, especialidade, salario);
    professores.Add(professor);

    Console.WriteLine($"\nProfessor {nome} cadastrado com sucesso!");
    Console.ReadKey();
}

void CadastrarAluno(List<Aluno> alunos, List<Plano> planos)
{
    Console.Clear();
    Console.WriteLine("=== Cadastrar Aluno ===\n");

    if (planos.Count == 0)
    {
        Console.WriteLine("Nenhum plano cadastrado. Cadastre um plano primeiro.");
        Console.ReadKey();
        return;
    }

    Console.Write("Nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Email: ");
    string email = Console.ReadLine()!;

    Console.Write("CPF: ");
    string cpf = Console.ReadLine()!;

    Console.Write("Telefone: ");
    string telefone = Console.ReadLine()!;

    Console.Write("Data de Nascimento (dd/MM/yyyy): ");
    DateTime dataNascimento = DateTime.Parse(Console.ReadLine()!);

    Console.Write("Objetivo: ");
    string objetivo = Console.ReadLine()!;

    Console.WriteLine("\nNível de Treino:");
    Console.WriteLine("0 - Iniciante");
    Console.WriteLine("1 - Intermediario");
    Console.WriteLine("2 - Avancado");
    Console.Write("Escolha: ");
    NivelTreino nivel = (NivelTreino)int.Parse(Console.ReadLine()!);

    Console.WriteLine("\nPlanos disponíveis:");
    for (int i = 0; i < planos.Count; i++)
    {
        Console.WriteLine($"{i} - {planos[i].Nome} | R$ {planos[i].Preco} | {planos[i].DuracaoMeses} meses");
    }
    Console.Write("Escolha o plano: ");
    int indicePlano = int.Parse(Console.ReadLine()!);
    Plano planoEscolhido = planos[indicePlano];

    Aluno aluno = new Aluno(nome, email, cpf, telefone, dataNascimento, objetivo, nivel);
    aluno.Plano = planoEscolhido;
    aluno.DataFimPlano = aluno.DataInicioPlano.AddMonths(planoEscolhido.DuracaoMeses);
    alunos.Add(aluno);

    Console.WriteLine($"\nAluno {nome} cadastrado! Matrícula: {aluno.Matricula}");
    Console.ReadKey();
}

void MontarTreino(List<Aluno> alunos, List<Professor> professores, List<ExercicioCatalogo> exercicios)
{
    Console.Clear();
    Console.WriteLine("=== Montar Treino ===\n");

    if (alunos.Count == 0 || professores.Count == 0 || exercicios.Count == 0)
    {
        Console.WriteLine("Cadastre ao menos 1 aluno, 1 professor e 1 exercício antes.");
        Console.ReadKey();
        return;
    }

    Console.WriteLine("Professores:");
    for (int i = 0; i < professores.Count; i++)
        Console.WriteLine($"{i} - {professores[i].Nome}");
    Console.Write("Escolha o professor: ");
    Professor professor = professores[int.Parse(Console.ReadLine()!)];

    Console.WriteLine("\nAlunos:");
    for (int i = 0; i < alunos.Count; i++)
        Console.WriteLine($"{i} - {alunos[i].Nome}");
    Console.Write("Escolha o aluno: ");
    Aluno aluno = alunos[int.Parse(Console.ReadLine()!)];

    Console.Write("\nNome do treino: ");
    string nome = Console.ReadLine()!;

    Console.Write("Objetivo: ");
    string objetivo = Console.ReadLine()!;

    Console.WriteLine("\nNível:");
    Console.WriteLine("0 - Iniciante");
    Console.WriteLine("1 - Intermediario");
    Console.WriteLine("2 - Avancado");
    Console.Write("Escolha: ");
    NivelTreino nivel = (NivelTreino)int.Parse(Console.ReadLine()!);

    Console.Write("\nValidade do treino (dd/MM/yyyy): ");
    DateTime dataValidade = DateTime.Parse(Console.ReadLine()!);

    Treino treino = new Treino(professor, aluno, nome, objetivo, nivel, dataValidade);

    bool adicionandoExercicios = true;
    int ordem = 1;

    while (adicionandoExercicios)
    {
        Console.Clear();
        Console.WriteLine($"=== Adicionando Exercícios — Treino: {nome} ===\n");

        Console.WriteLine("Exercícios disponíveis:");
        for (int i = 0; i < exercicios.Count; i++)
            Console.WriteLine($"{i} - {exercicios[i].Nome} | {exercicios[i].GrupoMuscular}");

        Console.Write("\nEscolha o exercício (-1 para terminar): ");
        int indice = int.Parse(Console.ReadLine()!);

        if (indice == -1)
        {
            adicionandoExercicios = false;
            break;
        }

        ExercicioCatalogo exercicioEscolhido = exercicios[indice];

        Console.Write("Séries: ");
        int series = int.Parse(Console.ReadLine()!);

        Console.Write("Repetições: ");
        int repeticoes = int.Parse(Console.ReadLine()!);

        Console.Write("Carga (kg): ");
        double carga = double.Parse(Console.ReadLine()!);

        Console.Write("Descanso (segundos): ");
        int descanso = int.Parse(Console.ReadLine()!);

        TreinoExercicio te = new TreinoExercicio(exercicioEscolhido, ordem, series, repeticoes, carga, descanso);
        treino.Exercicios.Add(te);
        ordem++;

        Console.WriteLine($"\n{exercicioEscolhido.Nome} adicionado!");
        Console.ReadKey();
    }

    professor.Treinos.Add(treino);
    aluno.Treinos.Add(treino);

    Console.WriteLine($"\nTreino '{nome}' montado com sucesso para {aluno.Nome}!");
    Console.ReadKey();
}

void VerTreino(List<Aluno> alunos)
{
    Console.Clear();
    Console.WriteLine("=== Ver Treino ===\n");

    if (alunos.Count == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
        Console.ReadKey();
        return;
    }

    Console.WriteLine("Alunos:");
    for (int i = 0; i < alunos.Count; i++)
        Console.WriteLine($"{i} - {alunos[i].Nome}");
    Console.Write("Escolha o aluno: ");
    Aluno aluno = alunos[int.Parse(Console.ReadLine()!)];

    Console.Clear();
    Console.WriteLine($"=== Treinos de {aluno.Nome} ===\n");

    if (aluno.Treinos.Count == 0)
    {
        Console.WriteLine("Nenhum treino cadastrado para este aluno.");
        Console.ReadKey();
        return;
    }

    foreach (Treino treino in aluno.Treinos)
    {
        Console.WriteLine($"Treino: {treino.Nome}");
        Console.WriteLine($"Objetivo: {treino.Objetivo}");
        Console.WriteLine($"Nível: {treino.Nivel}");
        Console.WriteLine($"Professor: {treino.Professor.Nome}");
        Console.WriteLine($"Validade: {treino.DataValidade:dd/MM/yyyy}");
        Console.WriteLine($"\nExercícios:");

        foreach (TreinoExercicio te in treino.Exercicios)
            te.ExibirExercicio();

        Console.WriteLine(new string('─', 30));
    }

    Console.ReadKey();
}

void RegistrarCheckIn(List<Aluno> alunos)
{
    Console.Clear();
    Console.WriteLine("=== Registrar Check-in ===\n");

    if (alunos.Count == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
        Console.ReadKey();
        return;
    }

    Console.WriteLine("Alunos:");
    for (int i = 0; i < alunos.Count; i++)
        Console.WriteLine($"{i} - {alunos[i].Nome}");
    Console.Write("Escolha o aluno: ");
    Aluno aluno = alunos[int.Parse(Console.ReadLine()!)];

    CheckIn checkIn = new CheckIn(aluno);
    aluno.CheckIns.Add(checkIn);

    Console.WriteLine($"\nCheck-in registrado para {aluno.Nome} às {checkIn.DataHoraEntrada:HH:mm}!");
    Console.ReadKey();
}