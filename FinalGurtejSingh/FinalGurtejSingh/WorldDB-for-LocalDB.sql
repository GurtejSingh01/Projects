/*
Created by: Gursharan Tatla

Data taken from: https://www.back4app.com/database/back4app/list-of-all-continents-countries-cities
*/

USE [WorldDB]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 12-Dec-20 7:42:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](100) NOT NULL,
	[IsCapital] [bit] NOT NULL,
	[Population] [bigint] NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
))
GO
/****** Object:  Table [dbo].[Continents]    Script Date: 12-Dec-20 7:42:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinentID] [int] IDENTITY(1,1) NOT NULL,
	[ContinentCode] [nvarchar](50) NOT NULL,
	[ContinentName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinentID] ASC
))
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 12-Dec-20 7:42:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryCode] [nvarchar](50) NOT NULL,
	[CountryName] [nvarchar](100) NOT NULL,
	[Language] [nvarchar](100) NOT NULL,
	[Currency] [nvarchar](50) NOT NULL,
	[ContinentID] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
))
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (1, N'Kabul', 1, 3043532, 1)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (2, N'Ghazni', 0, 141000, 1)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (3, N'Kandahar', 0, 391190, 1)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (4, N'Dhaka', 1, 10356500, 2)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (5, N'Chittagong', 0, 3920222, 2)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (6, N'Toronto', 0, 2600000, 11)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (7, N'Ottawa', 1, 812129, 11)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (8, N'Vancouver', 0, 600000, 11)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (9, N'Cairo', 1, 7734614, 5)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (10, N'Suez', 0, 488125, 5)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (11, N'Giza', 0, 2443203, 5)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (12, N'Paris', 1, 2138551, 10)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (13, N'Lyon', 0, 472317, 10)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (14, N'Marseille', 0, 794811, 10)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (15, N'Berlin', 1, 3426354, 8)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (16, N'Munich', 0, 1260391, 8)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (17, N'Dortmund', 0, 588462, 8)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (18, N'Tokyo', 1, 8336599, 3)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (19, N'Yokohama', 0, 3574443, 3)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (20, N'Hiroshima', 0, 1143841, 3)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (21, N'Mexico City', 1, 12294193, 13)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (22, N'Tijuana', 0, 1376457, 13)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (23, N'Manila', 1, 1600000, 4)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (24, N'Quezon City', 0, 2761720, 4)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (25, N'Pretoria', 1, 1619438, 6)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (26, N'Cape Town', 0, 3433441, 6)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (27, N'Durban', 0, 3120282, 6)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (28, N'Madrid', 1, 3255944, 9)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (29, N'Barcelona', 0, 1621537, 9)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (30, N'Sevilla', 0, 703206, 9)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (31, N'Chicago', 0, 2720546, 12)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (33, N'New York City', 0, 8175133, 12)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (34, N'Washington, D.C.', 1, 684498, 12)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (35, N'Harare', 1, 1542813, 7)
INSERT [dbo].[Cities] ([CityID], [CityName], [IsCapital], [Population], [CountryID]) VALUES (36, N'Bulawayo', 0, 699385, 7)
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ContinentID], [ContinentCode], [ContinentName]) VALUES (1, N'AF', N'Africa')
INSERT [dbo].[Continents] ([ContinentID], [ContinentCode], [ContinentName]) VALUES (2, N'AS', N'Asia')
INSERT [dbo].[Continents] ([ContinentID], [ContinentCode], [ContinentName]) VALUES (3, N'EU', N'Europe')
INSERT [dbo].[Continents] ([ContinentID], [ContinentCode], [ContinentName]) VALUES (4, N'NA', N'North America')
SET IDENTITY_INSERT [dbo].[Continents] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (1, N'AF', N'Afganistan', N'Pashto, Dari', N'Afghan Afghani', 2)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (2, N'BD', N'Bangladesh', N'Bengali', N'Bangladeshi Taka', 2)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (3, N'JP', N'Japan', N'Japanese', N'Japanese Yen', 2)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (4, N'PH', N'Philippines', N'Filipino', N'Philippine Peso', 2)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (5, N'EG', N'Egypt', N'Arabic', N'Egyptian Pound', 1)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (6, N'ZA', N'South Africa', N'Afrikaans, English', N'South African Rand', 1)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (7, N'ZW', N'Zimbabwe', N'Shona, English', N'Zimbabwean Dollar', 1)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (8, N'DE', N'Germany', N'German', N'Euro', 3)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (9, N'ES', N'Spain', N'Spanish', N'Euro', 3)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (10, N'FR', N'France', N'French', N'Euro', 3)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (11, N'CA', N'Canada', N'English, French', N'Canadian Dollar', 4)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (12, N'US', N'United States', N'English', N'United States Dollar', 4)
INSERT [dbo].[Countries] ([CountryID], [CountryCode], [CountryName], [Language], [Currency], [ContinentID]) VALUES (13, N'MX', N'Mexico', N'Spanish', N'Mexican Peso', 4)
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Countries] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Countries]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinentID])
REFERENCES [dbo].[Continents] ([ContinentID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
USE [master]
GO
ALTER DATABASE [WorldDB] SET  READ_WRITE 
GO
