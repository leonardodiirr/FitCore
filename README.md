# 💪 FitCore — Sistema de Gestão de Academia

> Sistema completo de gestão para academias de musculação, desenvolvido em C# / .NET.  
> Projeto em evolução contínua: do console à API REST, do Docker ao Kubernetes.

---

## 📋 Sobre o Projeto

O FitCore é um sistema de gestão acadêmica desenvolvido com o objetivo de gerenciar alunos, planos, pagamentos, check-ins e professores de uma academia de musculação.

O projeto está sendo construído de forma incremental, acompanhando a evolução do aprendizado em C#, .NET, arquitetura de software e DevOps.

---

## 🚀 Status do Projeto

| Fase | Descrição | Status |
|------|-----------|--------|
| 1 - Console App | OOP, classes, encapsulamento, herança | 🔄 Em andamento |
| 2 - API REST | ASP.NET Core, Entity Framework, JWT | ⏳ Planejado |
| 3 - Frontend | HTML, CSS, Bootstrap, JavaScript | ⏳ Planejado |
| 4 - DevOps | Docker, CI/CD, GitHub Actions | ⏳ Planejado |
| 5 - Cloud | Deploy na nuvem, domínio real | ⏳ Planejado |

---

## 🛠️ Tecnologias

### Atualmente em uso
- **C#** — Linguagem principal
- **.NET** — Plataforma de desenvolvimento
- **Programação Orientada a Objetos** — Arquitetura base do sistema

### Planejadas nas próximas fases
- ASP.NET Core — API REST
- MySQL + Entity Framework Core — Banco de dados
- JWT — Autenticação e autorização
- Bootstrap + JavaScript — Interface web
- Docker — Containerização
- GitHub Actions — CI/CD
- AWS / Azure — Deploy em nuvem

---

## 📁 Estrutura do Projeto

```
FitCore/
├── src/
│   ├── Models/          # Classes de domínio (Aluno, Plano, Professor...)
│   ├── Services/        # Regras de negócio
│   └── Program.cs       # Entrada da aplicação
├── .gitignore
└── README.md
```

---

## ⚙️ Como Rodar Localmente

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/fitcore.git

# Entre na pasta do projeto
cd fitcore

# Execute o projeto
dotnet run
```

---

## 📌 Funcionalidades Previstas

### Gestão Geral
- [x] Estrutura base do projeto
- [ ] Cadastro de alunos
- [ ] Cadastro de planos
- [ ] Cadastro de professores
- [ ] Registro de check-in
- [ ] Controle de pagamentos

### 🏋️ Treinos Personalizados
- [ ] Professor monta treino para um aluno específico
- [ ] Catálogo de exercícios (supino, agachamento, rosca...)
- [ ] Treino com exercícios, séries, repetições e tempo de descanso
- [ ] Aluno visualiza seus treinos ao fazer login
- [ ] Modo treino: checklist de exercícios em tempo real
- [ ] Histórico de treinos do aluno

### Infraestrutura
- [ ] API REST completa
- [ ] Autenticação com JWT (professor vs aluno — permissões diferentes)
- [ ] Dashboard web
- [ ] Deploy com Docker
- [ ] Pipeline CI/CD

---

## 🏗️ Arquitetura de Classes (Fase 1)

```
Pessoa (classe base)
├── Aluno        — visualiza treinos, faz check-in
└── Professor    — cria e gerencia treinos

Treino           — criado pelo professor, vinculado a um aluno
└── ExercicioTreino — exercício + séries + repetições + descanso

Exercicio        — catálogo de exercícios disponíveis
Plano            — planos da academia (mensal, trimestral...)
Pagamento        — controle financeiro por aluno
CheckIn          — registro de entrada na academia
```

---

## 🧠 Aprendizados Aplicados

Este projeto serve como portfólio prático dos conceitos estudados:

- Orientação a Objetos: classes, herança, encapsulamento, polimorfismo, interfaces
- Boas práticas: commits semânticos, organização de pastas, README documentado
- (em breve) Arquitetura em camadas, APIs REST, autenticação, DevOps

---

## 👨‍💻 Autor

**Leonardo**  
Estudante de Análise e Desenvolvimento de Sistemas  
Focado em Backend .NET e Cloud/DevOps


---

## 📄 Licença

Este projeto está sob a licença MIT.
