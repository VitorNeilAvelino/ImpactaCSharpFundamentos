ALTER TABLE [dbo].[PessoaDocumentos]
    ADD CONSTRAINT [FK_PessoaDocumentos_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

