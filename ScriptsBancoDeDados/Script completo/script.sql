USE [master]
GO
/****** Object:  Database [BD_FAZENDA]    Script Date: 12/11/2024 11:28:54 ******/
CREATE DATABASE [BD_FAZENDA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_FAZENDA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BD_FAZENDA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_FAZENDA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BD_FAZENDA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BD_FAZENDA] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_FAZENDA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_FAZENDA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BD_FAZENDA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_FAZENDA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_FAZENDA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD_FAZENDA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_FAZENDA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_FAZENDA] SET  MULTI_USER 
GO
ALTER DATABASE [BD_FAZENDA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_FAZENDA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_FAZENDA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_FAZENDA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_FAZENDA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_FAZENDA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BD_FAZENDA] SET QUERY_STORE = ON
GO
ALTER DATABASE [BD_FAZENDA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BD_FAZENDA]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeEmpresa] [nvarchar](50) NOT NULL,
	[CNPJ] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[Contato] [nvarchar](13) NULL,
	[Cep] [nvarchar](15) NULL,
	[Endereco] [nvarchar](100) NULL,
	[Numero] [nvarchar](10) NULL,
	[Complemento] [nvarchar](50) NULL,
	[Adubo] [nvarchar](30) NULL,
	[QuantidadeAdubo] [int] NULL,
	[Agrotoxico] [nvarchar](30) NULL,
	[QuantidadeAgrotoxico] [int] NULL,
	[Muda] [nvarchar](30) NULL,
	[QuantidadeMuda] [int] NULL,
	[Status] [bit] NULL,
	[DataCriacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeEmpresa] [nvarchar](50) NOT NULL,
	[CNPJ] [nvarchar](20) NOT NULL,
	[Adubo] [nvarchar](30) NOT NULL,
	[QuantidadeAdubo] [int] NOT NULL,
	[Cep] [nvarchar](15) NOT NULL,
	[Endereco] [nvarchar](100) NOT NULL,
	[Complemento] [nvarchar](50) NOT NULL,
	[Numero] [nvarchar](10) NOT NULL,
	[Agrotoxico] [nvarchar](30) NOT NULL,
	[QuantidadeAgrotoxico] [int] NOT NULL,
	[Muda] [nvarchar](30) NOT NULL,
	[QuantidadeMuda] [int] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Contato] [nvarchar](13) NOT NULL,
	[Status] [bit] NULL,
	[DataCriacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomePerfil] [nvarchar](50) NOT NULL,
	[Ativo] [bit] NULL,
	[DataCriacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeProduto] [varchar](50) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Preco] [decimal](10, 2) NOT NULL,
	[Status] [bit] NULL,
	[DataCriacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fk_Perfil] [int] NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Cep] [nvarchar](15) NOT NULL,
	[Endereco] [nvarchar](100) NOT NULL,
	[Complemento] [nvarchar](50) NOT NULL,
	[Numero] [nvarchar](10) NOT NULL,
	[Bairro] [nvarchar](100) NOT NULL,
	[UF] [nvarchar](2) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Senha] [nvarchar](20) NOT NULL,
	[Ativo] [bit] NULL,
	[DataCriacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Produto] [varchar](30) NOT NULL,
	[QuantidadeVendida] [varchar](15) NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[FormaDePagamento] [varchar](50) NOT NULL,
	[Status] [bit] NULL,
	[DataCriacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Fornecedor] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Fornecedor] ADD  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Perfil] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Perfil] ADD  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Produto] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Produto] ADD  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Venda] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Venda] ADD  DEFAULT (getdate()) FOR [DataCriacao]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Perfil] FOREIGN KEY([Fk_Perfil])
REFERENCES [dbo].[Perfil] ([Id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Perfil]
GO
/****** Object:  StoredProcedure [dbo].[AlterarCliente]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'AlterarCliente'
CREATE PROCEDURE [dbo].[AlterarCliente]
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
	UPDATE Cliente
	SET NomeEmpresa = @NomeEmpresa,
		Cep = @Cep,
		Endereco = @Endereco,
		Numero = @Numero,
        Complemento = @Complemento,
		Email = @Email,
		Contato = @Contato,
		Agrotoxico = @Agrotoxico,
		@Adubo = @Adubo


		WHERE Cnpj = @Cnpj
END;
GO
/****** Object:  StoredProcedure [dbo].[AlterarPerfil]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'AlterarPerfil'
CREATE PROCEDURE [dbo].[AlterarPerfil]
    @NomePerfil NVARCHAR(50),
    @Id INT    
AS
BEGIN
	UPDATE Perfil
	SET NomePerfil = @NomePerfil
		WHERE Id = @Id
END;
GO
/****** Object:  StoredProcedure [dbo].[AlterarProduto]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'AlterarProduto'
CREATE PROCEDURE [dbo].[AlterarProduto]
    @NomeProduto VARCHAR(100),
    @Quantidade INT,
    @Preco DECIMAL(10, 2),
    @Id INT
AS
BEGIN
    UPDATE Produto
    SET NomeProduto = @NomeProduto,
        Quantidade = @Quantidade,
        Preco = @Preco
    WHERE Id = @Id;
END;
GO
/****** Object:  StoredProcedure [dbo].[AlterarUsuario]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'AlterarUsuario'
CREATE PROCEDURE [dbo].[AlterarUsuario]
    @Nome NVARCHAR(100),
    @Cep NVARCHAR(10),
    @Endereco NVARCHAR(200),
    @Complemento NVARCHAR(100),
    @Uf NVARCHAR(2),
    @Bairro NVARCHAR(100),
    @Numero NVARCHAR(10),
    @Email NVARCHAR(100),
    
    @Id INT    
AS
BEGIN
    UPDATE Usuario
    SET 
        Nome = @Nome,
        Cep = @Cep,
        Endereco = @Endereco,
        Complemento = @Complemento,
        UF = @Uf,
        Bairro = @Bairro,
        Numero = @Numero,
        Email = @Email
    WHERE Id = @Id;
END;
GO
/****** Object:  StoredProcedure [dbo].[ConsultarCliente]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ConsultarCliente' com os campos atualizados
CREATE PROCEDURE [dbo].[ConsultarCliente]
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
/****** Object:  StoredProcedure [dbo].[ConsultarPerfil]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ConsultarPerfil'
CREATE PROCEDURE [dbo].[ConsultarPerfil]
    @NomePerfil NVARCHAR(50)
AS
BEGIN
    SELECT Id, NomePerfil, DataCriacao
    FROM Perfil WITH(NOLOCK)
    WHERE NomePerfil LIKE '%' + @NomePerfil + '%'
	AND Ativo = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[ConsultarPerfilUsuario]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ConsultarPerfilUsuario'
CREATE PROCEDURE [dbo].[ConsultarPerfilUsuario]
    @NomeUsuario NVARCHAR(50),
	@Senha NVARCHAR(20)
AS
BEGIN
    SELECT usr.FK_Perfil
    FROM Usuario AS usr
	INNER JOIN Perfil AS per
	ON usr.Fk_Perfil = per.Id
    WHERE usr.Nome LIKE '%' + @NomeUsuario + '%'
		  AND usr.Senha = @Senha
		  AND per.Ativo = 1
		  AND usr.Ativo = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[ConsultarProduto]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ConsultarProduto'
CREATE PROCEDURE [dbo].[ConsultarProduto]
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
/****** Object:  StoredProcedure [dbo].[ConsultarTodosPerfis]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ConsultarTodosPerfis'
CREATE PROCEDURE [dbo].[ConsultarTodosPerfis]    
AS
BEGIN
    SELECT Id, NomePerfil
    FROM Perfil WITH(NOLOCK)
    WHERE Ativo = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[ConsultarTodosProdutos]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ConsultarTodosProdutos'
CREATE PROCEDURE [dbo].[ConsultarTodosProdutos]   
AS
BEGIN
    SELECT Id, Produto
    FROM Produto WITH(NOLOCK)
    WHERE Status = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[ConsultarUsuario]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ConsultarUsuario'
CREATE PROCEDURE [dbo].[ConsultarUsuario]
    @NomeUsuario NVARCHAR(50)
AS
BEGIN
    SELECT usr.Id, per.NomePerfil, usr.Nome, usr.Cep, usr.Endereco, usr.Complemento,
	usr.Numero, usr.Bairro, usr.UF, usr.Email, usr.DataCriacao
    FROM Usuario AS usr
	INNER JOIN Perfil AS per
	ON usr.Fk_Perfil = per.Id
    WHERE usr.Nome LIKE '%' + @NomeUsuario + '%'
	AND usr.Ativo = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[ExcluirCliente]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ExcluirCliente'
CREATE PROCEDURE [dbo].[ExcluirCliente]    
    @Id INT    
AS
BEGIN
	UPDATE Cliente
		SET Status = 0
		WHERE Id = @Id
END;
GO
/****** Object:  StoredProcedure [dbo].[ExcluirPerfil]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ExcluirPerfil'
CREATE PROCEDURE [dbo].[ExcluirPerfil]    
    @Id INT    
AS
BEGIN
	UPDATE Perfil
		SET Ativo = 0
		WHERE Id = @Id
END;
GO
/****** Object:  StoredProcedure [dbo].[ExcluirProduto]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ExcluirProduto'
CREATE PROCEDURE [dbo].[ExcluirProduto] 
    @Id INT    
AS
BEGIN
	UPDATE Produto
		SET Status = 0
		WHERE Id = @Id
END;
GO
/****** Object:  StoredProcedure [dbo].[ExcluirUsuario]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'ExcluirUsuario'
CREATE PROCEDURE [dbo].[ExcluirUsuario]    
    @Id INT    
AS
BEGIN
	UPDATE Usuario
		SET Ativo = 0
		WHERE Id = @Id
END;
GO
/****** Object:  StoredProcedure [dbo].[InserirCliente]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[InserirCliente]
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
			VALUES  (@NomeEmpresa, @Cnpj, @Cep, @Endereco, @Numero, @Complemento, @Email, @Contato, 
            @Agrotoxico, @Adubo);
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[InserirFornecedor]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InserirFornecedor]
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
    -- Verifica se o fornecedor já existe
    IF EXISTS (SELECT 1 FROM Fornecedor WHERE Cnpj = @Cnpj)
    BEGIN
        -- Se o fornecedor já existe, retorna uma mensagem de erro
        RAISERROR ('Fornecedor já existe.', 16, 1);
    END
    ELSE
    BEGIN
        -- Insere o fornecedor no banco de dados
        INSERT INTO Fornecedor (
            NomeEmpresa, Cnpj, Cep, Endereco, Numero, Complemento, Email, Contato, 
            Agrotoxico, Adubo
        )
        VALUES (
            @NomeEmpresa, @Cnpj, @Cep, @Endereco, @Numero, @Complemento, @Email, @Contato, 
            @Agrotoxico, @Adubo
        );

        -- Confirmação de sucesso
        PRINT 'Fornecedor inserido com sucesso.';
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[InserirProduto]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'InserirProduto'
CREATE PROCEDURE [dbo].[InserirProduto]
    @NomeProduto VARCHAR(100),    
    @Quantidade INT,
    @Preco DECIMAL(10, 2)    
AS
BEGIN
    -- Verifica se o produto já existe
    IF EXISTS (SELECT 1 FROM Produto WHERE NomeProduto = @NomeProduto)  -- Correção aqui
    BEGIN
        -- Se o Produto já existe, retorna uma mensagem
        PRINT 'Produto já existe.'
    END
    ELSE
    BEGIN
        INSERT INTO Produto (NomeProduto, Quantidade, Preco)
        VALUES (@NomeProduto, @Quantidade, @Preco);
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[InserirUsuario]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'InserirUsuario'
CREATE PROCEDURE [dbo].[InserirUsuario]
    @Fk_Perfil INT,
	@Nome NVARCHAR(100),
	@Cep NVARCHAR(15),
	@Endereco NVARCHAR(100),
	@Complemento NVARCHAR(50),
	@Numero NVARCHAR(10),
	@Bairro NVARCHAR(100),
	@Uf NVARCHAR(2),
	@Email NVARCHAR(100),
	@Senha NVARCHAR(20)
AS
BEGIN
    -- Verifica se pessoa já existe
    IF EXISTS (SELECT 1 FROM Usuario WHERE Nome = @Nome)
    BEGIN
        -- Se pessoa já existe, retorna uma mensagem
        PRINT 'Usuário(a) já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Usuario (Fk_Perfil, Nome, Cep, Endereco, Complemento, Numero, Bairro,
			UF, Email, Senha)
			VALUES (@Fk_Perfil, @Nome, @Cep, @Endereco, @Complemento, @Numero, @Bairro,
			@Uf, @Email, @Senha);
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[Nome]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'Nome'
CREATE PROCEDURE [dbo].[Nome]
    @Fk_Perfil INT,
	@Nome NVARCHAR(100),
	@Cep NVARCHAR(15),
	@Endereco NVARCHAR(100),
	@Complemento NVARCHAR(50),
	@Numero NVARCHAR(10),
	@Bairro NVARCHAR(100),
	@Uf NVARCHAR(2),
	@Email NVARCHAR(100),
	@Senha NVARCHAR(20)
AS
BEGIN
    -- Verifica se pessoa já existe
    IF EXISTS (SELECT 1 FROM Usuario WHERE Nome = @Nome)
    BEGIN
        -- Se pessoa já existe, retorna uma mensagem
        PRINT 'Usuário(a) já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Usuario (Fk_Perfil, Nome, Cep, Endereco, Complemento, Numero, Bairro,
			UF, Email, Senha)
			VALUES (@Fk_Perfil, @Nome, @Cep, @Endereco, @Complemento, @Numero, @Bairro,
			@Uf, @Email, @Senha);
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[Nomeusuario]    Script Date: 12/11/2024 11:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cria a procedure 'Nomeusuario'
CREATE PROCEDURE [dbo].[Nomeusuario]
    @Fk_Perfil INT,
	@Nome_usuario NVARCHAR(100),
	@Cep NVARCHAR(15),
	@Endereco NVARCHAR(100),
	@Complemento NVARCHAR(50),
	@Numero NVARCHAR(10),
	@Bairro NVARCHAR(100),
	@Uf NVARCHAR(2),
	@Email NVARCHAR(100),
	@Senha NVARCHAR(20)
AS
BEGIN
    -- Verifica se pessoa já existe
    IF EXISTS (SELECT 1 FROM Usuario WHERE Nome = @Nome_usuario)
    BEGIN
        -- Se pessoa já existe, retorna uma mensagem
        PRINT 'Usuário(a) já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Usuario (Fk_Perfil, Nome, Cep, Endereco, Complemento, Numero, Bairro,
			UF, Email, Senha)
			VALUES (@Fk_Perfil, @Nome_usuario, @Cep, @Endereco, @Complemento, @Numero, @Bairro,
			@Uf, @Email, @Senha);
		END;
END;
GO
USE [master]
GO
ALTER DATABASE [BD_FAZENDA] SET  READ_WRITE 
GO
