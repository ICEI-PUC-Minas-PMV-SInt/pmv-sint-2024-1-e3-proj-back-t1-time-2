create database SHAPEAPP;
use SHAPEAPP;

create table Usuario (
Id_Usuario integer primary key,
Senha varchar(30),
Usuario varchar(30)
);

create table Pessoa (
Id_Pessoa integer primary key,
Id_Usuario integer,
Nome varchar(30),
DataNascimento date,
constraint FK_Pessoa_Usuario foreign key (Id_Usuario) references Usuario(Id_Usuario)
);

create table Perfil (
Id_Perfil integer primary key,
Id_Pessoa integer,
Idade integer,
Altura numeric(4,2),
Peso numeric(5,2),
Nivel varchar(15),
constraint FK_Perfil_Pessoa foreign key (Id_Pessoa) references Pessoa(Id_Pessoa)
);
create table Exercicio (
Id_Exercicio integer primary key,
Nome varchar(60),
Descricao varchar(60),
Classificacao varchar(20),
GrupoMuscular varchar(60),
Mecanica varchar(20)
);
create table ItemTreino (
Id_ItemTreino integer primary key,
Id_Exercicio integer,
Repeticoes integer,
Series integer,
constraint FK_ItemTreino_Exercicio foreign key (Id_Exercicio) references Exercicio(Id_Exercicio)
);
create table Treino (
Id_Treino integer primary key,
DataInicio date,
Id_Perfil integer,
constraint FK_Treino_Perfil foreign key (Id_Perfil) references Perfil(Id_Perfil)
);
create table Recomendacao (
Id_Recomendacao integer primary key,
DataRecomendacao date,
Id_Perfil integer,
constraint FK_Recomendacao_Perfil foreign key (Id_Perfil) references Perfil(Id_Perfil)
);
create table Treino_ItemTreino (
Id_Treino integer,
Id_ItemTreino integer,
constraint FK_Treino_ItemTreino_Treino foreign key (Id_Treino) references Treino(Id_Treino),
constraint FK_Treino_ItemTreino_ItemTreino foreign Key (Id_ItemTreino) references ItemTreino(Id_ItemTreino)
);
create table Recomendacao_ItemTreino (
Id_Recomendacao integer,
Id_ItemTreino integer,
constraint FK_Recomendacao_ItemTreino_Recomendacao foreign key (Id_Recomendacao) references Recomendacao(Id_Recomendacao),
constraint FK_Recomendacao_ItemTreino_ItemTreino foreign key (Id_ItemTreino) references ItemTreino(Id_ItemTreino)
);