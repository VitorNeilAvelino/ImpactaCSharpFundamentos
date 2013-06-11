ALTER TABLE [dbo].[PessoaEnderecos]
    ADD CONSTRAINT [FK_PessoaEnderecos_Cidade] FOREIGN KEY ([Cidade_Id]) REFERENCES [dbo].[Cidade] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

