CREATE TABLE [dbo].[Instrument]
(
	[ID]			INT				NOT NULL PRIMARY KEY,
	[CategoryID]				INT				NOT NULL,
	[Description]				NVARCHAR		NOT NULL,
	[PricePerItem]				DECIMAL(10, 2)	NULL,
	[LastModified]				DATETIME		NOT NULL,
	[QuantityLeft]				INT				NULL,
	[Condition]					NVARCHAR		NOT NULL,
	[BusinessSpecificDetail]	NVARCHAR		NULL,

	PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [FK_Instrument_Category] FOREIGN KEY (CategoryID) REFERENCES [dbo].[Category] ([ID])
)
