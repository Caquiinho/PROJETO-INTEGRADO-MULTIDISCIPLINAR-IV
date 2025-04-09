USE BD_FAZENDA;

-- Verifica se a procedure 'InserirProduto' existe e a exclui se existir
IF OBJECT_ID('InserirProduto', 'P') IS NOT NULL
    DROP PROCEDURE InserirProduto;
GO

-- Cria a procedure 'InserirProduto'
CREATE PROCEDURE InserirProduto
    @NomeProduto VARCHAR(100),    
    @Quantidade INT,
    @Preco Decimal(10,2)    
AS
BEGIN
    -- Verifica se o produto já existe
    IF EXISTS (SELECT 1 FROM Produto WHERE Produto = @NomeProduto)
    BEGIN
        -- Se o Produto já existe, retorna uma mensagem
        PRINT 'Produto já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Produto (Produto, Quantidade, Preco)
			VALUES (@NomeProduto, @Quantidade, @Preco);
		END;
END;