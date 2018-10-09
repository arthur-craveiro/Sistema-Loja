create table Venda (
	idVenda int identity not null,
	datas datetime not null,
	desconto numeric(10,2) not null,
	valorTotal numeric(10,2) not null,
	idCliente int not null,
	primary key(idVenda),
	foreign key(idCliente) references Cliente(idCliente)
)