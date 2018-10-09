create table itensVenda (
	idItem int identity not null,
	peso numeric(10,2) not null,
	precokg numeric(10,2) not null,
	valorTotal numeric(10,2) not null,
	idVenda int not null,
	idProduto int not null,
	primary key(idItem),
	foreign key(idVenda) references Venda(idVenda),
	foreign key(idProduto) references Produtos(idProduto)
)