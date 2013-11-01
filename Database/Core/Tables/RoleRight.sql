CREATE TABLE [Core].[RoleRight] (
    [RoleID]  INT NOT NULL,
    [RightID] INT NOT NULL,
    CONSTRAINT [PK_RoleRight] PRIMARY KEY CLUSTERED ([RoleID] ASC, [RightID] ASC),
    CONSTRAINT [FK_RoleRight_Right] FOREIGN KEY ([RightID]) REFERENCES [List].[Right] ([RightID]) ON DELETE CASCADE,
    CONSTRAINT [FK_RoleRight_Role] FOREIGN KEY ([RoleID]) REFERENCES [Core].[Role] ([RoleID]) ON DELETE CASCADE
);

