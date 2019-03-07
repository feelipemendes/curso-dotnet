use database1
CREATE TABLE PRODUTO(
	idProduto int identity(1,1) primary key not null,
	nome varchar(100),
	preco decimal,
	quantidade int,
	dataCadastro datetime,
	idEstoque int constraint fk_idEstoque foreign key (idEstoque) references estoque
)
GO

CREATE TABLE ESTOQUE(
	idEstoque int identity(1,1) primary key not null,
	nome varchar(100)
)
GO

