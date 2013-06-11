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

