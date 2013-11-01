CREATE TABLE [Core].[GroupMember] (
    [CustomerID]        INT NOT NULL,
    [GroupMemberTypeID] INT NOT NULL,
    [GroupID]           INT NOT NULL,
    [PersonID]          INT NOT NULL,
    CONSTRAINT [PK_GroupMember_1] PRIMARY KEY CLUSTERED ([GroupID] ASC, [PersonID] ASC),
    CONSTRAINT [FK_GroupMember_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Core].[Customer] ([CustomerID]),
    CONSTRAINT [FK_GroupMember_Group] FOREIGN KEY ([GroupID]) REFERENCES [Core].[Group] ([GroupID]),
    CONSTRAINT [FK_GroupMember_GroupMemberType] FOREIGN KEY ([GroupMemberTypeID]) REFERENCES [List].[GroupMemberType] ([GroupMemberTypeID]),
    CONSTRAINT [FK_GroupMember_Person] FOREIGN KEY ([PersonID]) REFERENCES [Core].[Person] ([PersonID]) ON DELETE CASCADE
);

