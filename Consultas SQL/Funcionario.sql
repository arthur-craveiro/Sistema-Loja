create table Funcionario(
	idFuncionario int primary key,
	nome varchar(100) not null,
	telefones varchar(50) not null,
	identidade varchar(45) not null,
	carteriradetrabalho varchar(45) not null,
	salario real not null,
	motorista bit not null,
	tecnico bit not null,
	observacao varchar(100) not null
)
