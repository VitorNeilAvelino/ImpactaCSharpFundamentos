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

