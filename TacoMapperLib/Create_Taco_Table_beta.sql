USE [TestLocal]
GO

/****** Object:  Table [dbo].[Taco]    Script Date: 05/07/2014 10:15:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Taco](
	[ID] [int] NOT NULL,
	[TacoType] [int] NOT NULL,
	[TacoFillingType] [varchar](50) NOT NULL,
	[TortillaType] [int] NOT NULL,
	[TortillaShellType] [int] NOT NULL,
	[SalsaType] [varchar](50) NOT NULL,
	[TacoToppingsType] [varchar](200) NOT NULL,
	[TacoAvailablilityType] [int] NOT NULL,
	[TacoLocationType] [int] NOT NULL,
	[PhotoURL] [varchar](100) NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_Taco] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


