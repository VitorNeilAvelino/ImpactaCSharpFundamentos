ALTER TABLE [dbo].[Cidade]
    ADD CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY ([Estado_Id]) REFERENCES [dbo].[Estado] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

