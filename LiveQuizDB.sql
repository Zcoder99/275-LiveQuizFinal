USE [master]
GO
/****** Object:  Database [SqlLiveQuizFinal]    Script Date: 4/14/2024 2:27:39 PM ******/
CREATE DATABASE [SqlLiveQuizFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SqlLiveQuizFinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SqlLiveQuizFinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SqlLiveQuizFinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SqlLiveQuizFinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SqlLiveQuizFinal] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SqlLiveQuizFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SqlLiveQuizFinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET RECOVERY FULL 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET  MULTI_USER 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SqlLiveQuizFinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SqlLiveQuizFinal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SqlLiveQuizFinal', N'ON'
GO
ALTER DATABASE [SqlLiveQuizFinal] SET QUERY_STORE = ON
GO
ALTER DATABASE [SqlLiveQuizFinal] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SqlLiveQuizFinal]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/14/2024 2:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnonUsers]    Script Date: 4/14/2024 2:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnonUsers](
	[AnonId] [int] IDENTITY(1,1) NOT NULL,
	[AnonName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AnonUsers] PRIMARY KEY CLUSTERED 
(
	[AnonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 4/14/2024 2:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AnswerText] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[CorrectAnswer] [bit] NOT NULL,
 CONSTRAINT [PK_Answers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 4/14/2024 2:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionText] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[QuizId] [int] NOT NULL,
	[IsMultipleChoice] [bit] NOT NULL,
	[IsTrueFalse] [bit] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quizzes]    Script Date: 4/14/2024 2:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quizzes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuizName] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Quizzes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserQuiz]    Script Date: 4/14/2024 2:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserQuiz](
	[UserQuizId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[QuizId] [int] NOT NULL,
 CONSTRAINT [PK_UserQuiz] PRIMARY KEY CLUSTERED 
(
	[UserQuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/14/2024 2:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Access] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240327153842_init', N'7.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240331175253_addQuizPropertys', N'7.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240408162528_Added correct answer property', N'7.0.16')
GO
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (3, N'test', CAST(N'2024-03-31T14:33:39.7337472' AS DateTime2), 9, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (4, N'Test2', CAST(N'2024-03-31T14:33:47.6809141' AS DateTime2), 9, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (5, N'Test3', CAST(N'2024-03-31T14:33:53.9639802' AS DateTime2), 9, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (6, N'Test4', CAST(N'2024-03-31T14:34:04.1086167' AS DateTime2), 9, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (7, N'a1', CAST(N'2024-03-31T14:39:24.6503963' AS DateTime2), 11, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (8, N'a2', CAST(N'2024-03-31T14:39:33.6575206' AS DateTime2), 11, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (9, N'a3', CAST(N'2024-03-31T14:39:37.6265103' AS DateTime2), 11, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (10, N'q4- a1', CAST(N'2024-03-31T14:40:09.0496606' AS DateTime2), 12, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (11, N'q4- a2', CAST(N'2024-03-31T14:40:14.6023043' AS DateTime2), 12, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (12, N'q4- a3', CAST(N'2024-03-31T14:40:22.5452816' AS DateTime2), 12, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (13, N'green ', CAST(N'2024-04-02T12:28:44.6181453' AS DateTime2), 14, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (14, N'red', CAST(N'2024-04-02T12:28:50.2651585' AS DateTime2), 14, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (15, N'blue', CAST(N'2024-04-02T12:28:57.1234752' AS DateTime2), 14, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (16, N'Blue', CAST(N'2024-04-03T09:15:27.8693184' AS DateTime2), 15, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (17, N'yellow', CAST(N'2024-04-03T09:15:38.9812373' AS DateTime2), 15, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (18, N'red', CAST(N'2024-04-03T09:15:43.8118624' AS DateTime2), 15, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (19, N'A) Paris', CAST(N'2024-04-06T11:01:53.8238922' AS DateTime2), 17, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (20, N'B) London', CAST(N'2024-04-06T11:02:01.1423701' AS DateTime2), 17, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (21, N'C) Berlin', CAST(N'2024-04-06T11:02:08.2297950' AS DateTime2), 17, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (22, N'D) Rome', CAST(N'2024-04-06T11:02:14.5717302' AS DateTime2), 17, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (23, N'A) Vincent van Gogh', CAST(N'2024-04-06T11:02:50.4943638' AS DateTime2), 19, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (24, N'B) Leonardo da Vinci', CAST(N'2024-04-06T11:02:58.4790505' AS DateTime2), 19, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (25, N'C) Pablo Picasso', CAST(N'2024-04-06T11:03:03.6786568' AS DateTime2), 19, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (26, N'D) Michelangelo', CAST(N'2024-04-06T11:03:12.3502778' AS DateTime2), 19, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (27, N'A) O', CAST(N'2024-04-06T11:03:45.9984502' AS DateTime2), 21, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (28, N'B) H2O', CAST(N'2024-04-06T11:03:51.8458650' AS DateTime2), 21, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (29, N'C) H', CAST(N'2024-04-06T11:03:57.3307701' AS DateTime2), 21, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (30, N'D) W', CAST(N'2024-04-06T11:04:02.1899981' AS DateTime2), 21, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (31, N'A) Venus', CAST(N'2024-04-06T11:04:37.8141540' AS DateTime2), 23, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (32, N'B) Mars', CAST(N'2024-04-06T11:04:42.9664974' AS DateTime2), 23, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (33, N'C) Jupiter', CAST(N'2024-04-06T11:04:48.2784499' AS DateTime2), 23, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (34, N'D) Saturn', CAST(N'2024-04-06T11:04:53.7577519' AS DateTime2), 23, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (35, N'A) Elephant', CAST(N'2024-04-06T11:05:37.8220230' AS DateTime2), 25, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (36, N'B) Blue Whale', CAST(N'2024-04-06T11:05:43.1578947' AS DateTime2), 25, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (37, N'C) Giraffe', CAST(N'2024-04-06T11:05:50.4697776' AS DateTime2), 25, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (38, N'D) Hippopotamus', CAST(N'2024-04-06T11:05:58.5338889' AS DateTime2), 25, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (39, N'E) Lizzo', CAST(N'2024-04-06T11:06:14.5429607' AS DateTime2), 25, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (40, N'A) Isaac Newton', CAST(N'2024-04-06T11:06:41.2371932' AS DateTime2), 27, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (41, N'B) Albert Einstein', CAST(N'2024-04-06T11:06:46.1905357' AS DateTime2), 27, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (42, N'C) Galileo Galilei', CAST(N'2024-04-06T11:06:51.1249046' AS DateTime2), 27, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (43, N'D) Nikola Tesla', CAST(N'2024-04-06T11:06:55.8925507' AS DateTime2), 27, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (44, N'A) Au', CAST(N'2024-04-06T11:07:23.0375071' AS DateTime2), 29, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (45, N'B) Ag', CAST(N'2024-04-06T11:07:29.0211907' AS DateTime2), 29, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (46, N'C) G', CAST(N'2024-04-06T11:07:34.1852701' AS DateTime2), 29, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (47, N'D) Go', CAST(N'2024-04-06T11:07:40.2856354' AS DateTime2), 29, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (48, N'Green eyes, torti', CAST(N'2024-04-08T09:52:00.4611861' AS DateTime2), 31, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (49, N'Orange eyed, black', CAST(N'2024-04-08T09:52:13.1093023' AS DateTime2), 31, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (50, N'Blue eyes, white', CAST(N'2024-04-08T09:52:20.0856844' AS DateTime2), 31, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (51, N'One brain cell, orange', CAST(N'2024-04-08T09:52:25.7254084' AS DateTime2), 31, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (52, N'true ', CAST(N'2024-04-08T10:28:34.4161982' AS DateTime2), 33, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (53, N'False', CAST(N'2024-04-08T10:28:45.8306263' AS DateTime2), 33, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (54, N'false', CAST(N'2024-04-08T11:35:27.4500336' AS DateTime2), 34, 1)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (55, N'True', CAST(N'2024-04-08T11:40:05.5419087' AS DateTime2), 35, 1)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (56, N'True ', CAST(N'2024-04-08T11:45:15.1028834' AS DateTime2), 36, 1)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (57, N'False', CAST(N'2024-04-08T11:45:23.0795177' AS DateTime2), 36, 0)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (58, N'True', CAST(N'2024-04-10T09:33:00.3504141' AS DateTime2), 37, 1)
INSERT [dbo].[Answers] ([Id], [AnswerText], [CreateDate], [QuestionId], [CorrectAnswer]) VALUES (59, N'False', CAST(N'2024-04-10T09:33:08.5731732' AS DateTime2), 37, 0)
SET IDENTITY_INSERT [dbo].[Answers] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (3, N'Will this work?', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 8, 0, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (4, N'Here is another question gigady', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 8, 0, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (5, N'what is the primary purpose of a radio button?', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 11, 0, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (6, N'what is the favorite color', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 12, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (7, N'how many answers does derek put in his multiple choice quetions?', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 14, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (8, N'test', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 15, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (9, N'hello', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 16, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (10, N'Test T or F', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 17, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (11, N'Test multie choice', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 17, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (12, N'Question 3', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 17, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (13, N'deny making answer for t or f questions', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 18, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (14, N'what is erecons favite color', CAST(N'2024-04-02T12:28:35.5542440' AS DateTime2), 19, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (15, N'what color is the sky', CAST(N'2024-04-03T09:15:18.0708774' AS DateTime2), 20, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (16, N'The Great Wall of China is visible from space.', CAST(N'2024-04-06T11:01:22.9932156' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (17, N'What is the capital of France?', CAST(N'2024-04-06T11:01:43.0424368' AS DateTime2), 21, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (18, N'The human body has four lungs.', CAST(N'2024-04-06T11:02:31.5026123' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (19, N'Who painted the Mona Lisa?', CAST(N'2024-04-06T11:02:43.2462152' AS DateTime2), 21, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (20, N'The Earth is the only planet in the solar system that has one moon.', CAST(N'2024-04-06T11:03:22.7584303' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (21, N'What is the chemical symbol for water?', CAST(N'2024-04-06T11:03:36.0385702' AS DateTime2), 21, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (22, N'Mount Everest is the tallest mountain in the world.', CAST(N'2024-04-06T11:04:16.1176179' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (23, N'Which planet is known as the Red Planet?', CAST(N'2024-04-06T11:04:30.1807430' AS DateTime2), 21, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (24, N'The Statue of Liberty was a gift from France to the United States.', CAST(N'2024-04-06T11:05:17.8295406' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (25, N'What is the largest mammal in the world?', CAST(N'2024-04-06T11:05:34.6288890' AS DateTime2), 21, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (26, N' The currency of Japan is the yen.', CAST(N'2024-04-06T11:06:24.3244005' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (27, N'Which scientist developed the theory of relativity?', CAST(N'2024-04-06T11:06:33.6695641' AS DateTime2), 21, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (28, N'Spiders are insects.', CAST(N'2024-04-06T11:07:08.4046205' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (29, N'What is the chemical symbol for gold?', CAST(N'2024-04-06T11:07:17.3409036' AS DateTime2), 21, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (30, N'The Amazon River is the longest river in the world.', CAST(N'2024-04-06T11:07:51.5258835' AS DateTime2), 21, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (31, N'Which colour combination tends to lead to deafness?', CAST(N'2024-04-08T09:51:42.0010630' AS DateTime2), 22, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (32, N'Derek is the best teacher', CAST(N'2024-04-08T10:22:23.5034959' AS DateTime2), 23, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (33, N'Derek is the best teacher', CAST(N'2024-04-08T10:28:28.3860296' AS DateTime2), 25, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (34, N'is the sky blue', CAST(N'2024-04-08T11:35:09.4672736' AS DateTime2), 26, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (35, N'sky blue 2?', CAST(N'2024-04-08T11:39:57.8044239' AS DateTime2), 27, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (36, N'Is the SKY Blue 3?', CAST(N'2024-04-08T11:45:07.8627117' AS DateTime2), 28, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (37, N'Does .Trim() remove spaces.', CAST(N'2024-04-10T09:32:36.3472019' AS DateTime2), 29, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (38, N'say my name.', CAST(N'2024-04-14T10:36:53.5543401' AS DateTime2), 30, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (39, N'asdf', CAST(N'2024-04-14T11:42:06.4439692' AS DateTime2), 37, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (40, N'Test question', CAST(N'2024-04-14T12:13:33.1484308' AS DateTime2), 38, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (41, N'asdf', CAST(N'2024-04-14T12:15:49.8110372' AS DateTime2), 39, 0, 1)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (42, N'Test the for ground', CAST(N'2024-04-14T12:16:32.0423994' AS DateTime2), 40, 1, 0)
INSERT [dbo].[Questions] ([Id], [QuestionText], [CreateDate], [QuizId], [IsMultipleChoice], [IsTrueFalse]) VALUES (43, N'asdgf', CAST(N'2024-04-14T12:17:15.5695766' AS DateTime2), 41, 1, 0)
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
SET IDENTITY_INSERT [dbo].[Quizzes] ON 

INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (1, N'Saving quiz to DB', CAST(N'2024-03-30T10:30:18.8574815' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (2, N'US presidents', CAST(N'2024-03-30T11:21:35.0089237' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (3, N'Test', CAST(N'2024-03-30T11:24:35.2626424' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (4, N'test2', CAST(N'2024-03-30T11:27:05.2961263' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (5, N'test3-Addquestions', CAST(N'2024-03-30T11:33:54.0975527' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (6, N'asdf', CAST(N'2024-03-30T11:35:51.3961536' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (7, N'a', CAST(N'2024-03-30T11:38:20.9447840' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (8, N'Test-addQuestion-viaQuiz id', CAST(N'2024-03-30T11:50:22.5784580' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (9, N'Whos your daddy?', CAST(N'2024-03-30T11:59:26.5298658' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (10, N'a', CAST(N'2024-03-30T13:13:23.0915066' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (11, N'Test quiz radio buttons', CAST(N'2024-03-31T12:11:48.3182298' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (12, N'What is josh''s favorite color', CAST(N'2024-03-31T12:57:33.6066680' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (13, N'What is josh''s favorite color', CAST(N'2024-03-31T13:01:57.4464658' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (14, N'Test Adding answers', CAST(N'2024-03-31T13:28:24.4524290' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (15, N'a', CAST(N'2024-03-31T13:58:46.8798658' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (16, N'TestAnswers', CAST(N'2024-03-31T14:33:20.2388070' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (17, N'Adding multiple questions with answers ', CAST(N'2024-03-31T14:38:10.4533404' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (18, N'a', CAST(N'2024-03-31T14:46:36.5087471' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (19, N'Eicson quiz', CAST(N'2024-04-02T12:28:11.6144793' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (20, N'New Quiz', CAST(N'2024-04-03T09:14:17.0267284' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (21, N'Trivia quiz', CAST(N'2024-04-06T11:01:06.9329673' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (22, N'Cat Facts', CAST(N'2024-04-08T09:50:52.6909264' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (23, N'Are answers saved to the database?', CAST(N'2024-04-08T10:22:04.4241813' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (24, N'correct answer test', CAST(N'2024-04-08T10:26:44.6014041' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (25, N't||f add answr test', CAST(N'2024-04-08T10:27:23.6255185' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (26, N'test t/f answer', CAST(N'2024-04-08T11:34:53.4175864' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (27, N'test', CAST(N'2024-04-08T11:39:46.1557011' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (28, N'Test answer 3', CAST(N'2024-04-08T11:44:51.7654602' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (29, N'Test answer.Trim()', CAST(N'2024-04-10T09:31:56.1877015' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (30, N'Test', CAST(N'2024-04-14T10:36:39.1011181' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (31, N'a', CAST(N'2024-04-14T10:46:22.4953132' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (32, N's', CAST(N'2024-04-14T10:47:22.0244800' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (33, N'a', CAST(N'2024-04-14T11:04:34.8483094' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (34, N'a', CAST(N'2024-04-14T11:05:01.6257415' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (35, N'a', CAST(N'2024-04-14T11:05:39.0635483' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (36, N'a', CAST(N'2024-04-14T11:26:45.6678614' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (37, N'test 99', CAST(N'2024-04-14T11:41:51.2187310' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (38, N'a', CAST(N'2024-04-14T12:13:21.8539353' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (39, N'aaa', CAST(N'2024-04-14T12:15:44.5198658' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (40, N'd', CAST(N'2024-04-14T12:16:10.2272468' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (41, N'asdf', CAST(N'2024-04-14T12:16:57.0910904' AS DateTime2))
INSERT [dbo].[Quizzes] ([Id], [QuizName], [CreateDate]) VALUES (42, N'test', CAST(N'2024-04-14T12:22:38.5789114' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Quizzes] OFF
GO
/****** Object:  Index [IX_Answers_QuestionId]    Script Date: 4/14/2024 2:27:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_Answers_QuestionId] ON [dbo].[Answers]
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Questions_QuizId]    Script Date: 4/14/2024 2:27:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_Questions_QuizId] ON [dbo].[Questions]
(
	[QuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserQuiz_QuizId]    Script Date: 4/14/2024 2:27:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserQuiz_QuizId] ON [dbo].[UserQuiz]
(
	[QuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserQuiz_UserId]    Script Date: 4/14/2024 2:27:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserQuiz_UserId] ON [dbo].[UserQuiz]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Answers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [CorrectAnswer]
GO
ALTER TABLE [dbo].[Questions] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsMultipleChoice]
GO
ALTER TABLE [dbo].[Questions] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsTrueFalse]
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_Answers_Questions_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([Id])
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_Answers_Questions_QuestionId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Quizzes_QuizId] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quizzes] ([Id])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_Quizzes_QuizId]
GO
ALTER TABLE [dbo].[UserQuiz]  WITH CHECK ADD  CONSTRAINT [FK_UserQuiz_Quizzes_QuizId] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quizzes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserQuiz] CHECK CONSTRAINT [FK_UserQuiz_Quizzes_QuizId]
GO
ALTER TABLE [dbo].[UserQuiz]  WITH CHECK ADD  CONSTRAINT [FK_UserQuiz_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserQuiz] CHECK CONSTRAINT [FK_UserQuiz_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [SqlLiveQuizFinal] SET  READ_WRITE 
GO
