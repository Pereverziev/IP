CREATE TABLE [dbo].[dictionary] (
    [Id]            INT            NOT NULL IDENTITY,
    [word]          NVARCHAR (30)  NOT NULL,
    [transcription] NVARCHAR (40)  NULL,
    [definition]    NVARCHAR (100) NULL,
    [adding_date]   DATETIME       DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SELECT * FROM dictionary;