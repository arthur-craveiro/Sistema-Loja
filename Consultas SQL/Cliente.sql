create table Cliente (
	idCliente int identity not null,
	nome varchar(50) not null,
	telefones varchar(100) not null,
	cidade varchar(50) not null,
	endereco varchar(100) not null,
	CPF varchar(14),
	CNPJ varchar(18),
	idestado int not null,
	primary key(idCliente),
	foreign key(idestado) references UF(id)
)

insert into Cliente (nome, telefones, cidade, endereco, CPF, CNPJ, idestado) values ('Otávio Lima Ponce', '+055 (84) 92424-2424', 'Natal', 'Rua dos baitolas, 24, Bairro Sou gay e dou o cu', '881.482.180-13', '12.495.482/0001-87', 20);
select * from Cliente;