CREATE TABLE [Core].[PersonRole] (
    [PersonID] INT NOT NULL,
    [RoleID]   INT NOT NULL,
    CONSTRAINT [PK_PersonRole] PRIMARY KEY CLUSTERED ([PersonID] ASC, [RoleID] ASC),
    CONSTRAINT [FK_PersonRole_Person] FOREIGN KEY ([PersonID]) REFERENCES [Core].[Person] ([PersonID]) ON DELETE CASCADE,
    CONSTRAINT [FK_PersonRole_Role] FOREIGN KEY ([RoleID]) REFERENCES [Core].[Role] ([RoleID]) ON DELETE CASCADE
);

