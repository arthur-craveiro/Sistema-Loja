create table Pagamento(
	idPagamento int primary key,
	valorPago real not null,
	dataDePagamento date not null,
	mesReferencia int not null,
	anoReferencia int not null,
	idFuncionario int not null,
	foreign key (idFuncionario) references Funcionario(idFuncionario)
)