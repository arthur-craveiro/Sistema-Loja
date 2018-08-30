create table Fornecedor (
	idFornecedores int identity not null,
	nome varchar(50) not null,
	telefones varchar(100) not null,
	cidade varchar(50) not null,
	endereco varchar(100) not null,
	CPF varchar(14),
	CNPJ varchar(18),
	idestado int not null,
	primary key(idFornecedores),
	foreign key(idestado) references UF(id)
)
