CREATE TABLE [Core].[Address] (
    [AddressID]          INT           NOT NULL,
    [CustomerID]         INT           NOT NULL,
    [Name]               NVARCHAR (80) NULL,
    [Attention]          NVARCHAR (80) NULL,
    [Address1]           NVARCHAR (50) NULL,
    [Address2]           NVARCHAR (50) NULL,
    [Address3]           NVARCHAR (50) NULL,
    [City]               NVARCHAR (50) NULL,
    [StateProvince]      NVARCHAR (10) NULL,
    [PostalCode]         NVARCHAR (10) NULL,
    [CreateDateTime]     DATETIME      CONSTRAINT [DF_Address_CreateDateTime] DEFAULT (getdate()) NOT NULL,
    [ModifiedDateTime]   DATETIME      NULL,
    [CreatedByPersonID]  INT           NULL,
    [ModifiedByPersonID] INT           NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([AddressID] ASC),
    CONSTRAINT [FK_Address_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Core].[Customer] ([CustomerID]) ON DELETE CASCADE
);

