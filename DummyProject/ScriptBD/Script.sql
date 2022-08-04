GO
USE [master]
GO
IF EXISTS 
   (SELECT name FROM master.dbo.sysdatabases 
    WHERE name = N'dummy')
BEGIN
    drop database [dummy]
END
GO
CREATE DATABASE [dummy]
GO
USE [dummy]
GO
CREATE TABLE [dbo].[dummyTable](
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [varchar](100) NULL,
	[document_number] [varchar](10) NULL,
	[salary] [decimal](18, 2) NULL,
	[age] [int] NULL,
	[profile] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[phone_number] [varchar](20) NULL
) 
GO

INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Juan Perez', '11111', CAST(1555.00 AS Decimal(18, 2)), 25, 'Admi', 'Av. Siempre Viva', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Pancho Pistolas', '11111', CAST(1555.00 AS Decimal(18, 2)), 17, 'Admi', 'Av. Siempre Viva 1', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Cristiano Ronaldo', '11111', CAST(1555.00 AS Decimal(18, 2)), 28, 'Admi', 'Av. Siempre Viva 2', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Pablo Lavandeira', '11111', CAST(1555.00 AS Decimal(18, 2)), 30, 'Admi', 'Av. Siempre Viva 3', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Hernan Barcos', '11111', CAST(1555.00 AS Decimal(18, 2)), 18, 'Admi', 'Av. Siempre Viva 4', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Lionel Messi', '11111', CAST(1555.00 AS Decimal(18, 2)), 17, 'Admi', 'Av. Siempre Viva 5', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Angel Campos', '11111', CAST(1555.00 AS Decimal(18, 2)), 25, 'Admi', 'Av. Siempre Viva 6', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Ricardo Gareca', '11111', CAST(1555.00 AS Decimal(18, 2)), 30, 'Admi', 'Av. Siempre Viva 7', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Christian Cueva', '11111', CAST(1555.00 AS Decimal(18, 2)), 32, 'Admi', 'Av. Siempre Viva 8', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Leslie Shaw', '11111', CAST(1555.00 AS Decimal(18, 2)), 15, 'Admi', 'Av. Siempre Viva 9', '+5177777777')
INSERT [dbo].[dummyTable] ([name], [document_number], [salary], [age], [profile], [address], [phone_number]) VALUES ('Maria la del Barrio', '11111', CAST(1555.00 AS Decimal(18, 2)), 60, 'Admi', 'Av. Siempre Viva 10', '+5177777777')

GO

PRINT 'BASE DE DATOS CREADA'

