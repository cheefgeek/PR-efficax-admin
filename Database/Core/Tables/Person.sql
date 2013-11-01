CREATE TABLE [Core].[Person] (
    [PersonID]           INT           NOT NULL,
    [AddressID]          INT           NOT NULL,
    [UserName]           NVARCHAR (50) NOT NULL,
    [Password]           NVARCHAR (50) NOT NULL,
    [FirstName]          NVARCHAR (50) NOT NULL,
    [MiddleName]         NCHAR (10)    NULL,
    [LastName]           NVARCHAR (50) NOT NULL,
    [CustomerID]         INT           NOT NULL,
    [ImageThumbnail]     VARCHAR (250) NULL,
    [ImageHiRes]         VARCHAR (250) NULL,
    [CreatedDateTime]    DATETIME      CONSTRAINT [DF_Person_CreatedDateTime] DEFAULT (getdate()) NOT NULL,
    [ModifiedByDateTime] DATETIME      NOT NULL,
    [CreatedByPersonID]  INT           NULL,
    [ModifiedByPersonID] INT           NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonID] ASC),
    CONSTRAINT [FK_Person_Address] FOREIGN KEY ([AddressID]) REFERENCES [Core].[Address] ([AddressID]),
    CONSTRAINT [FK_Person_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Core].[Customer] ([CustomerID]) ON DELETE CASCADE
);

