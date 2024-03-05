# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/arch-back.JPG)

## Diagrama de Classes

```mermaid
classDiagram
   
  Pessoa "1" o-- "1"Login
  Pessoa "1" *-- "1..*" Perfil
  Perfil "1" *-- "1" Treino
  Perfil "1" *-- "1..*" Recomendacao
  Recomendacao "1" o-- "1..*" Exercicio
  Treino "1" *-- "1..*" ItemTreino
  ItemTreino "1" o-- "1" Exercicio

  class Pessoa{
    -string nome
    -DateTime dataNascimento
    -Login login
    -List~Perfil~ perfis
    +getNome() string
    +setNome(string nome) 
    +getDataNascimento() DateTime
    +setDataNascimento(DateTime dataNascimento) 
    +addPerfil(Perfil perfil) 
    +getLogin() Login
    +setLogin(Login login)
    +getPerfis() List~Perfil~ 
  }

  class Login{
    -string usuario
    -string senha
    +getUsuario() string
    +setUsuario(string usuario) 
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

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

As referências abaixo irão auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
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
