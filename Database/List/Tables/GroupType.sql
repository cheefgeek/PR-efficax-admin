CREATE TABLE [List].[GroupType] (
    [GroupTypeID]        INT            NOT NULL,
    [Name]               NVARCHAR (50)  NOT NULL,
    [Description]        NVARCHAR (200) NULL,
    [CreatedDateTime]    DATETIME       CONSTRAINT [DF_Table_1_CreatedByDateTime] DEFAULT (getdate()) NOT NULL,
    [ModifiedDateTime]   DATETIME       NULL,
    [CreateByPersonID]   INT            NULL,
    [ModifiedByPersonID] INT            NULL,
    CONSTRAINT [PK_GroupType] PRIMARY KEY CLUSTERED ([GroupTypeID] ASC)
);

