CREATE TABLE [Core].[Group] (
    [GroupID]          INT            NOT NULL,
    [ParentGroupID]    INT            NULL,
    [CustomerID]       INT            NOT NULL,
    [GroupTypeID]      INT            NOT NULL,
    [AddressID]        INT            NULL,
    [Name]             NVARCHAR (50)  NOT NULL,
    [Description]      NVARCHAR (200) NULL,
    [CreatedDateTime]  DATETIME       CONSTRAINT [DF_Group_CreatedDateTime] DEFAULT (getdate()) NOT NULL,
    [ModifiedDateTime] DATETIME       CONSTRAINT [DF_Group_ModifiedDateTime] DEFAULT (getdate()) NOT NULL,
    [CreateByUserID]   INT            NULL,
    [ModifiedByUserID] INT            NULL,
    CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([GroupID] ASC),
    CONSTRAINT [FK_Group_Address] FOREIGN KEY ([AddressID]) REFERENCES [Core].[Address] ([AddressID]),
    CONSTRAINT [FK_Group_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Core].[Customer] ([CustomerID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Group_GroupType] FOREIGN KEY ([GroupTypeID]) REFERENCES [List].[GroupType] ([GroupTypeID])
);

