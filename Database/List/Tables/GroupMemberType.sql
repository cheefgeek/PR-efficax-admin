CREATE TABLE [List].[GroupMemberType] (
    [GroupMemberTypeID] INT           NOT NULL,
    [Name]              VARCHAR (50)  NOT NULL,
    [Description]       VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_GroupMemberType] PRIMARY KEY CLUSTERED ([GroupMemberTypeID] ASC)
);

