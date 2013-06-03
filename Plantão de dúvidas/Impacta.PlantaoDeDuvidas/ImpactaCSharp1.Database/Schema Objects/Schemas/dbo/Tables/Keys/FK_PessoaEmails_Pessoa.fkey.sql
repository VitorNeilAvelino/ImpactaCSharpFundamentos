ALTER TABLE [dbo].[PessoaEmails]
    ADD CONSTRAINT [FK_PessoaEmails_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

