-- População das tabelas

insert into Usuario (Id_Usuario, Senha, Usuario)
values 
(1, "123456", "Usuario 1"), 
(2, "789101", "Usuario 2"),
(3, "abcdef", "Usuario 3"),
(4, "ghijkl", "Usuario 4");

insert into Pessoa (Id_Pessoa, Id_Usuario, Nome, DataNascimento)
values
(1, 1, "Jose da Silva","1981-04-19"),
(2, 2, "Joao da Silva","1986-06-05"),
(3, 3, "Maria da Luz","1990-03-7"),
(4, 4, "Sandra Pereira","1979-10-29");

insert into Perfil (Id_Pefil, Id_Pessoa, Idade, Altura, Peso, Nivel)
values
(1, 1, 42, 1.82, 86.9, "Iniciante"),
(2, 2, 37, 1.80, 75.6, "Intermediario"),
(3, 3, 34, 1.67, 67.0, "Iniciante"),
(4, 4, 44, 1.62, 59.0, "Iniciante");

-- Buscar um usuario na tela de login
select Id_Usuario, senha, usuario
from Usuario
where usuario = "usuario" and senha = "senha";

-- Buscar os dados cadastrais de um usuário
select Id_Pessoa,Pessoa.Id_Usuario, Nome, DataNascimento
from Pessoa
inner join Usuario on Pessoa.Id_Usuario = Usuario.Id_Usuario
where Usuario.Usuario = "Usuario 1";

-- Buscar todos os perfis de uma pessoa
select Id_Perfil, Perfil.Id_Pessoa, Nome, Idade, Altura, Peso, Nivel
from Perfil
inner join Pessoa on Perfil.Id_Pessoa = Pessoa.Id_Pessoa
where Perfil.Id_Perfil = 1;

-- Mostrar todas as recomendações/exercícios para uma pessoa
select Pessoa.Id_Usuario,
 Pessoa.Id_Pessoa,
 Pessoa.Nome,
 DataNascimento,
 Perfil.Id_Perfil,
 Idade,
 Altura,
 Peso,
 Nivel,
 Recomendacao.Id_Recomendacao,
 ItemTreino.Id_ItemTreino,
 Exercicio.Id_Exercicio,
 Exercicio.Nome,
 Descricao,
 Classificacao,
 GrupoMuscular,
 Mecanica,
 Repeticoes,
 Series
from Recomendacao
inner join Recomendacao_ItemTreino on Recomendacao.Id_Recomendacao = Recomendacao_ItemTreino.Id_Recomendacao
inner join Perfil on Perfil.Id_Perfil = Recomendacao.Id_Perfil
inner join Pessoa on Pessoa.Id_Pessoa = Perfil.Id_Pessoa
inner join Usuario on Usuario.Id_Usuario = Pessoa.Id_Usuario
inner join ItemTreino on ItemTreino.Id_ItemTreino = Recomendacao_ItemTreino.Id_ItemTreino
inner join Exercicio on Exercicio.Id_Exercicio = ItemTreino.Id_Exercicio
where Usuario.Usuario = "Usuario 1";

-- Mostrar todos os treino/exercícios para uma pessoa
select Pessoa.Id_Usuario,
 Pessoa.Id_Pessoa,
 Pessoa.Nome,
 DataNascimento,
 Perfil.Id_Perfil,
 Idade,
 Altura,
 Peso,
 Nivel,
 Treino.Id_Treino,
 ItemTreino.Id_ItemTreino,
 Exercicio.Id_Exercicio,
 Exercicio.Nome,
 Descricao,
 Classificacao,
 GrupoMuscular,
 Mecanica,
 Repeticoes,
 Series
from Treino
inner join Treino_ItemTreino on Treino.Id_Treino = Treino_ItemTreino.Id_Treino
inner join Perfil on Treino.Id_Perfil = Perfil.Id_Perfil
inner join  Pessoa on Pessoa.Id_Pessoa = Perfil.Id_Pessoa
inner join Usuario on Usuario.Id_Usuario = Pessoa.Id_Usuario
inner join ItemTreino on ItemTreino.Id_ItemTreino = Treino_ItemTreino.Id_ItemTreino
inner join Exercicio on Exercicio.Id_Exercicio = ItemTreino.Id_Exercicio
where Usuario.Usuario = "Usuario 2";