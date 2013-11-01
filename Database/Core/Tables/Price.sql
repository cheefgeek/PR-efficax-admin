CREATE TABLE [Core].[Price] (
    [PriceID]           INT   NOT NULL,
    [PriceListID]       INT   NOT NULL,
    [BillingIntervalID] INT   NOT NULL,
    [Price]             MONEY NOT NULL,
    CONSTRAINT [PK_Price] PRIMARY KEY CLUSTERED ([PriceID] ASC),
    CONSTRAINT [FK_Price_BillingInterval] FOREIGN KEY ([BillingIntervalID]) REFERENCES [List].[BillingInterval] ([BillingIntervalID]),
    CONSTRAINT [FK_Price_PriceList] FOREIGN KEY ([PriceListID]) REFERENCES [Core].[PriceList] ([PriceListID]) ON DELETE CASCADE
);

