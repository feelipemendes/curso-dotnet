﻿--CREATE TABLE Produto (
--	IdProduto		integer identity(1,1),
--	Nome			nvarchar(50)	not null,
--	Preco			decimal(18,2)	not null,
--	DataCadastro	datetime		not null,
--	primary key(IdProduto))

--CREATE PROCEDURE SpInserirProduto
--	@Nome nvarchar(50),
--	@Preco decimal(18,2)
--AS
--BEGIN
--	INSERT INTO Produto VALUES (@Nome, @Preco, GETDATE())
--END
--GO

--create procedure SpAtualizarProduto
--@IdProduto integer,
--@Nome nvarchar(50),
--@Preco decimal(18,2)
--as
--begin
--update Produto
--set Nome = @Nome, Preco = @Preco
--where IdProduto = @IdProduto
--end
--go
-------------------
--create procedure SpExcluirProduto
--@IdProduto integer
--as
--begin
--delete from Produto
--where IdProduto = @IdProduto
--end
--go
-------------------
--create procedure SpConsultarProdutos
--as
--begin
--select * from Produto
--end
--go

	