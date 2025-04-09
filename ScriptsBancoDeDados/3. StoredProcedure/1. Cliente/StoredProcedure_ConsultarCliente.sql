USE BD_FAZENDA;
GO

-- Verifica se a procedure 'ConsultarCliente' existe e a exclui se existir
IF OBJECT_ID('ConsultarCliente', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarCliente;
GO

-- Cria a procedure 'ConsultarCliente' com os campos atualizados
CREATE PROCEDURE ConsultarCliente
    @NomeEmpresa NVARCHAR(50)  -- Atualizado para buscar pelo campo NomeEmpresa
AS
BEGIN
    SELECT 
        Id,
        NomeEmpresa,
        Cnpj,
        Cep,
        Endereco,
        Complemento,
        Numero,
        Adubo,
		Agrotoxico,
        Email,
        Contato,
        Status,
        DataCriacao
    FROM Cliente WITH(NOLOCK)
    WHERE NomeEmpresa LIKE '%' + @NomeEmpresa + '%'
      AND Status = 1;  -- Atualizado para filtrar pelo campo Status (ativo)
END;
GO
