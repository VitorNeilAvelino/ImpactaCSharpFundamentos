/*
Deployment script for ImpactaCSharp1
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ImpactaCSharp1"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
USE [master]
GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(DatabaseName)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'The state of the target database, %s, is not set to ONLINE. To deploy to this database, its state must be set to ONLINE.', 16, 127,N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [ImpactaCSharp1], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB)
    LOG ON (NAME = [ImpactaCSharp1_log], FILENAME = '$(DefaultLogPath)$(DatabaseName)_log.LDF', MAXSIZE = 2097152 MB, FILEGROWTH = 10 %) COLLATE Latin1_General_CI_AS
GO
EXECUTE sp_dbcmptlevel [$(DatabaseName)], 100;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
USE [$(DatabaseName)]
GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
PRINT N'Creating [dbo].[Cidade]...';


GO
CREATE TABLE [dbo].[Cidade] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (100) NOT NULL,
    [Estado_Id] INT           NULL
);


GO
PRINT N'Creating PK_Cidade...';


GO
ALTER TABLE [dbo].[Cidade]
    ADD CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);


GO
PRINT N'Creating [dbo].[Cliente]...';


GO
CREATE TABLE [dbo].[Cliente] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [Pessoa_Id]      INT             NOT NULL,
    [Renda]          DECIMAL (18, 2) NOT NULL,
    [DataNascimento] DATETIME        NOT NULL
);


GO
PRINT N'Creating PK_Cliente...';


GO
ALTER TABLE [dbo].[Cliente]
    ADD CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);


GO
PRINT N'Creating [dbo].[Estado]...';


GO
CREATE TABLE [dbo].[Estado] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (50) NOT NULL,
    [Sigla] VARCHAR (2)  NOT NULL
);


GO
PRINT N'Creating PK_Estado...';


GO
ALTER TABLE [dbo].[Estado]
    ADD CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);


GO
PRINT N'Creating [dbo].[Pessoa]...';


GO
CREATE TABLE [dbo].[Pessoa] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR (50) NOT NULL
);


GO
PRINT N'Creating PK_Pessoa...';


GO
ALTER TABLE [dbo].[Pessoa]
    ADD CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);


GO
PRINT N'Creating [dbo].[PessoaDocumentos]...';


GO
CREATE TABLE [dbo].[PessoaDocumentos] (
    [Pessoa_Id] INT          NOT NULL,
    [Numero]    VARCHAR (50) NOT NULL,
    [Tipo]      INT          NOT NULL
);


GO
PRINT N'Creating PessoaDocumentosNumeroTipoUK...';


GO
ALTER TABLE [dbo].[PessoaDocumentos]
    ADD CONSTRAINT [PessoaDocumentosNumeroTipoUK] UNIQUE NONCLUSTERED ([Numero] ASC, [Tipo] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[PessoaEmails]...';


GO
CREATE TABLE [dbo].[PessoaEmails] (
    [Pessoa_Id] INT           NOT NULL,
    [Endereco]  VARCHAR (100) NOT NULL
);


GO
PRINT N'Creating [dbo].[PessoaEnderecos]...';


GO
CREATE TABLE [dbo].[PessoaEnderecos] (
    [Pessoa_Id]      INT           NOT NULL,
    [Tipo]           INT           NOT NULL,
    [NomeLogradouro] VARCHAR (100) NOT NULL,
    [Numero]         VARCHAR (50)  NOT NULL,
    [Complemento]    VARCHAR (50)  NULL,
    [Bairro]         VARCHAR (50)  NOT NULL,
    [CEP]            VARCHAR (8)   NOT NULL,
    [Cidade_Id]      INT           NOT NULL
);


GO
PRINT N'Creating FK_Cidade_Estado...';


GO
ALTER TABLE [dbo].[Cidade] WITH NOCHECK
    ADD CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY ([Estado_Id]) REFERENCES [dbo].[Estado] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_Cliente_Pessoa...';


GO
ALTER TABLE [dbo].[Cliente] WITH NOCHECK
    ADD CONSTRAINT [FK_Cliente_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_PessoaDocumentos_Pessoa...';


GO
ALTER TABLE [dbo].[PessoaDocumentos] WITH NOCHECK
    ADD CONSTRAINT [FK_PessoaDocumentos_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_PessoaEmails_Pessoa...';


GO
ALTER TABLE [dbo].[PessoaEmails] WITH NOCHECK
    ADD CONSTRAINT [FK_PessoaEmails_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_PessoaEnderecos_Cidade...';


GO
ALTER TABLE [dbo].[PessoaEnderecos] WITH NOCHECK
    ADD CONSTRAINT [FK_PessoaEnderecos_Cidade] FOREIGN KEY ([Cidade_Id]) REFERENCES [dbo].[Cidade] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_PessoaEnderecos_Pessoa...';


GO
ALTER TABLE [dbo].[PessoaEnderecos] WITH NOCHECK
    ADD CONSTRAINT [FK_PessoaEnderecos_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
-- Refactoring step to update target server with deployed transaction logs
CREATE TABLE  [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
GO
sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
GO

GO
USE [ImpactaCSharp1];
SET NOCOUNT ON;
SET XACT_ABORT ON;
GO

SET IDENTITY_INSERT [dbo].[Estado] ON;

BEGIN TRANSACTION;
INSERT INTO [dbo].[Estado]([Id], [Nome], [Sigla])
SELECT 2, N'São Paulo', N'SP'
COMMIT;
RAISERROR (N'[dbo].[Estado]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[Estado] OFF;


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Cidade] WITH CHECK CHECK CONSTRAINT [FK_Cidade_Estado];

ALTER TABLE [dbo].[Cliente] WITH CHECK CHECK CONSTRAINT [FK_Cliente_Pessoa];

ALTER TABLE [dbo].[PessoaDocumentos] WITH CHECK CHECK CONSTRAINT [FK_PessoaDocumentos_Pessoa];

ALTER TABLE [dbo].[PessoaEmails] WITH CHECK CHECK CONSTRAINT [FK_PessoaEmails_Pessoa];

ALTER TABLE [dbo].[PessoaEnderecos] WITH CHECK CHECK CONSTRAINT [FK_PessoaEnderecos_Cidade];

ALTER TABLE [dbo].[PessoaEnderecos] WITH CHECK CHECK CONSTRAINT [FK_PessoaEnderecos_Pessoa];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        DECLARE @VarDecimalSupported AS BIT;
        SELECT @VarDecimalSupported = 0;
        IF ((ServerProperty(N'EngineEdition') = 3)
            AND (((@@microsoftversion / power(2, 24) = 9)
                  AND (@@microsoftversion & 0xffff >= 3024))
                 OR ((@@microsoftversion / power(2, 24) = 10)
                     AND (@@microsoftversion & 0xffff >= 1600))))
            SELECT @VarDecimalSupported = 1;
        IF (@VarDecimalSupported > 0)
            BEGIN
                EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
            END
    END


GO
