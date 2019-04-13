USE [master]
GO
/****** Object:  Database [Clinic]    Script Date: 14.04.2019 00:37:01 ******/
CREATE DATABASE [Clinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\Clinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\Clinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Schema [ClinicApp]    Script Date: 14.04.2019 00:37:01 ******/
CREATE SCHEMA [ClinicApp]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[Doctor]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[ExaminationDictionary]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[LabExamination]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[LabManager]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[LabTechnician]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[PhysicalExamination]    Script Date: 14.04.2019 00:37:01 ******/
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
/****** Object:  Table [dbo].[Receptionist]    Script Date: 14.04.2019 00:37:02 ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 14.04.2019 00:37:02 ******/
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

INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (1, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T02:07:31.187' AS DateTime), CAST(N'2019-04-25T12:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (2, 1, 8, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-08T02:07:48.897' AS DateTime), CAST(N'2019-04-27T15:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (3, 2, 8, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-08T20:24:55.703' AS DateTime), CAST(N'2019-05-01T12:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (4, 1, 8, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-08T20:32:54.297' AS DateTime), CAST(N'2019-05-01T12:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (5, 2, 8, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-08T20:32:56.433' AS DateTime), CAST(N'2019-05-01T12:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (6, 2, 8, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-08T20:33:35.663' AS DateTime), CAST(N'2019-05-01T12:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (7, 1, 2, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T20:37:02.373' AS DateTime), CAST(N'2019-05-01T12:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (8, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T22:48:58.787' AS DateTime), CAST(N'2019-04-17T14:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (9, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:09:52.113' AS DateTime), CAST(N'2019-04-26T19:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (10, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:10:09.877' AS DateTime), CAST(N'2019-04-26T18:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (11, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:11:42.963' AS DateTime), CAST(N'2019-04-21T11:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (12, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:12:45.610' AS DateTime), CAST(N'2019-05-02T17:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (13, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:14:36.413' AS DateTime), CAST(N'2019-06-01T17:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (14, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:16:36.767' AS DateTime), CAST(N'2019-04-25T14:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (15, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:17:20.420' AS DateTime), CAST(N'2019-04-25T14:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (16, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:17:45.073' AS DateTime), CAST(N'2019-04-25T15:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (17, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:19:28.240' AS DateTime), CAST(N'2019-04-25T16:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (18, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:20:38.270' AS DateTime), CAST(N'2019-04-26T12:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (19, 1, 6, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-08T23:22:16.863' AS DateTime), CAST(N'2019-04-27T06:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (20, 1, 2, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-09T00:22:30.007' AS DateTime), CAST(N'2019-04-26T06:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (21, 1, 2, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-09T00:22:34.927' AS DateTime), CAST(N'2019-04-26T06:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (22, 1, 2, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-09T00:22:40.193' AS DateTime), CAST(N'2019-04-26T11:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (23, 1, 2, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-09T00:24:18.903' AS DateTime), CAST(N'2019-04-09T17:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (24, 1, 4, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-09T00:44:52.477' AS DateTime), CAST(N'2019-04-09T15:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (25, 1, 9, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-09T00:45:01.943' AS DateTime), CAST(N'2019-04-09T15:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (26, 1, 9, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-09T00:45:14.190' AS DateTime), CAST(N'2019-04-09T15:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (27, 1, 9, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-09T00:46:29.897' AS DateTime), CAST(N'2019-04-09T15:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (28, 1, 9, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-09T00:46:33.780' AS DateTime), CAST(N'2019-04-09T15:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (29, 1, 5, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-12T11:58:34.327' AS DateTime), CAST(N'2019-04-12T07:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (30, 1, 5, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-12T11:58:38.823' AS DateTime), CAST(N'2019-04-12T07:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (31, 1, 5, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-12T11:58:42.887' AS DateTime), CAST(N'2019-04-12T06:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (32, 1, 4, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-12T12:10:48.167' AS DateTime), CAST(N'2019-04-12T15:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (33, 1, 4, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-12T12:10:50.450' AS DateTime), CAST(N'2019-04-12T15:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (34, 1, 4, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-12T12:10:57.013' AS DateTime), CAST(N'2019-04-12T15:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (35, 1, 5, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-12T12:18:51.300' AS DateTime), CAST(N'2019-04-12T07:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (36, 1, 5, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-12T12:18:56.910' AS DateTime), CAST(N'2019-04-12T11:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (37, 1, 5, 1, N'Standard Appointment.', NULL, N'CANC', CAST(N'2019-04-12T12:19:01.173' AS DateTime), CAST(N'2019-04-12T07:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (38, 1, 7, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-13T02:03:38.857' AS DateTime), CAST(N'2019-04-13T10:30:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (39, 1, 10, 1, N'Standard Appointment.', NULL, N'REG', CAST(N'2019-04-13T02:03:42.920' AS DateTime), CAST(N'2019-04-13T10:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Appointment] ([AppointmentID], [DoctorID], [PatientID], [ReceptionistID], [Description], [Diagnosis], [Status], [DateRegistered], [DateOfAppointment], [DateCompletedOrCanceled]) VALUES (40, 1, 11, 1, N'Test appointment nr 1.', N'Przeziębienie.', N'COMP', CAST(N'2019-04-13T02:03:46.057' AS DateTime), CAST(N'2019-04-13T09:30:00.000' AS DateTime), CAST(N'2019-04-13T02:33:51.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Appointment] OFF
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([DoctorID], [UserID], [FirstName], [LastName], [PWZNumber]) VALUES (1, 1, N'Karin', N'Chakwas', 5425740)
INSERT [dbo].[Doctor] ([DoctorID], [UserID], [FirstName], [LastName], [PWZNumber]) VALUES (2, 7, N'Otto', N'Octavius', 7654321)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'Phys', N'P', N'Routine Physical')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'TEMP.1', N'L', N'Chest X-Ray')
INSERT [dbo].[ExaminationDictionary] ([Code], [Type], [Name]) VALUES (N'TEMP.2', N'L', N'Blood Test')
SET IDENTITY_INSERT [dbo].[LabExamination] ON 

INSERT [dbo].[LabExamination] ([LabExaminationID], [Code], [AppointmentID], [LabTechnicianID], [LabManagerID], [DateRegistered], [Result], [DoctorComments], [DateCompletedOrCanceled], [LabManagerComments], [DateApprovedOrCanceled], [Status]) VALUES (1, N'TEMP.2', 40, NULL, NULL, CAST(N'2019-04-13T02:33:37.187' AS DateTime), N'Hemoglobina: 592.', N'Zwrócić uwagę na hemoglobine!', CAST(N'2019-04-14T00:02:41.240' AS DateTime), NULL, NULL, N'COMP')
INSERT [dbo].[LabExamination] ([LabExaminationID], [Code], [AppointmentID], [LabTechnicianID], [LabManagerID], [DateRegistered], [Result], [DoctorComments], [DateCompletedOrCanceled], [LabManagerComments], [DateApprovedOrCanceled], [Status]) VALUES (2, N'TEMP.1', 40, NULL, NULL, CAST(N'2019-04-13T02:33:47.017' AS DateTime), N'', N'', CAST(N'2019-04-14T00:02:20.457' AS DateTime), NULL, NULL, N'CANC_T')
SET IDENTITY_INSERT [dbo].[LabExamination] OFF
SET IDENTITY_INSERT [dbo].[LabManager] ON 

INSERT [dbo].[LabManager] ([LabManagerID], [UserID], [FirstName], [LastName]) VALUES (1, 4, N'Mordin', N'Solus')
INSERT [dbo].[LabManager] ([LabManagerID], [UserID], [FirstName], [LastName]) VALUES (2, 10, N'Zuzanna', N'Testowa')
SET IDENTITY_INSERT [dbo].[LabManager] OFF
SET IDENTITY_INSERT [dbo].[LabTechnician] ON 

INSERT [dbo].[LabTechnician] ([LabTechnicianID], [UserID], [FirstName], [LastName]) VALUES (1, 3, N'Jeff', N'Moreau')
INSERT [dbo].[LabTechnician] ([LabTechnicianID], [UserID], [FirstName], [LastName]) VALUES (2, 9, N'Adam', N'Testowy')
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
SET IDENTITY_INSERT [dbo].[Receptionist] ON 

INSERT [dbo].[Receptionist] ([ReceptionistID], [UserID], [FirstName], [LastName]) VALUES (1, 2, N'Kelly', N'Chambers')
SET IDENTITY_INSERT [dbo].[Receptionist] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (1, N'doctor', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'DOC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (2, N'receptionist', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'REC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (3, N'labtechnician', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'TEC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (4, N'labmanager', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'MAN', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (5, N'admin', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'ADM', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (6, N'retired', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'REC', CAST(N'2019-06-29T19:02:02.000' AS DateTime))
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (7, N'docock', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'DOC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (8, N'oldadmin', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'ADM', CAST(N'2019-03-05T18:00:00.000' AS DateTime))
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (9, N'testtec', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', N'TEC', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (10, N'testman', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'MAN', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (11, N'testadm', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'ADM', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (12, N'testadm1', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'ADM', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (13, N'testadm2', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'ADM', NULL)
INSERT [dbo].[User] ([UserID], [Username], [Hashcode], [Role], [DateRetired]) VALUES (14, N'testadm3', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', N'ADM', NULL)
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
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [CHK_APPOINTMENT_STATUS] CHECK  (([Status]='REG' OR [Status]='CANC' OR [Status]='COMP' OR [Status]='BEG'))
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [CHK_APPOINTMENT_STATUS]
GO
ALTER TABLE [dbo].[LabExamination]  WITH CHECK ADD  CONSTRAINT [CHK_LABEXAMINATION_STATUS] CHECK  (([Status]='REG' OR [Status]='CANC_T' OR [Status]='CANC_M' OR [Status]='COMP' OR [Status]='BEG' OR [Status]='APP'))
GO
ALTER TABLE [dbo].[LabExamination] CHECK CONSTRAINT [CHK_LABEXAMINATION_STATUS]
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
