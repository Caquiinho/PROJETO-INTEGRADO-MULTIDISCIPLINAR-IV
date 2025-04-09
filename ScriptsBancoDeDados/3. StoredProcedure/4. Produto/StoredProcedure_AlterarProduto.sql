USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarProduto' existe e a exclui se existir
IF OBJECT_ID('AlterarProduto', 'P') IS NOT NULL
    DROP PROCEDURE AlterarProduto;
GO

-- Cria a procedure 'AlterarProduto'
CREATE PROCEDURE AlterarProduto
    @NomeProduto VARCHAR(100),
    @Id INT    
AS
BEGIN
	UPDATE Produto
	SET Produto = @NomeProduto
		WHERE Id = @Id
END;
