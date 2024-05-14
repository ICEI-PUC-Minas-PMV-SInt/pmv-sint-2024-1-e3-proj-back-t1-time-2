-- Populando as tabelas
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

insert into Perfil (Id_Perfil, Id_Pessoa, Idade, Altura, Peso, Nivel)
values
(1, 1, 42, 1.82, 86.9, "Iniciante"),
(2, 2, 37, 1.80, 75.6, "Intermediario"),
(3, 3, 34, 1.67, 67.0, "Iniciante"),
(4, 4, 44, 1.62, 59.0, "Iniciante");

insert into Exercicio values
(1, "Elevacao lateral", 3, 12),
(2, "Remada sentada", 4, 8 ),
(3, "Puxada alta na polia", 3, 10 ),
(4, "Rosca com hateres no banco inclinado", 2, 20 ),
(5, "Elevacao da panturrilha", 3, 10),
(6, "Flexao prenas", 4, 8 ),
(7, "Extensao pernas", 4, 10 ),
(8, "Supino com barra", 3, 12),
(9, "Elevacoes laterais com halteres", 3, 8);

insert into Treino values
(1, "2024-05-01", "Ganhar massa muscular", "3 meses", 1),
(2, "2024-05-05", "Perder peso", "2 meses", 2);

-- random = floor(pmin+RAND()*(pmax-pmin))
insert into Treino_Exercicio values
(1, floor(RAND()*9)),
(1, floor(RAND()*9)),
(1, floor(RAND()*9));


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
 DataInicio,
 Objetivo,
 DuracaoTreino,
 Exercicio.Id_Exercicio,
 Exercicio.Nome,
 Series,
 Repeticoes
from Treino_Exercicio
inner join Treino on Treino.Id_Treino = Treino_Exercicio.Id_Treino
inner join Exercicio on Exercicio.Id_Exercicio = Treino_Exercicio.Id_Exercicio
inner join Perfil on Treino.Id_Perfil = Perfil.Id_Perfil
inner join Pessoa on Pessoa.Id_Pessoa = Perfil.Id_Pessoa
inner join Usuario on Usuario.Id_Usuario = Pessoa.Id_Usuario
where Usuario.Usuario = "Usuario 1";
