create table Pagamento(
	idPagamento int identity(1,1) primary key not null,
	valorPago numeric(10,2) not null,
	dataDePagamento datetime not null,
	mesReferencia int not null,
	anoReferencia int not null,
	idFuncionario int not null,
	foreign key (idFuncionario) references Funcionario(idFuncionario)
)

insert into Pagamento(valorPago,dataDePagamento,mesReferencia,anoReferencia,idFuncionario) values(500.50,'2008-05-11', 05, 2012, 1)