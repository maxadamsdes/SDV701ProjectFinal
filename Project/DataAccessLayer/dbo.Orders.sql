CREATE TABLE [dbo].[Orders]
(
	[ID]			INT		NOT NULL,
	[ItemID]		INT		NOT NULL,
	[Quantity]		INT		NOT NULL,
	[PriceTotal]	Decimal	NOT NULL
	PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [FK_Item_ID] FOREIGN KEY (ItemID) REFERENCES [dbo].[Instrument] ([ID])
)
