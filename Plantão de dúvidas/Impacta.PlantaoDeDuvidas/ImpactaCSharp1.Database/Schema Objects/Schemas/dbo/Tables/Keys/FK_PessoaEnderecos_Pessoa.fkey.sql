ALTER TABLE [dbo].[PessoaEnderecos]
    ADD CONSTRAINT [FK_PessoaEnderecos_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

