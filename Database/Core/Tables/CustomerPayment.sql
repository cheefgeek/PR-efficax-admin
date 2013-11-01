CREATE TABLE [Core].[CustomerPayment] (
    [CustomerPaymentID] INT      NOT NULL,
    [CustomerID]        INT      NOT NULL,
    [PriceID]           INT      NOT NULL,
    [PaymentDate]       DATETIME NOT NULL,
    CONSTRAINT [PK_CustomerPayment] PRIMARY KEY CLUSTERED ([CustomerPaymentID] ASC),
    CONSTRAINT [FK_CustomerPayment_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Core].[Customer] ([CustomerID]) ON DELETE CASCADE,
    CONSTRAINT [FK_CustomerPayment_Price] FOREIGN KEY ([PriceID]) REFERENCES [Core].[Price] ([PriceID])
);

