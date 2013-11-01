CREATE TABLE [Schedule].[Event] (
    [EventID]    INT           NOT NULL,
    [CustomerID] INT           NOT NULL,
    [Name]       VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([EventID] ASC)
);

