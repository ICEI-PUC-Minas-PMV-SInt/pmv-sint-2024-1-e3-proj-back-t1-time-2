# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/arch-back.JPG)

## Diagrama de Classes

```mermaid
classDiagram

  Pessoa "1" -- "1" Usuario
  Pessoa "1" -- "1..*" Perfil
  Perfil "1" -- "1" Treino
  Perfil "1" -- "1..*" Recomendacao
  Recomendacao "1" -- "1..*" Exercicio
  Treino "1" -- "1..*" ItemTreino
  ItemTreino "1" -- "1" Exercicio

  class Pessoa{
    -Usuario usuario
    -string nome
    -DateTime dataNascimento
    -List~Perfil~ perfis
    +getNome() string
    +setNome(string nome)
    +getDataNascimento() DateTime
    +setDataNascimento(DateTime dataNascimento)
    +getUsuario() Usuario
    +setUsuario(Usuario usuario)
    +addPerfil(Perfil perfil)
    +getPerfis() List~Perfil~
  }

  class Usuario{
    -string idUsuario
    -string senha
    +getIdUsuario() string
    +setIdUsuario(string Idusuario)
    +getSenha() string
    +setSenha(string senha)
    -validaSenha()
  }

  class Perfil{
    -DateTime dataPerfil
    -double idade
    -double altura
    -double peso
    -string nivel
    -double imc
    -Treino treino
    -List~Recomendacao~ recomendacoes
    +Perfil(DateTime dataNascimento, double altura, double peso, string nivel)
    -calcularImc()
    +getPeso() double
    +getAltura() double
    +getImc() double
    +getDataPerfil() DateTime
    +getIdade() int
    +getNivel() string
    +getTreino() Treino
    +setTreino(Treino treino)
    +addRecomendacao(Recomendacao recomendacao)
    +getRecomendacoes() List~Recomendacao~
  }

  class Treino{
    -List~ItemTreino~itens
    +addItemTreino(item)
    +getItens() ItemTreino

  }

  class Recomendacao{
    -List~Exercicio~ exercicios
    +addExercicio(exercicio)
    +getExercicios() List~Exercicio~
  }

  class Exercicio{
    -string descricao
    -string grupoMuscular
    +getDescricao() string
    +getGrupoMuscular() string
    +setDescricao(string descricao)
    +setGrupoMuscular(string grupoMuscular)
  }

  class ItemTreino{
    -int repeticoes
    -int series
    -Exercicio exercicio
    +getRepeticoes() int
    +setRepeticoes(int repeticoes)
    +getSeries() int
    +setSeries(int series)
    +getExercicio() Exercicio
    +setExercicio(Exercicio exercicio)
  }
```

Para utilizar o sistema um usuário precisa de credenciais que serão gerenciadas pelo **Usuário**. Após fazer o login, ele irá completar o cadastro com seu nome e senha, essas informações irão compor a classe **PESSOA**. Para acessar a lista de exercícios, o usuário deverá preencher o seu **PERFIL** com peso, altura e idade, dessa forma o app irá fazer a **RECOMENDAÇÃO** de uma lista de **EXERCÍCIOS** que ele poderá personalizar e obter o **TREINO**. Para alterar o treino é necessário atualizar o perfil.

---

## Arquitetura de Solução

A arquitetura de microserviços foi considerada a mais adequada para este projeto pelo fato de que permite uma maior escalabilidade, flexibilidade e modularidade. Com a arquitetura de microserviços, cada componente do sistema pode ser desenvolvido, implantado e escalado independentemente, o que facilita a manutenção e evolução do aplicativo. Além disso, os microsserviços podem ser projetados para se concentrar em áreas específicas de funcionalidade, como autenticação de usuários, recomendação de exercícios e gerenciamento de treinamentos, o que facilita a organização e a manutenção do código. Isso também permite que diferentes equipes trabalhem em paralelo em partes diferentes do aplicativo, acelerando o desenvolvimento e permitindo uma resposta mais rápida às mudanças e demandas do mercado.

Assim, neste primeiro momento, a proposta de arquitetura engloba:

1 - Frontend do Aplicativo: Esta é a interface com o usuário, onde eles interagem com o aplicativo. Pode ser desenvolvido usando tecnologias web como ReactJS, AngularJS, ou frameworks de aplicativos móveis como React Native ou Flutter.

2 - Backend de Autenticação e Gerenciamento de Usuários: Este microsserviço gerencia a autenticação dos usuários e mantém os dados relacionados às contas dos usuários, como informações pessoais, histórico de treinamento. Ainda não se tem definição do protocolo de implementação (python, node e etc...)

3 - Serviço de Perfis de Usuários: Este serviço é responsável por armazenar e gerenciar os perfis dos usuários, incluindo informações como sexo, idade, altura, peso e objetivos de condicionamento físico. O grupo não definiu se este será um serviço integrado ou separado.

4 - Serviço de Recomendação de Exercícios: Este microsserviço é responsável por recomendar exercícios com base nos perfis dos usuários e em seus objetivos de condicionamento físico. Este serviço será baseado em filtragem colaborativa ou sistemas baseados em regras.

5 - Serviço de Gerenciamento de Treinos: Este serviço é responsável por criar e gerenciar os treinos dos usuários com base nas recomendações de exercícios. Ele pode acompanhar o progresso do usuário e ajustar os treinos conforme necessário. (opcional, visto a dificuldade técnica de realização do trabalho);

6 - Serviço de Notificação e Lembrete: Este serviço envia notificações e lembretes aos usuários para incentivar a consistência em sua rotina de exercícios. Pode ser configurado para enviar lembretes de treino, dicas de saúde, etc. (opcional, visto a dificuldade técnica de realização do trabalho);

7 - Banco de Dados: Todos os serviços acima precisarão de um banco de dados para armazenar dados relevantes, como perfis de usuários, histórico de treinamento, informações de exercícios, etc. Um banco de dados SQL ou NoSQL pode ser usado. O grupo ainda não definiu.

8 - Serviço de Análise e Monitoramento: Este serviço é responsável por coletar e analisar dados sobre o uso do aplicativo, desempenho do usuário, etc., para ajudar a melhorar a experiência do usuário e a eficácia do aplicativo ao longo do tempo. (opcional, visto a dificuldade técnica de realização do trabalho);

Essa arquitetura de microsserviços permite escalabilidade, flexibilidade e facilidade de manutenção, já que cada serviço pode ser desenvolvido, implantado e escalado independentemente. Além disso, a separação de preocupações entre os diferentes serviços facilita a evolução do aplicativo ao longo do tempo.

---

# Domínio Conceitual

O back-end do aplicativo incluirá as seguintes entidades e seus relacionamentos:

**Usuário:**

- Atributos: ID, nome de usuário, senha criptografada, e-mail, data de nascimento, sexo, altura, peso.
- Relacionamentos: Pode ter um perfil de usuário associado.
  **Perfil de Usuário:**
- Atributos: ID, objetivo de condicionamento físico (perder peso, ganhar massa, manter forma).
- Relacionamentos: Pertence a um usuário.

**Exercício:**

- Atributos: ID, nome, descrição, grupo muscular alvo, nível de dificuldade.
- Relacionamentos: Pode ser parte de uma rotina de treinamento.

**Rotina de Treinamento:**

- Atributos: ID, data de criação, data de modificação.
- Relacionamentos: Contém uma lista de exercícios recomendados para o usuário.

**Histórico de Treinamento:**

- Atributos: ID, data de realização do treino, duração do treino, nível de esforço percebido, feedback do usuário.
- Relacionamentos: Relacionado a um usuário e a uma rotina de treinamento.

**Notificação/Lembrete:**

- Atributos: ID, tipo de notificação (lembrete de treino, dica de saúde, etc.), conteúdo, data/hora de envio.
- Relacionamentos: Pode ser associado a um usuário.

**Feedback do Usuário:**

- Atributos: ID, comentário, classificação (por exemplo, de 1 a 5 estrelas).
- Relacionamentos: Relacionado a um usuário e a um exercício ou treino específico.

Estes itens apresentados acima representam um modelo de domínio básico e conceitual do back-end do aplicativo. Cada entidade tem seus atributos próprios e pode estar relacionada a outras entidades conforme necessário para o funcionamento do aplicativo. Este modelo poderá ter alterações pois levará em consideração as dificuldades apresentadas durante o desenvolvimento do APP.

---

## Modelo ER

O Modelo de Entidade e Relacionamento representa a estrutura dos dados no BD.

<img src="img/mer.png" width="700"/>

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.

<img src="img/modelo-relacional.png" width="700"/>

As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico (DDL)

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Instruções SQL de Manipulação do BD (DML)

Entregar um arquivo dml.sql contendo os scripts de manipulação de banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
