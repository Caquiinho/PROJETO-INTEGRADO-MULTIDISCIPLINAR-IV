USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarTodosProdutos' existe e a exclui se existir
IF OBJECT_ID('ConsultarTodosProdutos', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarTodosProdutos;
GO

-- Cria a procedure 'ConsultarTodosProdutos'
CREATE PROCEDURE ConsultarTodosProdutos   
AS
BEGIN
    SELECT Id, Produto
    FROM Produto WITH(NOLOCK)
    WHERE Status = 1
END;