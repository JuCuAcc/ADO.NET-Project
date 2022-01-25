

CREATE TABLE [dbo].[library_person] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [fullname] VARCHAR (50) NULL,
    [username] VARCHAR (50) NULL,
    [password] VARCHAR (50) NULL,
    [email]    VARCHAR (50) NULL,
    [contact]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[books_info]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[books_name] VARCHAR(50) NULL,
	[books_author_name] VARCHAR(50) NULL,
	[books_publication_name] VARCHAR(50) NULL,
	[books_purchase_date] DATE NULL,
	[books_price] INT NULL,
	[books_quantity] INT NULL

)
