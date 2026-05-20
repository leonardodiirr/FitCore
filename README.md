# 💪 FitCore — Sistema de Gestão de Academia

> Sistema completo de gestão para academias de musculação, desenvolvido em C# / .NET.  
> Projeto em evolução contínua: do console à API REST, do Docker ao Kubernetes.

---

## 📋 Sobre o Projeto

O FitCore é um sistema de gestão para academias de musculação. Permite cadastrar alunos, professores e planos, montar treinos personalizados, registrar check-ins e controlar pagamentos.

O projeto está sendo construído de forma incremental, acompanhando a evolução do aprendizado em C#, .NET, arquitetura de software e DevOps.

---

## 🚀 Status do Projeto

| Fase | Descrição | Status |
|------|-----------|--------|
| 1 - Console App | OOP, classes, encapsulamento, herança | ✅ Concluído |
| 2 - API REST | ASP.NET Core, Entity Framework, JWT | ⏳ Planejado |
| 3 - Frontend | JavaScript, Bootstrap | ⏳ Planejado |
| 4 - Frontend Moderno | React, Next.js, Tailwind | ⏳ Planejado |
| 5 - DevOps | Docker, CI/CD, GitHub Actions | ⏳ Planejado |
| 6 - Cloud | Deploy na nuvem, domínio real | ⏳ Planejado |

---

## 🛠️ Tecnologias

### V1 — Atualmente em uso
- **C# / .NET 8** — Linguagem e plataforma
- **Programação Orientada a Objetos** — Arquitetura base

### Planejadas nas próximas fases
- ASP.NET Core — API REST
- MySQL + Entity Framework Core — Banco de dados
- JWT — Autenticação e autorização
- JavaScript + Bootstrap — Interface web
- React + Next.js + Tailwind — Frontend moderno
- Docker — Containerização
- GitHub Actions — CI/CD
- Azure / AWS — Deploy em nuvem
- Kubernetes — Orquestração

---

## 📁 Estrutura do Projeto

```
FitCore/
├── src/
│   ├── Models/
│   │   ├── Usuario.cs          # Classe base
│   │   ├── Aluno.cs            # Herda de Usuario
│   │   ├── Professor.cs        # Herda de Usuario
│   │   ├── Plano.cs            # Planos da academia
│   │   ├── ExercicioCatalogo.cs # Catálogo de exercícios
│   │   ├── TreinoExercicio.cs  # Exercício dentro do treino
│   │   ├── Treino.cs           # Treino vinculado a aluno e professor
│   │   ├── CheckIn.cs          # Registro de entrada/saída
│   │   └── Pagamento.cs        # Controle financeiro
│   ├── Enums/
│   │   ├── NivelTreino.cs
│   │   ├── StatusPlano.cs
│   │   ├── StatusPagamento.cs
│   │   └── FormaPagamento.cs
│   └── Program.cs              # Menu interativo
├── .gitignore
└── README.md
```

---

## ⚙️ Como Rodar Localmente

### Pré-requisitos
- [.NET SDK 8](https://dotnet.microsoft.com/download) instalado

### Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/fitcore.git

# Entre na pasta src
cd fitcore/src

# Execute o projeto
dotnet run
```

---

## 🗂️ Como Usar o Sistema

O sistema é um menu interativo no console. **Siga essa ordem** ao usar pela primeira vez — algumas funcionalidades dependem de dados já cadastrados.

### Passo 1 — Cadastrar um Plano (opção 3)
Antes de qualquer coisa, cadastre ao menos um plano.
```
Nome: Mensal
Descrição: Acesso completo por 1 mês
Preço: 99.90
Duração em meses: 1
```

### Passo 2 — Cadastrar um Exercício (opção 4)
Cadastre os exercícios que serão usados nos treinos.
```
Nome: Supino Reto
Grupo Muscular: Peitoral
Descrição: Exercício para peitoral com barra
Nível: 0 (Iniciante)
```

### Passo 3 — Cadastrar um Professor (opção 2)
```
Nome: Carlos Silva
Email: carlos@fitcore.com
CPF: 000.000.000-00
Telefone: (11) 99999-9999
Data de Nascimento: 15/03/1985
CREF: 123456-G/SP
Especialidade: Musculação
Salário: 3500.00
```

### Passo 4 — Cadastrar um Aluno (opção 1)
```
Nome: Leonardo
Email: leo@email.com
CPF: 111.111.111-11
Telefone: (11) 98888-8888
Data de Nascimento: 10/05/2004
Objetivo: Hipertrofia
Nível: 0 (Iniciante)
Plano: 0 (escolhe o plano cadastrado)
```

### Passo 5 — Montar Treino (opção 5)
O professor monta um treino para o aluno.
```
Professor: 0
Aluno: 0
Nome do treino: Treino A - Peito e Tríceps
Objetivo: Hipertrofia
Nível: 0
Validade: 30/06/2026
Exercício: 0 | Séries: 4 | Reps: 12 | Carga: 40 | Descanso: 60
Digite -1 para terminar
```

### Passo 6 — Ver Treino (opção 6)
O aluno visualiza o treino montado pelo professor.

### Passo 7 — Registrar Check-in (opção 7)
Registra a entrada do aluno na academia com horário automático.

---

## 📌 Funcionalidades

### ✅ V1 — Console App
- [x] Cadastro de alunos com matrícula gerada automaticamente
- [x] Cadastro de professores
- [x] Cadastro de planos com duração e preço
- [x] Catálogo de exercícios reutilizáveis
- [x] Professor monta treino personalizado para aluno
- [x] Aluno visualiza seus treinos com exercícios detalhados
- [x] Registro de check-in com horário automático
- [x] Controle de pagamentos com status e forma de pagamento

### ⏳ V2 — API REST
- [ ] API REST com ASP.NET Core
- [ ] Banco de dados MySQL com Entity Framework
- [ ] Autenticação JWT com roles (professor vs aluno)
- [ ] Swagger para documentação

### ⏳ V3 — Frontend
- [ ] Dashboard web com Bootstrap
- [ ] Tela de login
- [ ] Interface para montagem de treino
- [ ] Modo treino para o aluno

### ⏳ V4 — Sistema Completo
- [ ] Frontend moderno com React e Next.js
- [ ] App mobile com React Native
- [ ] Docker + CI/CD
- [ ] Deploy em nuvem
- [ ] Monitoramento com Grafana

---

## 🏗️ Arquitetura de Classes (V1)

```
Usuario (classe base)
├── Aluno        — visualiza treinos, faz check-in
└── Professor    — monta e gerencia treinos

Treino           — criado pelo professor, vinculado a um aluno
└── TreinoExercicio — exercício + séries + repetições + descanso

ExercicioCatalogo — catálogo de exercícios reutilizáveis
Plano             — planos da academia (mensal, trimestral...)
Pagamento         — controle financeiro por aluno
CheckIn           — registro de entrada e saída
```

---

## 🧠 Conceitos Aplicados

- Herança — `Aluno` e `Professor` herdam de `Usuario`
- Encapsulamento — atributos privados com properties
- Composição — `Treino` contém `TreinoExercicio` que referencia `ExercicioCatalogo`
- Enums — `NivelTreino`, `StatusPlano`, `StatusPagamento`, `FormaPagamento`
- Listas — `List<T>` para relacionamentos entre objetos
- Nullable — `DateTime?` para dados opcionais como saída do check-in
- Commits semânticos — histórico organizado no GitHub

---

## 👨‍💻 Autor

**Leonardo**  
Estudante de Análise e Desenvolvimento de Sistemas  
Focado em Backend .NET e Cloud/DevOps



## 📄 Licença

Este projeto está sob a licença MIT.
