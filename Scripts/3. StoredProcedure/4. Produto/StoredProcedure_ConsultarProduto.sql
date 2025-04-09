USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarProduto' existe e a exclui se existir
IF OBJECT_ID('dbo.ConsultarProduto', 'P') IS NOT NULL
    DROP PROCEDURE dbo.ConsultarProduto;
GO

-- Cria a procedure 'ConsultarProduto'
CREATE PROCEDURE ConsultarProduto
    @NomeProduto VARCHAR(50) -- Parâmetro para filtrar pelo nome do produto
AS
BEGIN
    SET NOCOUNT ON; -- Melhora o desempenho ao evitar contagens desnecessárias

    SELECT Id, NomeProduto, Quantidade, Preco, DataCriacao
    FROM Produto WITH(NOLOCK)
    WHERE NomeProduto LIKE '%' + @NomeProduto + '%'
      AND Status = 1; -- Apenas produtos ativos
END;
GO
