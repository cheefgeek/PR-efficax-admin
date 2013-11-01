CREATE TABLE [Core].[Role] (
    [RoleID]      INT           NOT NULL,
    [CustomerID]  INT           NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([RoleID] ASC)
);

