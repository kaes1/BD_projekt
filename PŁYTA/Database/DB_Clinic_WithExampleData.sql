USE [master]
GO
/****** Object:  Database [Clinic]    Script Date: 12.05.2019 01:58:11 ******/
CREATE DATABASE [Clinic]
 CONTAINMENT = NONE
 /******ON  PRIMARY 
( NAME = N'Clinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\Clinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\Clinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
******/
GO
ALTER DATABASE [Clinic] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Clinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clinic] SET RECOVERY FULL 
GO
ALTER DATABASE [Clinic] SET  MULTI_USER 
GO
ALTER DATABASE [Clinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clinic] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Clinic', N'ON'
GO
ALTER DATABASE [Clinic] SET QUERY_STORE = OFF
GO
USE [Clinic]
GO
/****** Object:  Schema [ClinicApp]    Script Date: 12.05.2019 01:58:11 ******/
CREATE SCHEMA [ClinicApp]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[ReceptionistID] [int] NOT NULL,
	[Description] [varchar](1024) NOT NULL,
	[Diagnosis] [varchar](1024) NULL,
	[Status] [varchar](4) NOT NULL,
	[DateRegistered] [datetime] NOT NULL,
	[DateOfAppointment] [datetime] NOT NULL,
	[DateCompletedOrCanceled] [datetime] NULL,
 CONSTRAINT [PK_APPOINTMENT] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[PWZNumber] [int] NOT NULL,
 CONSTRAINT [PK_DOCTOR] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExaminationDictionary]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExaminationDictionary](
	[Code] [varchar](10) NOT NULL,
	[Type] [char](1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_EXAMINATION_LOOKUP_TABLE] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabExamination]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabExamination](
	[LabExaminationID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[AppointmentID] [int] NOT NULL,
	[LabTechnicianID] [int] NULL,
	[LabManagerID] [int] NULL,
	[DateRegistered] [datetime] NOT NULL,
	[Result] [varchar](1024) NULL,
	[DoctorComments] [varchar](1024) NULL,
	[DateCompletedOrCanceled] [datetime] NULL,
	[LabManagerComments] [varchar](1024) NULL,
	[DateApprovedOrCanceled] [datetime] NULL,
	[Status] [varchar](6) NOT NULL,
 CONSTRAINT [PK_LAB_EXAMINATION] PRIMARY KEY CLUSTERED 
(
	[LabExaminationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabManager]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabManager](
	[LabManagerID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LAB_MANAGER] PRIMARY KEY CLUSTERED 
(
	[LabManagerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTechnician]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTechnician](
	[LabTechnicianID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LAB_ASSISTANT] PRIMARY KEY CLUSTERED 
(
	[LabTechnicianID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[PESEL] [varchar](12) NOT NULL,
 CONSTRAINT [PK_PATIENT] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhysicalExamination]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhysicalExamination](
	[PhysicalExaminationID] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentID] [int] NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[Result] [varchar](1024) NOT NULL,
 CONSTRAINT [PK_PHYSICAL_EXAMINATION] PRIMARY KEY CLUSTERED 
(
	[PhysicalExaminationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receptionist]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receptionist](
	[ReceptionistID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ADMISSION_CLERK] PRIMARY KEY CLUSTERED 
(
	[ReceptionistID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12.05.2019 01:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[Hashcode] [varchar](64) NULL,
	[Role] [varchar](4) NOT NULL,
	[DateRetired] [datetime] NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointment] ON 

INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (47, 1, 10, 1, N'', NULL, N'CANC', CAST(N'2019-05-12T01:00:27.870' AS DateTime), CAST(N'2019-05-12T07:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (48, 1, 11, 1, N'Stiff shoulders, nervous behaviour. Nothing major.', N'A minor cold.', N'COMP', CAST(N'2019-05-12T01:00:33.237' AS DateTime), CAST(N'2019-05-12T07:30:00.000' AS DateTime), CAST(N'2019-05-12T01:30:40.853' AS DateTime))
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (49, 1, 4, 1, N'Nothing special. Ordered MB and PT.', NULL, N'COMP', CAST(N'2019-05-12T01:00:38.277' AS DateTime), CAST(N'2019-05-12T08:00:00.000' AS DateTime), CAST(N'2019-05-12T01:33:17.900' AS DateTime))
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (50, 1, 4, 1, N'', NULL, N'CANC', CAST(N'2019-05-12T01:00:42.953' AS DateTime), CAST(N'2019-05-17T17:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (51, 1, 4, 1, N'', NULL, N'REG', CAST(N'2019-05-12T01:00:49.703' AS DateTime), CAST(N'2019-05-31T17:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (52, 1, 4, 1, N'', NULL, N'REG', CAST(N'2019-05-12T01:00:58.533' AS DateTime), CAST(N'2019-06-20T15:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (53, 1, 8, 1, N'', NULL, N'CANC', CAST(N'2019-05-12T01:01:04.850' AS DateTime), CAST(N'2019-05-12T17:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (54, 1, 9, 1, N'', NULL, N'REG', CAST(N'2019-05-12T01:01:08.763' AS DateTime), CAST(N'2019-05-12T17:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (55, 1, 8, 1, N'', NULL, N'CANC', CAST(N'2019-05-12T01:01:44.870' AS DateTime), CAST(N'2019-05-12T17:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (56, 1, 8, 1, N'', NULL, N'REG', CAST(N'2019-05-12T01:01:53.417' AS DateTime), CAST(N'2019-05-12T18:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (57, 1, 10, 1, N'Head trauma.', N'Concussion.', N'COMP', CAST(N'2019-05-12T01:03:39.853' AS DateTime), CAST(N'2019-05-12T16:30:00.000' AS DateTime), CAST(N'2019-05-12T01:33:34.477' AS DateTime))
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (58, 1, 10, 1, N'', NULL, N'REG', CAST(N'2019-05-12T01:03:41.797' AS DateTime), CAST(N'2019-05-12T17:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (59, 1, 10, 1, N'', NULL, N'CANC', CAST(N'2019-05-12T01:13:56.917' AS DateTime), CAST(N'2019-05-12T07:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (60, 1, 10, 1, N'Patient fainted and had to be taken to ER.', NULL, N'CANC', CAST(N'2019-05-12T01:14:01.667' AS DateTime), CAST(N'2019-05-12T07:00:00.000' AS DateTime), CAST(N'2019-05-12T01:28:43.740' AS DateTime))
SET IDENTITY_INSERT [dbo].[Appointment] OFF
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([DoctorID], [UserID], [FirstName], [LastName], [PWZNumber]) VALUES (1, 1, N'Karin', N'Chakwas', 5425740)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'A1C', N'L', N'Hemoglobin')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'C', N'L', N'Cultures')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'CBC', N'L', N'Complete Blood Count')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'MP.1', N'L', N'Basic Metabolic Panel')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'MP.2', N'L', N'Comprehensive Metabolic Panel')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'Pa.Lip', N'L', N'Lipid Panel')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'Pa.Liv', N'L', N'Liver Panel')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'PE.01', N'P', N'Inspection')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'PE.02', N'P', N'Palpation')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'PE.03', N'P', N'Percussion')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'PE.04', N'P', N'Auscultation')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'PE.05', N'P', N'Neurologic')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'PE.06', N'P', N'Temperature')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'PT', N'L', N'Prothrombin Time')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'URI', N'L', N'Urianalysis')
SET IDENTITY_INSERT [dbo].[LabExamination] ON 

INSERT [dbo].[LabExamination] ([LabExaminationID], [Code], [AppointmentID], [LabTechnicianID], [LabManagerID], [DateRegistered], [Result], [DoctorComments], [DateCompletedOrCanceled], [LabManagerComments], [DateApprovedOrCanceled], [Status]) VALUES (9, N'Pa.Lip', 60, 1, NULL, CAST(N'2019-05-12T01:26:45.873' AS DateTime), N'Not enough cells.', N'Repress cells.', CAST(N'2019-05-12T01:32:04.490' AS DateTime), NULL, NULL, N'CANC_T')
INSERT [dbo].[LabExamination] ([LabExaminationID], [Code], [AppointmentID], [LabTechnicianID], [LabManagerID], [DateRegistered], [Result], [DoctorComments], [DateCompletedOrCanceled], [LabManagerComments], [DateApprovedOrCanceled], [Status]) VALUES (10, N'Pa.Liv', 60, 1, 1, CAST(N'2019-05-12T01:26:52.080' AS DateTime), N'Dc0245. Images saved.', N'', CAST(N'2019-05-12T01:31:53.277' AS DateTime), N'', CAST(N'2019-05-12T01:32:20.387' AS DateTime), N'APP')
INSERT [dbo].[LabExamination] ([LabExaminationID], [Code], [AppointmentID], [LabTechnicianID], [LabManagerID], [DateRegistered], [Result], [DoctorComments], [DateCompletedOrCanceled], [LabManagerComments], [DateApprovedOrCanceled], [Status]) VALUES (11, N'MP.1', 49, 1, 1, CAST(N'2019-05-12T01:32:57.913' AS DateTime), N'BM and PM average 266.6.', N'', CAST(N'2019-05-12T01:34:03.550' AS DateTime), N'Irregular result.', CAST(N'2019-05-12T01:34:42.827' AS DateTime), N'CANC_M')
INSERT [dbo].[LabExamination] ([LabExaminationID], [Code], [AppointmentID], [LabTechnicianID], [LabManagerID], [DateRegistered], [Result], [DoctorComments], [DateCompletedOrCanceled], [LabManagerComments], [DateApprovedOrCanceled], [Status]) VALUES (12, N'PT', 49, 1, 1, CAST(N'2019-05-12T01:33:03.293' AS DateTime), N'PT normal.', N'', CAST(N'2019-05-12T01:33:48.770' AS DateTime), N'All normal.', CAST(N'2019-05-12T01:35:02.197' AS DateTime), N'APP')
SET IDENTITY_INSERT [dbo].[LabExamination] OFF
SET IDENTITY_INSERT [dbo].[LabManager] ON 

INSERT [dbo].[LabManager] ([LabManagerID], [UserID], [FirstName], [LastName]) VALUES (1, 4, N'Mordin', N'Solus')
SET IDENTITY_INSERT [dbo].[LabManager] OFF
SET IDENTITY_INSERT [dbo].[LabTechnician] ON 

INSERT [dbo].[LabTechnician] ([LabTechnicianID], [UserID], [FirstName], [LastName]) VALUES (1, 3, N'Jeff', N'Moreau')
SET IDENTITY_INSERT [dbo].[LabTechnician] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (1, N'Adam', N'Kowalski', N'97110200817')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (2, N'Piotr', N'Silny', N'95030300815')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (4, N'Przemysław', N'Testowy', N'12345678903')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (5, N'Elżbieta', N'Testowa', N'12345678910')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (6, N'Wanda', N'Kapeć', N'68109898227')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (7, N'Anna', N'Widelec', N'58585858589')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (8, N'Adam', N'Nowak', N'97110200824')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (9, N'Piotr', N'Nowakow', N'97110200831')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (10, N'Mike', N'Zygzak', N'97110200848')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (11, N'Marc', N'Zygzak', N'97110200855')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [PESEL]) VALUES (12, N'Jakub', N'Turewiczow', N'97110200862')
SET IDENTITY_INSERT [dbo].[Patient] OFF
SET IDENTITY_INSERT [dbo].[PhysicalExamination] ON 

INSERT [dbo].[PhysicalExamination] ([PhysicalExaminationID], [AppointmentID], [Code], [Result]) VALUES (3, 60, N'PE.06', N'38.5')
INSERT [dbo].[PhysicalExamination] ([PhysicalExaminationID], [AppointmentID], [Code], [Result]) VALUES (4, 48, N'PE.06', N'37.9')
INSERT [dbo].[PhysicalExamination] ([PhysicalExaminationID], [AppointmentID], [Code], [Result]) VALUES (5, 48, N'PE.01', N'Overworked Joints.')
SET IDENTITY_INSERT [dbo].[PhysicalExamination] OFF
SET IDENTITY_INSERT [dbo].[Receptionist] ON 

INSERT [dbo].[Receptionist] ([ReceptionistID], [UserID], [FirstName], [LastName]) VALUES (1, 2, N'Kelly', N'Chambers')
SET IDENTITY_INSERT [dbo].[Receptionist] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (1, N'doctor', N'72f4be89d6ebab1496e21e38bcd7c8ca0a68928af3081ad7dff87e772eb350c2', N'DOC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (2, N'receptionist', N'abbce88bd1788accc2ec66a738003efbe2342dea1c3e60c1459583289cbb3fed', N'REC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (3, N'labtechnician', N'b99d85aaa979a25ba56b3a6c0ef18eabc9761b8799766ebb8cd9736fda5bdcf0', N'TEC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (4, N'labmanager', N'c562f4bdb567574c2033a4e53c059cae23edf946d1ff3c7d4b07eeb4f5f2e974', N'MAN', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (5, N'admin', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'ADM', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctor] ([DoctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Receptionist] FOREIGN KEY([ReceptionistID])
REFERENCES [dbo].[Receptionist] ([ReceptionistID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Receptionist]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_User]
GO
ALTER TABLE [dbo].[LabExamination]  WITH CHECK ADD  CONSTRAINT [FK_LabTest_Appointment] FOREIGN KEY([AppointmentID])
REFERENCES [dbo].[Appointment] ([AppointmentID])
GO
ALTER TABLE [dbo].[LabExamination] CHECK CONSTRAINT [FK_LabTest_Appointment]
GO
ALTER TABLE [dbo].[LabExamination]  WITH CHECK ADD  CONSTRAINT [FK_LabTest_LabManager] FOREIGN KEY([LabManagerID])
REFERENCES [dbo].[LabManager] ([LabManagerID])
GO
ALTER TABLE [dbo].[LabExamination] CHECK CONSTRAINT [FK_LabTest_LabManager]
GO
ALTER TABLE [dbo].[LabExamination]  WITH CHECK ADD  CONSTRAINT [FK_LabTest_LabTechnician] FOREIGN KEY([LabTechnicianID])
REFERENCES [dbo].[LabTechnician] ([LabTechnicianID])
GO
ALTER TABLE [dbo].[LabExamination] CHECK CONSTRAINT [FK_LabTest_LabTechnician]
GO
ALTER TABLE [dbo].[LabExamination]  WITH CHECK ADD  CONSTRAINT [FK_LabTest_Procedure] FOREIGN KEY([Code])
REFERENCES [dbo].[ExaminationDictionary] ([Code])
GO
ALTER TABLE [dbo].[LabExamination] CHECK CONSTRAINT [FK_LabTest_Procedure]
GO
ALTER TABLE [dbo].[LabManager]  WITH CHECK ADD  CONSTRAINT [FK_LabManager_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[LabManager] CHECK CONSTRAINT [FK_LabManager_User]
GO
ALTER TABLE [dbo].[LabTechnician]  WITH CHECK ADD  CONSTRAINT [FK_LabTechnician_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[LabTechnician] CHECK CONSTRAINT [FK_LabTechnician_User]
GO
ALTER TABLE [dbo].[PhysicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_PhysicalExamination_Appointment] FOREIGN KEY([AppointmentID])
REFERENCES [dbo].[Appointment] ([AppointmentID])
GO
ALTER TABLE [dbo].[PhysicalExamination] CHECK CONSTRAINT [FK_PhysicalExamination_Appointment]
GO
ALTER TABLE [dbo].[PhysicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_PhysicalExamination_Procedure] FOREIGN KEY([Code])
REFERENCES [dbo].[ExaminationDictionary] ([Code])
GO
ALTER TABLE [dbo].[PhysicalExamination] CHECK CONSTRAINT [FK_PhysicalExamination_Procedure]
GO
ALTER TABLE [dbo].[Receptionist]  WITH CHECK ADD  CONSTRAINT [FK_Receptionist_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Receptionist] CHECK CONSTRAINT [FK_Receptionist_User]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [CHK_Appointment_Status] CHECK  (([Status]='REG' OR [Status]='CANC' OR [Status]='COMP' OR [Status]='BEG'))
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [CHK_Appointment_Status]
GO
ALTER TABLE [dbo].[ExaminationDictionary]  WITH CHECK ADD  CONSTRAINT [CHK_ExaminationDictionary_Type] CHECK  (([Type]='P' OR [Type]='L'))
GO
ALTER TABLE [dbo].[ExaminationDictionary] CHECK CONSTRAINT [CHK_ExaminationDictionary_Type]
GO
ALTER TABLE [dbo].[LabExamination]  WITH CHECK ADD  CONSTRAINT [CHK_LabExamination_Status] CHECK  (([Status]='REG' OR [Status]='CANC_T' OR [Status]='CANC_M' OR [Status]='COMP' OR [Status]='BEG' OR [Status]='APP'))
GO
ALTER TABLE [dbo].[LabExamination] CHECK CONSTRAINT [CHK_LabExamination_Status]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [CHK_User_Role] CHECK  (([Role]='REC' OR [Role]='DOC' OR [Role]='TEC' OR [Role]='MAN' OR [Role]='ADM'))
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [CHK_User_Role]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Słownik Badań' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ExaminationDictionary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Badanie Laboratoryjne' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LabExamination'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Kierownik Laboratorium' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LabManager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Laborant' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LabTechnician'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pacjent' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Badanie fizyczne' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhysicalExamination'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Rejestratorka' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Receptionist'
GO
USE [master]
GO
ALTER DATABASE [Clinic] SET  READ_WRITE 
GO
