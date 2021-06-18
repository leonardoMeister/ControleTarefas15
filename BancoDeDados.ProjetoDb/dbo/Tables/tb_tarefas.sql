CREATE TABLE [dbo].[tb_tarefas] (
    [Id]          INT IDENTITY(1,1) not null PRIMARY KEY, 
    [Titulo]        VARCHAR (50) NULL,
    [DataCricacao]  DATETIME     NULL,
    [DataConclucao] DATETIME     NULL,
    [Percentual]    VARCHAR (5)  NULL,
    [Prioridade]    VARCHAR (5)  NULL,
);

