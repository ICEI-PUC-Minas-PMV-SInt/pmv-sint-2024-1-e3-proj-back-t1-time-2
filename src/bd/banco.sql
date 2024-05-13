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
Series integer,
Repeticoes integer
);

create table Treino (
Id_Treino integer primary key,
DataInicio date,
Objetivo varchar(250),
DuracaoTreino varchar(60),
Id_Perfil integer,
constraint FK_Treino_Perfil foreign key (Id_Perfil) references Perfil(Id_Perfil)
);

create table Treino_Exercicio (
Id_Treino integer,
Id_Exercicio integer,
constraint FK_Treino_Exercicio_Treino foreign key (Id_Treino) references Treino(Id_Treino),
constraint FK_Treino_Exercicio_Exercicio foreign Key (Id_Exercicio) references Exercicio(Id_Exercicio)
);