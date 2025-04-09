USE BD_FAZENDA;

-- Verifica se a procedure 'InserirCliente' existe e a exclui se existir
IF OBJECT_ID('InserirCliente', 'P') IS NOT NULL
    DROP PROCEDURE InserirCliente;
GO


CREATE PROCEDURE InserirCliente
    @NomeEmpresa NVARCHAR(50),
    @Cnpj NVARCHAR(20),
    @Cep NVARCHAR(15),
    @Endereco NVARCHAR(100),
    @Numero NVARCHAR(10),
    @Complemento NVARCHAR(50),
    @Email NVARCHAR(100),
    @Contato NVARCHAR(13),
    @Agrotoxico NVARCHAR(30),
    @Adubo NVARCHAR(30)
AS
BEGIN
    -- Verifica se o cliente já existe
    IF EXISTS (SELECT 1 FROM Cliente WHERE Cnpj = @Cnpj)
    BEGIN
        -- Se o cliente já existe, retorna uma mensagem
        PRINT 'Fornecedor já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Cliente (NomeEmpresa, Cnpj, Cep, Endereco, Numero, Complemento, Email, Contato, 
            Agrotoxico, Adubo)
			VALUES (@NomeEmpresa, @Cnpj, @Cep, @Endereco, @Numero, @Complemento, @Email, @Contato, 
            @Agrotoxico, @Adubo);
		END;
END;