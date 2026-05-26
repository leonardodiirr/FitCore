static class SeedData
{
    public static void Carregar(
        List<Aluno> alunos,
        List<Professor> professores,
        List<Plano> planos,
        List<ExercicioCatalogo> exercicios)
    {
        // Planos
        Plano planoMensal = new Plano("Mensal", "Acesso completo por 1 mês", 99.90m, 1);
        Plano planoTrimestral = new Plano("Trimestral", "Acesso completo por 3 meses", 249.90m, 3);
        Plano planoAnual = new Plano("Anual", "Acesso completo por 12 meses", 799.90m, 12);
        planos.Add(planoMensal);
        planos.Add(planoTrimestral);
        planos.Add(planoAnual);

        // Professores
        Professor prof1 = new Professor("Carlos Silva", "carlos@fitcore.com", "111.111.111-11",
            "(11) 99999-1111", new DateTime(1985, 3, 15), "123456-G/SP", "Musculação", 3500m);
        Professor prof2 = new Professor("Ana Souza", "ana@fitcore.com", "222.222.222-22",
            "(11) 99999-2222", new DateTime(1990, 7, 22), "654321-G/SP", "Funcional", 3200m);
        professores.Add(prof1);
        professores.Add(prof2);

        // Exercícios
        ExercicioCatalogo supino = new ExercicioCatalogo("Supino Reto", "Peitoral",
            "Exercício com barra para peitoral", NivelTreino.Intermediario);
        ExercicioCatalogo agachamento = new ExercicioCatalogo("Agachamento Livre", "Quadríceps",
            "Agachamento com barra", NivelTreino.Intermediario);
        ExercicioCatalogo rosca = new ExercicioCatalogo("Rosca Direta", "Bíceps",
            "Exercício para bíceps com barra", NivelTreino.Iniciante);
        ExercicioCatalogo triceps = new ExercicioCatalogo("Tríceps Corda", "Tríceps",
            "Exercício para tríceps na polia", NivelTreino.Iniciante);
        exercicios.Add(supino);
        exercicios.Add(agachamento);
        exercicios.Add(rosca);
        exercicios.Add(triceps);

        // Alunos
        Aluno aluno1 = new Aluno("Leonardo", "leo@email.com", "333.333.333-33",
            "(27) 99999-3333", new DateTime(2004, 5, 10), "Hipertrofia", NivelTreino.Iniciante);
        aluno1.Plano = planoMensal;
        aluno1.DataFimPlano = aluno1.DataInicioPlano.AddMonths(planoMensal.DuracaoMeses);

        Aluno aluno2 = new Aluno("Maria Oliveira", "maria@email.com", "444.444.444-44",
            "(11) 99999-4444", new DateTime(1995, 8, 20), "Emagrecimento", NivelTreino.Iniciante);
        aluno2.Plano = planoTrimestral;
        aluno2.DataFimPlano = aluno2.DataInicioPlano.AddMonths(planoTrimestral.DuracaoMeses);
        aluno2.StatusPlano = StatusPlano.Inadimplente;

        Aluno aluno3 = new Aluno("Pedro Costa", "pedro@email.com", "555.555.555-55",
            "(21) 99999-5555", new DateTime(1998, 12, 5), "Condicionamento", NivelTreino.Intermediario);
        aluno3.Plano = planoAnual;
        aluno3.DataFimPlano = DateTime.Now.AddDays(5);
        aluno3.StatusPlano = StatusPlano.Ativo;

        alunos.Add(aluno1);
        alunos.Add(aluno2);
        alunos.Add(aluno3);

        // Treino de exemplo
        Treino treino1 = new Treino(prof1, aluno1, "Treino A — Peito e Tríceps",
            "Hipertrofia", NivelTreino.Iniciante, DateTime.Now.AddMonths(3));
        treino1.Exercicios.Add(new TreinoExercicio(supino, 1, 4, 12, 40.0, 60));
        treino1.Exercicios.Add(new TreinoExercicio(triceps, 2, 3, 15, 15.0, 45));
        prof1.Treinos.Add(treino1);
        aluno1.Treinos.Add(treino1);
    }
}