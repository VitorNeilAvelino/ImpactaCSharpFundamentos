ALTER TABLE [dbo].[Cliente]
    ADD CONSTRAINT [FK_Cliente_Pessoa] FOREIGN KEY ([Pessoa_Id]) REFERENCES [dbo].[Pessoa] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

