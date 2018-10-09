create table itensCompra (
	idItem int identity not null,
	unidade varchar(45) not null,
	quantidade int not null,
	precoUnitario numeric(10,2) not null,
	precoTotal numeric(10,2) not null,
	idCompra int not null,
	idProduto int not null,
	primary key(idItem),
	foreign key(idCompra) references Compra(idCompra),
	foreign key(idProduto) references Produtos(idProduto)
)