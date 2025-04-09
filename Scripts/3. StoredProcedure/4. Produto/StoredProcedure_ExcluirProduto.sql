USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirProduto' existe e a exclui se existir
IF OBJECT_ID('ExcluirProduto', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirProduto;
GO

-- Cria a procedure 'ExcluirProduto'
CREATE PROCEDURE ExcluirProduto 
    @Id INT    
AS
BEGIN
	UPDATE Produto
		SET Status = 0
		WHERE Id = @Id
END;