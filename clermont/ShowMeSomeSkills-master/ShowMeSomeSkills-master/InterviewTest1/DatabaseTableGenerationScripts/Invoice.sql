USE [InterviewTest.MyContext]
GO

/****** Object:  Table [dbo].[Invoices]    Script Date: 7/28/2015 4:41:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [nvarchar](max) NULL,
	[CompanyName] [nvarchar](max) NULL,
	[BillingContact] [nvarchar](max) NULL,
	[BillingStreet] [nvarchar](max) NULL,
	[BillingCity] [nvarchar](max) NULL,
	[BillingState] [nvarchar](max) NULL,
	[BillingZip] [nvarchar](max) NULL,
	[PostedDate] [datetime] NOT NULL,
	[ShippingDate] [datetime] NOT NULL,
	[RequisitionDate] [datetime] NOT NULL,
	[TaxRate] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Shipping] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Commision] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Invoices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


