CREATE TABLE [Core].[PriceList] (
    [PriceListID]       INT           NOT NULL,
    [StartDate]         DATETIME      NULL,
    [EndDate]           DATETIME      NULL,
    [Description]       VARCHAR (200) NOT NULL,
    [CreatedDate]       DATETIME      NOT NULL,
    [CreatedByPersonID] INT           NOT NULL,
    CONSTRAINT [PK_PriceList] PRIMARY KEY CLUSTERED ([PriceListID] ASC)
);

