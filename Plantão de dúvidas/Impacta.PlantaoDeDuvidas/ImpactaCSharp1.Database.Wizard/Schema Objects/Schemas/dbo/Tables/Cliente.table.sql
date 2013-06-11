CREATE TABLE [dbo].[Cliente] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [Pessoa_Id]      INT             NOT NULL,
    [Renda]          DECIMAL (18, 2) NOT NULL,
    [DataNascimento] DATETIME        NOT NULL
);

