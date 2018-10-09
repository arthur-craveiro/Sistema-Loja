create table Compra (
	idCompra int identity not null,
	datas datetime not null,
	desconto numeric(10,2) not null,
	valorTotal numeric(10,2) not null,
	idFornecedores int not null,
	primary key(idCompra),
	foreign key(idFornecedores) references Fornecedor(idFornecedores)
)