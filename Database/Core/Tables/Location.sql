CREATE TABLE [Core].[Location] (
    [LocationID]         INT            NOT NULL,
    [CustomerID]         INT            NOT NULL,
    [LocationTypeID]     INT            NOT NULL,
    [AddressID]          INT            NOT NULL,
    [ParentLocationID]   NCHAR (10)     NOT NULL,
    [Name]               NVARCHAR (35)  NOT NULL,
    [Description]        NVARCHAR (100) NULL,
    [PersonCapacity]     INT            CONSTRAINT [DF_Location_PersonCapacity] DEFAULT ((0)) NOT NULL,
    [CreatedDateTime]    DATETIME       CONSTRAINT [DF_Location_CreatedDateTime] DEFAULT (getdate()) NOT NULL,
    [ModifiedDateTime]   DATETIME       NULL,
    [CreatedByPersonID]  INT            NULL,
    [ModifiedByPersonID] INT            NULL,
    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([LocationID] ASC),
    CONSTRAINT [FK_Location_Address] FOREIGN KEY ([AddressID]) REFERENCES [Core].[Address] ([AddressID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Location_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Core].[Customer] ([CustomerID])
);

