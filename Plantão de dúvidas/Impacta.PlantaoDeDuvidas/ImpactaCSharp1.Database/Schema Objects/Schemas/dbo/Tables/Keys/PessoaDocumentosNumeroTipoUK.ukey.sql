﻿ALTER TABLE [dbo].[PessoaDocumentos]
    ADD CONSTRAINT [PessoaDocumentosNumeroTipoUK] UNIQUE NONCLUSTERED ([Numero] ASC, [Tipo] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

