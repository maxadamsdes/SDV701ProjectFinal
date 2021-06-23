CREATE TABLE [dbo].[Order] (
    [ID]			INT          IDENTITY (1, 1) NOT NULL,
	[CustomerName]	NVARCHAR (50)	 NULL,
	[PhoneNumber]	NVARCHAR (50)	 NULL,
    [ItemID]		INT				 NOT NULL,
    [Quantity]		INT				 NULL,
    [PriceTotal]	DECIMAL (18)	 NULL,
    [Status]		INT				 NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Order_Instrument] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Instrument] ([ID])
);

