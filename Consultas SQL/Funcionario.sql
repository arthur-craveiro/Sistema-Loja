create table Funcionario(
	idFuncionario int identity(1,1) primary key,
	nome varchar(100) not null,
	telefones varchar(50) not null,
	identidade varchar(45) not null,
	carteiradetrabalho varchar(45) not null,
	salario real not null,
	motorista bit not null,
	tecnico bit not null,
	observacao varchar(100) not null
)
