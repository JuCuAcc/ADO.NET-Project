CREATE TABLE [dbo].[library_person] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [fullname] VARCHAR (50) NULL,
    [username] VARCHAR (50) NULL,
    [password] VARCHAR (50) NULL,
    [email]    VARCHAR (50) NULL,
    [contact]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
