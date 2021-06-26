CREATE TABLE [dbo].[tb_compromisso] (
    [id_compromisso]    INT  IDENTITY(1,1)            NOT NULL PRIMARY KEY,
    [assunto]           VARCHAR (50)    NULL,
    [data_compromisso]  DATETIME        NULL,
    [local_compromisso] VARCHAR (50)    NULL,
    [data_termino]      DATETIME        NULL,
    [tipo_compromisso]  TINYINT         NULL,
    [link_compromisso]  VARCHAR(50) NULL,
    [contato_id]        INT             NULL,
    CONSTRAINT [FK_tb_compromisso_tb_contatos] FOREIGN KEY ([contato_id]) REFERENCES [dbo].[tb_contatos] ([Id])
);

