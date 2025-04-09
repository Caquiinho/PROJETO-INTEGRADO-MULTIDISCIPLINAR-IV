USE [BD_FAZENDA];
GO

-- Verifica se a tabela j� existe
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Cliente')
BEGIN
    PRINT 'A tabela j� existe.'
END
ELSE
BEGIN
    -- Cria��o da tabela Cliente com os campos especificados
    CREATE TABLE Cliente 
    (
        Id INT NOT NULL PRIMARY KEY IDENTITY,
        NomeEmpresa NVARCHAR(50) NOT NULL,
        CNPJ NVARCHAR(20) NOT NULL,
        Email NVARCHAR(100) ,
		Contato NVARCHAR(13),
        Cep NVARCHAR(15),
        Endereco NVARCHAR(100),
        Numero NVARCHAR(10),
		Complemento NVARCHAR(50) NULL ,
		Adubo NVARCHAR(30)  NULL,
		QuantidadeAdubo INT  NULL,
        Agrotoxico NVARCHAR(30)  NULL ,
        QuantidadeAgrotoxico INT  NULL,
        Muda NVARCHAR(30)  NULL,
        QuantidadeMuda INT  NULL ,
        Status BIT DEFAULT 1,
        DataCriacao DATETIME DEFAULT GETDATE()
    );
    PRINT 'Tabela Cliente criada com sucesso.'
END;
GO

