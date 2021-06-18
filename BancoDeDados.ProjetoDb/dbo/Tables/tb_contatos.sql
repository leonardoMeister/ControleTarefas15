CREATE TABLE [dbo].[tb_contatos]
(
	[Id] INT IDENTITY(1,1) not null PRIMARY KEY, 
    [Nome] VARCHAR(50) NULL, 
    [Email] VARCHAR(20) NULL, 
    [Telefone] VARCHAR(13) NULL, 
    [Empresa] VARCHAR(20) NULL, 
    [Cargo] VARCHAR(20) NULL
)
