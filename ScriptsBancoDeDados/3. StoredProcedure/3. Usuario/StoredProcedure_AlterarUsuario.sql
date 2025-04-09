USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarUsuario' existe e a exclui se existir
IF OBJECT_ID('AlterarUsuario', 'P') IS NOT NULL
    DROP PROCEDURE AlterarUsuario;
GO

-- Cria a procedure 'AlterarUsuario'
CREATE PROCEDURE AlterarUsuario
    @Nome NVARCHAR(100),
    @Cep NVARCHAR(10),
    @Endereco NVARCHAR(200),
    @Complemento NVARCHAR(100),
    @UF NVARCHAR(2),
    @Bairro NVARCHAR(100),
    @Numero NVARCHAR(10),
    @Email NVARCHAR(100),
    @Senha NVARCHAR(100),
    @Id INT    
AS
BEGIN
    UPDATE Usuario
    SET 
        Nome = @Nome,
        Cep = @Cep,
        Endereco = @Endereco,
        Complemento = @Complemento,
        UF = @UF,
        Bairro = @Bairro,
        Numero = @Numero,
        Email = @Email,
        Senha = @Senha
    WHERE Id = @Id;
END;
