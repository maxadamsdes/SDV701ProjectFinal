CREATE TABLE [dbo].[Order]
(
	[ID]			INT		IDENTITY(1,1)		NOT NULL,
	[ItemID]		INT		NOT NULL,
	[Quantity]		INT		NULL,
	[PriceTotal]	Decimal	NULL
	PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [FK_Order_Instrument] FOREIGN KEY (ItemID) REFERENCES [dbo].[Instrument] ([ID])
)
