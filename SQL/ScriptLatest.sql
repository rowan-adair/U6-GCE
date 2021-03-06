USE [master]
GO
/****** Object:  Database [AdairRA2EventsUnlimited]    Script Date: 30/01/2018 23:40:36 ******/
CREATE DATABASE [AdairRA2EventsUnlimited]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdairRA2EventsUnlimited', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AdairRA2EventsUnlimited.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AdairRA2EventsUnlimited_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AdairRA2EventsUnlimited_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdairRA2EventsUnlimited].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET ARITHABORT OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET  MULTI_USER 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET QUERY_STORE = OFF
GO
USE [AdairRA2EventsUnlimited]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [AdairRA2EventsUnlimited]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 30/01/2018 23:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[VenueID] [int] NOT NULL,
	[AppSlotID] [int] NOT NULL,
	[AppointmentDate] [date] NOT NULL,
	[DateBooking] [date] NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppSlots]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppSlots](
	[AppSlotID] [int] IDENTITY(1,1) NOT NULL,
	[TimeSlot] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AppSlotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerFirstName] [varchar](128) NOT NULL,
	[CustomerSurname] [varchar](128) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[CustomerAddress] [varchar](128) NOT NULL,
	[CustomerPostCode] [varchar](16) NOT NULL,
	[CustomerEmail] [varchar](40) NOT NULL,
	[CustomerTelephone] [varchar](15) NOT NULL,
	[CustomerDateOfBirth] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DayTable]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DayTable](
	[DayID] [int] IDENTITY(1,1) NOT NULL,
	[Day] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[staffID] [int] IDENTITY(1,1) NOT NULL,
	[StaffFirstName] [varchar](128) NOT NULL,
	[StaffSecondName] [varchar](128) NOT NULL,
	[staffRole] [int] NOT NULL,
	[VenueID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[staffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffAvailability]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffAvailability](
	[StaffID] [int] NOT NULL,
	[AppID] [int] NOT NULL,
	[DayID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffRole]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffRole](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](128) NULL,
 CONSTRAINT [PK_StaffRole] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venue]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venue](
	[VenueID] [int] IDENTITY(1,1) NOT NULL,
	[VenueName] [varchar](128) NOT NULL,
	[VenueAddress] [varchar](128) NOT NULL,
	[VenueTelephone] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VenueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wedding]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wedding](
	[WeddingID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[VenueID] [int] NOT NULL,
	[EntertainmentID] [int] NOT NULL,
	[Invitations] [char](1) NOT NULL,
	[Menus] [int] NOT NULL,
	[Flowers] [char](1) NOT NULL,
	[Dress] [char](1) NOT NULL,
	[Suits] [char](1) NOT NULL,
	[WeddingCars] [char](1) NOT NULL,
	[TravelArrangements] [char](1) NOT NULL,
	[NumberOfGuests] [int] NOT NULL,
	[DateOfWedding] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WeddingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeddingBooking]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeddingBooking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[WeddingID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[DateOfBooking] [date] NOT NULL,
	[DateOfWedding] [date] NOT NULL,
	[OverallCost] [decimal](18, 0) NOT NULL,
	[DepositCost] [decimal](18, 0) NOT NULL,
	[BookingConfirmed] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeddingEntertainment]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeddingEntertainment](
	[WeddingEntertainmentID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](128) NULL,
	[EntertainerPhone] [varchar](15) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[WeddingEntertainmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeddingMenus]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeddingMenus](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[Provider] [varchar](15) NOT NULL,
	[NoOfCourses] [int] NOT NULL,
	[Price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1051, 16, 1, 1, 1, CAST(N'2018-01-14' AS Date), CAST(N'2018-01-11' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1052, 1, 2, 1, 1, CAST(N'2018-01-14' AS Date), CAST(N'2018-01-11' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1053, 2, 3, 1, 1, CAST(N'2018-01-14' AS Date), CAST(N'2018-01-11' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1055, 17, 19, 1, 2, CAST(N'2018-01-14' AS Date), CAST(N'2018-01-11' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1056, 3, 1, 1, 1, CAST(N'2018-01-12' AS Date), CAST(N'2018-01-11' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1057, 20, 8, 2, 2, CAST(N'2018-01-30' AS Date), CAST(N'2018-01-24' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1059, 2, 2, 1, 1, CAST(N'2019-07-11' AS Date), CAST(N'2018-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1060, 3, 3, 1, 1, CAST(N'2019-07-11' AS Date), CAST(N'2018-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1061, 4, 20, 1, 3, CAST(N'2019-07-11' AS Date), CAST(N'2018-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1062, 5, 1, 1, 2, CAST(N'2019-07-11' AS Date), CAST(N'2018-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1063, 6, 7, 2, 1, CAST(N'2019-07-12' AS Date), CAST(N'2018-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1065, 8, 8, 2, 2, CAST(N'2017-01-29' AS Date), CAST(N'2017-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1066, 9, 7, 2, 1, CAST(N'2017-01-26' AS Date), CAST(N'2017-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1067, 10, 12, 3, 3, CAST(N'2019-11-20' AS Date), CAST(N'2018-01-25' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1068, 8, 7, 2, 1, CAST(N'2017-02-04' AS Date), CAST(N'2017-01-30' AS Date))
INSERT [dbo].[Appointments] ([AppointmentID], [CustomerID], [StaffID], [VenueID], [AppSlotID], [AppointmentDate], [DateBooking]) VALUES (1069, 20, 1, 1, 3, CAST(N'2017-02-17' AS Date), CAST(N'2017-01-30' AS Date))
SET IDENTITY_INSERT [dbo].[Appointments] OFF
SET IDENTITY_INSERT [dbo].[AppSlots] ON 

INSERT [dbo].[AppSlots] ([AppSlotID], [TimeSlot]) VALUES (1, N'1000 - 1200')
INSERT [dbo].[AppSlots] ([AppSlotID], [TimeSlot]) VALUES (2, N'1300 - 1500')
INSERT [dbo].[AppSlots] ([AppSlotID], [TimeSlot]) VALUES (3, N'1600 - 1800')
SET IDENTITY_INSERT [dbo].[AppSlots] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (1, N'Rowan', N'Adair', N'Male', N'22 Houston Drive', N'BT5 6AZ', N'radair@gmail.com', N'+447482006099', CAST(N'1998-07-18' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (2, N'John', N'Tester', N'Male', N'23 Black Road', N'BT21 6AJ', N'jtester@btintnet.com', N'+447732325300', CAST(N'1963-11-23' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (3, N'Susan', N'Smith', N'Female', N'44 Wallaby Way', N'BT5 5AB', N'susans@gmail.com', N'+447443648638', CAST(N'1996-07-18' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (4, N'Susan', N'James', N'Female', N'7 Cameronian Drive', N'BT5 7AB', N'sj@mail.net', N'+447719017603', CAST(N'1990-02-23' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (5, N'John', N'Jones', N'Male', N'1 Uxbridge Hayes', N'UB11 1BB', N'johnappleseed@icloud.com', N'+447899665921', CAST(N'1976-04-01' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (6, N'Theresa', N'May', N'Female', N'10 Downing Street', N'SW1A 2AA', N'tmay@gov.uk', N'+447575315005', CAST(N'1956-10-01' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (7, N'Karl', N'Grant', N'Female', N'1 Woman Pride', N'BO9 7AY', N'karlwomanpride@gmail.com', N'+447482006099', CAST(N'1998-04-28' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (8, N'Adam', N'Henderson', N'Male', N'6 Marina Park', N'BT3 8AB', N'ahenderson@gmail.com', N'+447482006099', CAST(N'1998-07-15' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (9, N'Martha', N'Martha', N'Female', N'22 White Road', N'BT5 7AB', N'mjones@mail.net', N'+447482006099', CAST(N'1990-02-08' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (10, N'Chuck', N'Lesner', N'Male', N'24 Houston Road', N'BT5 6AZ', N'clesner@mail.net', N'+447525769171', CAST(N'1999-07-18' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (11, N'Susan', N'Shore', N'Female', N'33 Fake Road', N'BT5 7AB', N'sshore@goooglemail.com', N'+447802506780', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (12, N'Karen', N'Smith', N'Female', N'33 White Road', N'BT7 4AB', N'ksmith@gmail.com', N'+447482006099', CAST(N'1990-06-14' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (13, N'Janet', N'Adair', N'Female', N'21 Houston Drive', N'BT5 6AZ', N'ljadair@gmail.com', N'+447719176240', CAST(N'1966-01-27' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (14, N'Mirriam', N'Withers', N'Female', N'28 Swnaston Road', N'BT21 6EB', N'mwethers@mail.net', N'+447482006099', CAST(N'1988-12-27' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (15, N'Smtih', N'Susan', N'Female', N'33 Fake Street', N'BT44 7AB', N'ssuan@mail.net', N'+447482006099', CAST(N'1988-12-27' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (16, N'John', N'Smyth', N'Male', N'123 sdrfsfg', N'BT5 6BA', N'asdf@asdf.com', N'+447874545541', CAST(N'1990-01-11' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (17, N'Jane', N'Smyth', N'Female', N'123 sdfzdf', N'BT5 9BB', N'sdf@email.com', N'+447874545545', CAST(N'1990-01-11' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (18, N'John', N'Test', N'Male', N'123 Fake Street', N'BT5 6AZ', N'jtest@mail.net', N'+447482006099', CAST(N'1999-07-18' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (19, N'Wally', N'West', N'Male', N'4 Fake Road', N'BT33 7AB', N'wwest@mail.net', N'+447482006099', CAST(N'1990-02-05' AS Date))
INSERT [dbo].[Customer] ([CustomerID], [CustomerFirstName], [CustomerSurname], [Gender], [CustomerAddress], [CustomerPostCode], [CustomerEmail], [CustomerTelephone], [CustomerDateOfBirth]) VALUES (20, N'David', N'Eve', N'Male', N'4 Roddens Crescent', N'BT22 7AB', N'deve@mail.net', N'+447810182976', CAST(N'1999-05-27' AS Date))
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[DayTable] ON 

INSERT [dbo].[DayTable] ([DayID], [Day]) VALUES (1, N'Sunday')
INSERT [dbo].[DayTable] ([DayID], [Day]) VALUES (2, N'Monday')
INSERT [dbo].[DayTable] ([DayID], [Day]) VALUES (3, N'Tuesday')
INSERT [dbo].[DayTable] ([DayID], [Day]) VALUES (4, N'Wednesday')
INSERT [dbo].[DayTable] ([DayID], [Day]) VALUES (5, N'Thursday')
INSERT [dbo].[DayTable] ([DayID], [Day]) VALUES (6, N'Friday')
INSERT [dbo].[DayTable] ([DayID], [Day]) VALUES (7, N'Saturday')
SET IDENTITY_INSERT [dbo].[DayTable] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (1, N'James', N'McAvoy', 1, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (2, N'Warren', N'Maggee', 1, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (3, N'Sharon', N'White', 1, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (5, N'Janet', N'O''Brien', 2, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (6, N'Lucy', N'Power', 3, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (7, N'Susan', N'White', 1, 2)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (8, N'James', N'White', 1, 2)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (9, N'Louise', N'Campbell', 2, 2)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (10, N'Suan', N'McGrath', 1, 3)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (11, N'Collin', N'Wills', 1, 3)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (12, N'Riognach', N'McGowan', 1, 3)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (19, N'Test', N'Tester', 1, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (20, N'Linda', N'Lavery', 1, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (21, N'Test', N'Staff', 3, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (23, N'Peter', N'Piper', 1, 1)
INSERT [dbo].[Staff] ([staffID], [StaffFirstName], [StaffSecondName], [staffRole], [VenueID]) VALUES (24, N'Timmy', N'Jones', 2, 3)
SET IDENTITY_INSERT [dbo].[Staff] OFF
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 3, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 1, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 2, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 3, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 1, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 2, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 3, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 1, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 2, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 3, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 1, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 2, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 3, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 1, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 3, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 1, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 2, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 3, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 1, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 2, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 3, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 1, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 2, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 3, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 1, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 2, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 3, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 1, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 2, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 3, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 1, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 2, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (2, 3, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 2, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 1, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 1, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 2, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 3, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 3, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 1, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 2, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (10, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 3, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 1, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 2, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 3, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 1, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 2, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 3, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (1, 3, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 1, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 1, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 2, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 3, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 1, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 1, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 1, 7)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 2, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 1, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (19, 2, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (20, 1, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (20, 2, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (20, 3, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 2, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 3, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 2, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 3, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 1, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 2, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 3, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 1, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 3, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 1, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 3, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 1, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 3, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 1, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 2, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 3, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (7, 1, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 1, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 2, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 1, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 1, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 3, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 1, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 2, 2)
GO
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 3, 2)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 2, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 2, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 3, 4)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 2, 6)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (12, 3, 3)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (19, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (19, 2, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (19, 3, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (3, 2, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (8, 2, 5)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 1, 1)
INSERT [dbo].[StaffAvailability] ([StaffID], [AppID], [DayID]) VALUES (11, 3, 1)
SET IDENTITY_INSERT [dbo].[StaffRole] ON 

INSERT [dbo].[StaffRole] ([RoleID], [Role]) VALUES (1, N'Planner')
INSERT [dbo].[StaffRole] ([RoleID], [Role]) VALUES (2, N'Co-Ordinator')
INSERT [dbo].[StaffRole] ([RoleID], [Role]) VALUES (3, N'Designer')
SET IDENTITY_INSERT [dbo].[StaffRole] OFF
SET IDENTITY_INSERT [dbo].[Venue] ON 

INSERT [dbo].[Venue] ([VenueID], [VenueName], [VenueAddress], [VenueTelephone]) VALUES (1, N'Hillview', N'346 Warren Street', N'90780566')
INSERT [dbo].[Venue] ([VenueID], [VenueName], [VenueAddress], [VenueTelephone]) VALUES (2, N'Earlgate', N'23 Castle Road', N'90556078')
INSERT [dbo].[Venue] ([VenueID], [VenueName], [VenueAddress], [VenueTelephone]) VALUES (3, N'Smithsfield', N'2 Sharp Avenue', N'90770744')
SET IDENTITY_INSERT [dbo].[Venue] OFF
SET IDENTITY_INSERT [dbo].[Wedding] ON 

INSERT [dbo].[Wedding] ([WeddingID], [CustomerID], [VenueID], [EntertainmentID], [Invitations], [Menus], [Flowers], [Dress], [Suits], [WeddingCars], [TravelArrangements], [NumberOfGuests], [DateOfWedding]) VALUES (1025, 1, 1, 3, N'Y', 1, N'N', N'N', N'N', N'N', N'Y', 36, CAST(N'2018-07-27' AS Date))
INSERT [dbo].[Wedding] ([WeddingID], [CustomerID], [VenueID], [EntertainmentID], [Invitations], [Menus], [Flowers], [Dress], [Suits], [WeddingCars], [TravelArrangements], [NumberOfGuests], [DateOfWedding]) VALUES (1026, 16, 1, 1, N'N', 1, N'Y', N'N', N'N', N'N', N'N', 37, CAST(N'2017-06-13' AS Date))
INSERT [dbo].[Wedding] ([WeddingID], [CustomerID], [VenueID], [EntertainmentID], [Invitations], [Menus], [Flowers], [Dress], [Suits], [WeddingCars], [TravelArrangements], [NumberOfGuests], [DateOfWedding]) VALUES (1027, 2, 2, 1, N'Y', 8, N'N', N'N', N'N', N'N', N'N', 60, CAST(N'2017-03-02' AS Date))
INSERT [dbo].[Wedding] ([WeddingID], [CustomerID], [VenueID], [EntertainmentID], [Invitations], [Menus], [Flowers], [Dress], [Suits], [WeddingCars], [TravelArrangements], [NumberOfGuests], [DateOfWedding]) VALUES (1028, 17, 3, 3, N'Y', 9, N'N', N'Y', N'N', N'N', N'N', 70, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Wedding] ([WeddingID], [CustomerID], [VenueID], [EntertainmentID], [Invitations], [Menus], [Flowers], [Dress], [Suits], [WeddingCars], [TravelArrangements], [NumberOfGuests], [DateOfWedding]) VALUES (1031, 20, 1, 1, N'N', 1, N'N', N'N', N'Y', N'Y', N'Y', 35, CAST(N'2022-04-02' AS Date))
SET IDENTITY_INSERT [dbo].[Wedding] OFF
SET IDENTITY_INSERT [dbo].[WeddingBooking] ON 

INSERT [dbo].[WeddingBooking] ([BookingID], [WeddingID], [StaffID], [DateOfBooking], [DateOfWedding], [OverallCost], [DepositCost], [BookingConfirmed]) VALUES (1025, 1025, 5, CAST(N'2018-01-26' AS Date), CAST(N'2018-07-27' AS Date), CAST(1950 AS Decimal(18, 0)), CAST(195 AS Decimal(18, 0)), N'Y')
INSERT [dbo].[WeddingBooking] ([BookingID], [WeddingID], [StaffID], [DateOfBooking], [DateOfWedding], [OverallCost], [DepositCost], [BookingConfirmed]) VALUES (1026, 1026, 5, CAST(N'2017-01-30' AS Date), CAST(N'2017-06-13' AS Date), CAST(1850 AS Decimal(18, 0)), CAST(185 AS Decimal(18, 0)), N'N')
INSERT [dbo].[WeddingBooking] ([BookingID], [WeddingID], [StaffID], [DateOfBooking], [DateOfWedding], [OverallCost], [DepositCost], [BookingConfirmed]) VALUES (1027, 1027, 9, CAST(N'2017-01-30' AS Date), CAST(N'2017-03-02' AS Date), CAST(1450 AS Decimal(18, 0)), CAST(145 AS Decimal(18, 0)), N'N')
INSERT [dbo].[WeddingBooking] ([BookingID], [WeddingID], [StaffID], [DateOfBooking], [DateOfWedding], [OverallCost], [DepositCost], [BookingConfirmed]) VALUES (1028, 1028, 24, CAST(N'2017-01-30' AS Date), CAST(N'2017-04-02' AS Date), CAST(1950 AS Decimal(18, 0)), CAST(179 AS Decimal(18, 0)), N'Y')
INSERT [dbo].[WeddingBooking] ([BookingID], [WeddingID], [StaffID], [DateOfBooking], [DateOfWedding], [OverallCost], [DepositCost], [BookingConfirmed]) VALUES (1031, 1031, 5, CAST(N'2018-01-30' AS Date), CAST(N'2022-04-02' AS Date), CAST(2650 AS Decimal(18, 0)), CAST(246 AS Decimal(18, 0)), N'Y')
SET IDENTITY_INSERT [dbo].[WeddingBooking] OFF
SET IDENTITY_INSERT [dbo].[WeddingEntertainment] ON 

INSERT [dbo].[WeddingEntertainment] ([WeddingEntertainmentID], [Type], [EntertainerPhone], [Price]) VALUES (1, N'Band', N'07889114', 400)
INSERT [dbo].[WeddingEntertainment] ([WeddingEntertainmentID], [Type], [EntertainerPhone], [Price]) VALUES (2, N'Pianist', N'90568043', 450)
INSERT [dbo].[WeddingEntertainment] ([WeddingEntertainmentID], [Type], [EntertainerPhone], [Price]) VALUES (3, N'Singer', N'07223360', 250)
INSERT [dbo].[WeddingEntertainment] ([WeddingEntertainmentID], [Type], [EntertainerPhone], [Price]) VALUES (4, N'DJ ', N'90790499', 480)
SET IDENTITY_INSERT [dbo].[WeddingEntertainment] OFF
SET IDENTITY_INSERT [dbo].[WeddingMenus] ON 

INSERT [dbo].[WeddingMenus] ([MenuID], [Provider], [NoOfCourses], [Price]) VALUES (1, N'Shorts Catering', 5, 800)
INSERT [dbo].[WeddingMenus] ([MenuID], [Provider], [NoOfCourses], [Price]) VALUES (8, N'Lynas', 4, 600)
INSERT [dbo].[WeddingMenus] ([MenuID], [Provider], [NoOfCourses], [Price]) VALUES (9, N'Sofos', 3, 300)
SET IDENTITY_INSERT [dbo].[WeddingMenus] OFF
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([AppSlotID])
REFERENCES [dbo].[AppSlots] ([AppSlotID])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([AppSlotID])
REFERENCES [dbo].[AppSlots] ([AppSlotID])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([staffID])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([staffID])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[StaffAvailability]  WITH CHECK ADD FOREIGN KEY([AppID])
REFERENCES [dbo].[AppSlots] ([AppSlotID])
GO
ALTER TABLE [dbo].[StaffAvailability]  WITH CHECK ADD FOREIGN KEY([DayID])
REFERENCES [dbo].[DayTable] ([DayID])
GO
ALTER TABLE [dbo].[StaffAvailability]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([staffID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([EntertainmentID])
REFERENCES [dbo].[WeddingEntertainment] ([WeddingEntertainmentID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([EntertainmentID])
REFERENCES [dbo].[WeddingEntertainment] ([WeddingEntertainmentID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([Menus])
REFERENCES [dbo].[WeddingMenus] ([MenuID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([Menus])
REFERENCES [dbo].[WeddingMenus] ([MenuID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[Wedding]  WITH CHECK ADD FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venue] ([VenueID])
GO
ALTER TABLE [dbo].[WeddingBooking]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([staffID])
GO
ALTER TABLE [dbo].[WeddingBooking]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([staffID])
GO
ALTER TABLE [dbo].[WeddingBooking]  WITH CHECK ADD FOREIGN KEY([WeddingID])
REFERENCES [dbo].[Wedding] ([WeddingID])
GO
ALTER TABLE [dbo].[WeddingBooking]  WITH CHECK ADD FOREIGN KEY([WeddingID])
REFERENCES [dbo].[Wedding] ([WeddingID])
GO
/****** Object:  StoredProcedure [dbo].[AddCustomer]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[AddCustomer]
@CustomerFirstName varchar(128),
@CustomerSurname varchar(128),
@Gender varchar(10),
@CustomerPostCode varchar(8),
@CustomerAddress varchar(128),
@CustomerEmail varchar(128),
@CustomerTelephone varchar(15),
@CustomerDateOfBirth date

as begin
declare @NewCustomerID INT

insert into [dbo].[Customer]([CustomerFirstName],[CustomerSurname],[Gender],[CustomerPostCode],[CustomerAddress],[CustomerEmail],[CustomerTelephone],[CustomerDateOfBirth])
values(@CustomerFirstName,@CustomerSurname,@Gender,@CustomerPostCode,@CustomerAddress,@CustomerEmail,@CustomerTelephone,@CustomerDateOfBirth)

set @NewCustomerID = @@IDENTITY
end










GO
/****** Object:  StoredProcedure [dbo].[AddStaff]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddStaff]
@forename varchar(128),
@surname varchar(128),
@roleID int,
@venueID int
as
declare @NewStaffId INT
begin
INSERT INTO [dbo].[Staff](StaffFirstName,StaffSecondName,staffRole,VenueID)
VALUES(@forename,@surname,@roleID,@venueID)
SET @NewStaffId = @@IDENTITY
end

GO
/****** Object:  StoredProcedure [dbo].[AssignStaff]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[AssignStaff]
@AppID INT,
@DayID INT
as
begin
select * from [dbo].[StaffAvailability] 
WHERE @AppID = AppID AND @DayID = DayID
end







GO
/****** Object:  StoredProcedure [dbo].[AvailableSession]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[AvailableSession]
@StaffID int,
@DayID int
as
begin
select[StaffAvailability].[AppID],
[AppSlots].*
FROM StaffAvailability
JOIN AppSlots on StaffAvailability.AppID = AppSlots.AppSlotID
WHERE StaffID = @StaffID AND DayID = @DayID
end








GO
/****** Object:  StoredProcedure [dbo].[AvailableStaff]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[AvailableStaff]
@StaffID int,
@AppDate date
as
begin
select * from Appointments where StaffID = @StaffID AND AppointmentDate = @AppDate
end








GO
/****** Object:  StoredProcedure [dbo].[BookAppointment]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[BookAppointment]
@CustomerID INT,
@StaffID INT,
@VenueID INT,
@AppSlotId INT,
@AppointmentDate DATE
as
begin
declare @NewAppointmentID INT
insert into [dbo].[Appointments]([CustomerID],[StaffID],[VenueID],[AppSlotID],[AppointmentDate],[DateBooking])
values (@CustomerID,@StaffID,@VenueID,@AppSlotId,@AppointmentDate,GETDATE())
set @NewAppointmentID = @@IDENTITY
end








GO
/****** Object:  StoredProcedure [dbo].[BookingConfirmed]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[BookingConfirmed]
@BookingID int
as
begin
update WeddingBooking
set BookingConfirmed = 'Y' where BookingID = @BookingID
end





GO
/****** Object:  StoredProcedure [dbo].[ChangeAppointmentDate]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ChangeAppointmentDate]
@AppointmentID int,
@AppointmentDate DATE,
@AppSlotID INT
as
begin
UPDATE [dbo].[Appointments] SET
AppointmentDate = @AppointmentDate,
AppSlotID = @AppSlotID
WHERE AppointmentID = @AppointmentID
end


GO
/****** Object:  StoredProcedure [dbo].[CheckCustomerAppointment]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CheckCustomerAppointment]
@CustomerID int
as 
begin
select [dbo].[Appointments].[CustomerID] FROM [dbo].[Appointments] WHERE @CustomerID = CustomerID AND AppointmentDate > GETDATE()
end







GO
/****** Object:  StoredProcedure [dbo].[CheckCustomerWedding]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[CheckCustomerWedding]
@CustomerID int
as 
begin
select [CustomerID] from [dbo].[Wedding] where @CustomerID = CustomerID

end



GO
/****** Object:  StoredProcedure [dbo].[CheckWeddings]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CheckWeddings]
@dateOfWedding date
as
begin
select DateOfWedding from Wedding where DateOfWedding = @dateOfWedding
end







GO
/****** Object:  StoredProcedure [dbo].[DeleteAppointment]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteAppointment]
@AppointmentID int
as 
delete from [dbo].[Appointments] where @AppointmentID = AppointmentID







GO
/****** Object:  StoredProcedure [dbo].[DeleteWedding]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DeleteWedding]
@WeddingID int
as
delete from [dbo].[WeddingBooking] WHERE @WeddingID = WeddingID  
delete from [dbo].[Wedding] where @WeddingID = WeddingID 








GO
/****** Object:  StoredProcedure [dbo].[GetAppAppID]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAppAppID]
@AppointmentID int
as
begin
select
[dbo].[Appointments].[AppointmentID],
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname],
[dbo].[Staff].[StaffFirstName],
[dbo].[Staff].[StaffSecondName],
[dbo].[Venue].[VenueID],
[dbo].[Venue].[VenueName],
[dbo].[AppSlots].[AppSlotID] ,
[dbo].[AppSlots].[TimeSlot],
[dbo].[Appointments].[AppointmentDate]

from [Customer]
JOIN [Appointments] ON [Customer].[CustomerID] = [Appointments].[CustomerID]
JOIN [Staff] on [Appointments].[StaffID] = [Staff].[staffID]
JOIN [Venue] ON [Appointments].[VenueID] = [Venue].[VenueID]
JOIN [AppSlots] ON [Appointments].[AppSlotID] = [AppSlots].[AppSlotID]
WHERE [dbo].[Appointments].[AppointmentID] = @AppointmentID
end





GO
/****** Object:  StoredProcedure [dbo].[GetAppDate]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAppDate]
@AppointmentDate date
as
begin
select
[dbo].[Appointments].[AppointmentID],
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname],
[dbo].[Staff].[StaffFirstName],
[dbo].[Staff].[StaffSecondName],
[dbo].[Venue].[VenueName],
[dbo].[AppSlots].[AppSlotID] ,
[dbo].[AppSlots].[TimeSlot],
[dbo].[Appointments].[AppointmentDate]

from [Customer]
JOIN [Appointments] ON [Customer].[CustomerID] = [Appointments].[CustomerID]
JOIN [Staff] on [Appointments].[StaffID] = [Staff].[staffID]
JOIN [Venue] ON [Appointments].[VenueID] = [Venue].[VenueID]
JOIN [AppSlots] ON [Appointments].[AppSlotID] = [AppSlots].[AppSlotID]
WHERE [dbo].[Appointments].[AppointmentDate] = @AppointmentDate
end





GO
/****** Object:  StoredProcedure [dbo].[GetAppName]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAppName]
@name varchar(128)
as
begin
select
[dbo].[Appointments].[AppointmentID],
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname],
[dbo].[Staff].[StaffFirstName],
[dbo].[Staff].[StaffSecondName],
[dbo].[Venue].[VenueName],
[dbo].[AppSlots].[AppSlotID] ,
[dbo].[AppSlots].[TimeSlot],
[dbo].[Appointments].[AppointmentDate]

from [Customer]
JOIN [Appointments] ON [Customer].[CustomerID] = [Appointments].[CustomerID]
JOIN [Staff] on [Appointments].[StaffID] = [Staff].[staffID]
JOIN [Venue] ON [Appointments].[VenueID] = [Venue].[VenueID]
JOIN [AppSlots] ON [Appointments].[AppSlotID] = [AppSlots].[AppSlotID]
where @name like CustomerFirstName OR @name like CustomerSurname OR @name like CustomerFirstName + CustomerSurname
end



GO
/****** Object:  StoredProcedure [dbo].[GetAppointments]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAppointments]
as
begin
select
[dbo].[Appointments].[AppointmentID],
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname],
[dbo].[Staff].[StaffFirstName],
[dbo].[Staff].[StaffSecondName],
[dbo].[Venue].[VenueName],
[dbo].[AppSlots].[AppSlotID] ,
[dbo].[AppSlots].[TimeSlot],
[dbo].[Appointments].[AppointmentDate]

from [Customer]
JOIN [Appointments] ON [Customer].[CustomerID] = [Appointments].[CustomerID]
JOIN [Staff] on [Appointments].[StaffID] = [Staff].[staffID]
JOIN [Venue] ON [Appointments].[VenueID] = [Venue].[VenueID]
JOIN [AppSlots] ON [Appointments].[AppSlotID] = [AppSlots].[AppSlotID]

end








GO
/****** Object:  StoredProcedure [dbo].[GetAppStaff]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAppStaff]
@StaffID int
as
begin
select
[dbo].[Appointments].[AppointmentID],
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname],
[dbo].[Staff].[StaffFirstName],
[dbo].[Staff].[StaffSecondName],
[dbo].[Venue].[VenueName],
[dbo].[AppSlots].[AppSlotID] ,
[dbo].[AppSlots].[TimeSlot],
[dbo].[Appointments].[AppointmentDate]

from [Customer]
JOIN [Appointments] ON [Customer].[CustomerID] = [Appointments].[CustomerID]
JOIN [Staff] on [Appointments].[StaffID] = [Staff].[staffID]
JOIN [Venue] ON [Appointments].[VenueID] = [Venue].[VenueID]
JOIN [AppSlots] ON [Appointments].[AppSlotID] = [AppSlots].[AppSlotID]
WHERE [dbo].[Appointments].[StaffID] = @StaffID
end





GO
/****** Object:  StoredProcedure [dbo].[GetAppVenue]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAppVenue]
@VenueID int
as
begin
select
[dbo].[Appointments].[AppointmentID],
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname],
[dbo].[Staff].[StaffFirstName],
[dbo].[Staff].[StaffSecondName],
[dbo].[Venue].[VenueName],
[dbo].[AppSlots].[AppSlotID] ,
[dbo].[AppSlots].[TimeSlot],
[dbo].[Appointments].[AppointmentDate]

from [Customer]
JOIN [Appointments] ON [Customer].[CustomerID] = [Appointments].[CustomerID]
JOIN [Staff] on [Appointments].[StaffID] = [Staff].[staffID]
JOIN [Venue] ON [Appointments].[VenueID] = [Venue].[VenueID]
JOIN [AppSlots] ON [Appointments].[AppSlotID] = [AppSlots].[AppSlotID]
WHERE [dbo].[Appointments].[VenueID] = @VenueID
end





GO
/****** Object:  StoredProcedure [dbo].[GetCoordinators]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetCoordinators]
@venueID int
as
begin
select staffID from Staff where VenueID = @venueID AND staffRole = 2
end
	





GO
/****** Object:  StoredProcedure [dbo].[GetCustomer]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetCustomer]
AS
BEGIN
SELECT * FROM [Customer]

END









GO
/****** Object:  StoredProcedure [dbo].[GetMenus]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetMenus]

as
begin
SELECT * FROM WeddingMenus
end







GO
/****** Object:  StoredProcedure [dbo].[GetPastAppointmentCustomer]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetPastAppointmentCustomer]

as
begin
select 
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname], 
[dbo].[Customer].[CustomerID],
[dbo].[Appointments].[AppointmentDate]

from [Customer]
JOIN [Appointments] ON [Customer].[CustomerID] = [Appointments].[CustomerID]
where [AppointmentDate]  <= GETDATE()



end 


GO
/****** Object:  StoredProcedure [dbo].[GetStaff]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetStaff]
as
begin
SELECT
[Staff].[staffID],
[Staff].[StaffFirstName],
[Staff].[StaffSecondName],
[StaffRole].[Role],
[Venue].[VenueName],
[Venue].[VenueAddress],
[Venue].[VenueTelephone]
FROM [Staff]
JOIN [Venue] on [Venue].[VenueID] = [Staff].[VenueID]
JOIN [StaffRole] on [Staff].[staffRole] = [staffRole].[RoleID]

END

GO
/****** Object:  StoredProcedure [dbo].[GetStaffSessions]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetStaffSessions]
@StaffID int
as
begin
SELECT
[StaffAvailability].[AppID],
[AppSlots].[TimeSlot],
[StaffAvailability].[DayID],
[DayTable].[Day]
FROM[StaffAvailability]
JOIN [AppSlots] on [StaffAvailability].[AppID] = [AppSlots].[AppSlotID]
JOIN [DayTable] ON [StaffAvailability].[DayID] = [DayTable].[DayID]
WHERE [StaffAvailability].[StaffID] = @StaffID
end

GO
/****** Object:  StoredProcedure [dbo].[GetWeddingBookings]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetWeddingBookings]
as
begin
select
[dbo].[WeddingBooking].[BookingID],
[dbo].[WeddingBooking].[WeddingID],
[dbo].[WeddingBooking].[StaffID],
[dbo].[Staff].[StaffFirstName],
[dbo].[Staff].[StaffSecondName],
[dbo].[WeddingBooking].[DateOfBooking],
[dbo].[WeddingBooking].[DateOfWedding],
[dbo].[WeddingBooking].[OverallCost],
[dbo].[WeddingBooking].[DepositCost],
[dbo].[WeddingBooking].[BookingConfirmed]

from [Staff]
JOIN [WeddingBooking] on [Staff].[staffID] = [WeddingBooking].[StaffID]
end





GO
/****** Object:  StoredProcedure [dbo].[GetWeddingDetails]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetWeddingDetails]
@WeddingID int
as
begin
select
[dbo].[Wedding].[CustomerID],
[dbo].[Customer].[CustomerFirstName],
[dbo].[Customer].[CustomerSurname],
[dbo].[Wedding].[EntertainmentID],
[dbo].[WeddingEntertainment].[Type],
[dbo].[Wedding].[Menus],
[dbo].[WeddingMenus].[NoOfCourses],
[dbo].[WeddingMenus].[Provider],
[dbo].[Wedding].[VenueID],
[dbo].[Venue].[VenueName],
[dbo].[Venue].[VenueAddress],
[dbo].[Venue].[VenueTelephone],
[dbo].[Wedding].[DateOfWedding],
[dbo].[Wedding].[NumberOfGuests],
[dbo].[Wedding].[Flowers],
[dbo].[Wedding].[Invitations],
[dbo].[Wedding].[Suits],
[dbo].[Wedding].[TravelArrangements],
[dbo].[Wedding].[Dress],
[dbo].[WeddingBooking].[BookingID],
[dbo].[WeddingBooking].[WeddingID],
[dbo].[WeddingBooking].[DateOfBooking],
[dbo].[WeddingBooking].[DateOfWedding],
[dbo].[WeddingBooking].[OverallCost],
[dbo].[WeddingBooking].[DepositCost],
[dbo].[WeddingBooking].[BookingConfirmed]
from [Customer]
JOIN [Wedding] on [Customer].[CustomerID] = [Wedding].[CustomerID]
JOIN [WeddingBooking] on [Wedding].[WeddingID] = [WeddingBooking].[WeddingID]

JOIN [WeddingEntertainment] on [Wedding].[EntertainmentID] = [WeddingEntertainment].[WeddingEntertainmentID]
JOIN [WeddingMenus] on [Wedding].[Menus] = [WeddingMenus].[MenuID]
JOIN [Venue] on [Wedding].[VenueID] = [Venue].[VenueID]

WHERE Wedding.WeddingID = @WeddingID

end



GO
/****** Object:  StoredProcedure [dbo].[MakeBooking]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[MakeBooking]
@CustomerID INT,
@VenueID INT,
@StaffID INT,
@AppointmentDate date,
@AppSlotID INT
as 
begin

INSERT INTO [dbo].[Appointments]([CustomerID],[StaffID],[VenueID],[AppSlotID],[AppointmentDate],[DateBooking])
VALUES(@CustomerID,@StaffID,@VenueID,@AppSlotID,@AppointmentDate,GETDATE())

END








GO
/****** Object:  StoredProcedure [dbo].[MakeWeddingBooking]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MakeWeddingBooking]
@CustomerID INT,
@VenueID INT,
@EntertainmentID INT,
@MenuID INT,
@Invitations char(1),
@Flowers char(1),
@Dress char(1),
@Suits char(1),
@WeddingCars char(1),
@TravelArrangements char(1),
@NumGuests int,
@StaffID int,
@DateOfWedding date,
@OverallCost decimal,
@DepositCost decimal,
@BookingConfirmed char(1)
as 
begin
declare @NewWeddingID INT
declare @NewBookingID INT

INSERT INTO [dbo].[Wedding](
CustomerID,VenueID,EntertainmentID,Menus,Invitations,Flowers,Dress,Suits,WeddingCars,TravelArrangements,NumberOfGuests,DateOfWedding)
VALUES (@CustomerID,@VenueID,@EntertainmentID,@MenuID,@Invitations,@Flowers,@Dress,@Suits,@WeddingCars,@TravelArrangements,@NumGuests,@DateOfWedding)
SET @NewWeddingID = @@IDENTITY
INSERT INTO [dbo].[WeddingBooking](
WeddingID,StaffID,DateOfBooking,DateOfWedding,OverallCost,DepositCost,BookingConfirmed)
VALUES(@NewWeddingID,@StaffID,GETDATE(),@DateOfWedding,@OverallCost,@DepositCost,@BookingConfirmed)
SET @NewBookingID = @@IDENTITY

end








GO
/****** Object:  StoredProcedure [dbo].[NewAvailability]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[NewAvailability]
@StaffID int,
@AppSlot int,
@DayId int
as
begin
INSERT INTO [dbo].[StaffAvailability](StaffID,AppID,DayID)
values(@StaffID,@AppSlot,@DayId)
end

GO
/****** Object:  StoredProcedure [dbo].[SelectStaff]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectStaff]
@VenueID int,
@StaffRole int
as
begin
select * from Staff where VenueID = @VenueID and staffRole = @StaffRole
end








GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 30/01/2018 23:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UpdateCustomer]
(
@CustomerID INT,
@CustomerFirstName VARCHAR(128),
@CustomerSurname VARCHAR(128),
@CustomerDateOfBirth DATE,
@CustomerAddress VARCHAR(128),
@CustomerPostCode VARCHAR(9),
@CustomerTelephone VARCHAR(15),
@CustomerEmail VARCHAR (128)
)
AS 
BEGIN

UPDATE [dbo].[Customer] SET
CustomerFirstName = @CustomerFirstName,
CustomerSurname = @CustomerSurname,
CustomerDateOfBirth = @CustomerDateOfBirth,
CustomerAddress = @CustomerAddress,
CustomerPostCode = @CustomerPostCode,
CustomerTelephone = @CustomerTelephone,
CustomerEmail = @CustomerEmail
WHERE CustomerID = @CustomerID
END









GO
USE [master]
GO
ALTER DATABASE [AdairRA2EventsUnlimited] SET  READ_WRITE 
GO
