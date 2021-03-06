USE [master]
GO
/****** Object:  Database [SigmaDb1]    Script Date: 4/19/2017 10:52:22 PM ******/
CREATE DATABASE [SigmaDb1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SigmaDb1', FILENAME = N'C:\Projects\Jahani\Sigma\Sigma1\Database\SigmaDb1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB ), 
 FILEGROUP [Files] 
( NAME = N'SigmaDb1_Files', FILENAME = N'C:\Projects\Jahani\Sigma\Sigma1\Database\SigmaDb1_Files.ndf' , SIZE = 102400KB , MAXSIZE = UNLIMITED, FILEGROWTH = 50%)
 LOG ON 
( NAME = N'SigmaDb1_log', FILENAME = N'C:\Projects\Jahani\Sigma\Sigma1\Database\SigmaDb1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SigmaDb1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SigmaDb1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SigmaDb1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SigmaDb1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SigmaDb1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SigmaDb1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SigmaDb1] SET ARITHABORT OFF 
GO
ALTER DATABASE [SigmaDb1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SigmaDb1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SigmaDb1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SigmaDb1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SigmaDb1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SigmaDb1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SigmaDb1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SigmaDb1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SigmaDb1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SigmaDb1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SigmaDb1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SigmaDb1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SigmaDb1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SigmaDb1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SigmaDb1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SigmaDb1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SigmaDb1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SigmaDb1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SigmaDb1] SET  MULTI_USER 
GO
ALTER DATABASE [SigmaDb1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SigmaDb1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SigmaDb1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SigmaDb1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SigmaDb1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SigmaDb1]
GO
/****** Object:  Table [dbo].[AdminSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminSet](
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_AdminSet] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CitySet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CitySet](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ProvinceId] [int] NOT NULL,
 CONSTRAINT [PK_CitySet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocumentSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentSet](
	[Id] [int] NOT NULL,
	[ResumeId] [int] NOT NULL,
	[Lenght] [int] NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Binaries] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_DocumentSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [Files]

GO
/****** Object:  Table [dbo].[EducationSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationSet](
	[Id] [int] NOT NULL,
 CONSTRAINT [PK_EducationSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobSet](
	[Id] [int] NOT NULL,
 CONSTRAINT [PK_JobSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Logger]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logger](
	[IndexId] [int] IDENTITY(1,1) NOT NULL,
	[MasterId] [nvarchar](50) NOT NULL,
	[EventDateTime] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Logger_1] PRIMARY KEY CLUSTERED 
(
	[IndexId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PasswordSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PasswordSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](500) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_PasswordSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProvinceSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProvinceSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProvinceSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ResumeSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResumeSet](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](300) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_ResumeSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserSet]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSet](
	[Id] [int] NOT NULL,
	[Image] [varbinary](max) NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserSet_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [Files]

GO
/****** Object:  View [dbo].[UserView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* partitioning 

SELECT
*
,   ROW_NUMBER() OVER (PARTITION BY MasterId ORDER BY IndexId Desc) AS rn
FROM
    UserView
*/
CREATE VIEW [dbo].[UserView]
AS
SELECT        a.MasterId, a.IndexId, a.UpdatesCount, b.Id, b.Image, b.Firstname, b.Lastname
FROM            (SELECT        MasterId, MAX(IndexId) AS IndexId, COUNT(*) AS UpdatesCount
                          FROM            (SELECT        u.Id, u.Image, u.Firstname, u.Lastname, l.IndexId, l.MasterId, l.EventDateTime, l.IsDeleted
                                                    FROM            dbo.Logger AS l INNER JOIN
                                                                              dbo.UserSet AS u ON l.IndexId = u.Id) AS c
                          GROUP BY MasterId, CAST(MasterId AS varbinary(100))) AS a INNER JOIN
                         dbo.UserSet AS b ON a.IndexId = b.Id

GO
/****** Object:  View [dbo].[UserPasswordView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserPasswordView]
AS
SELECT        dbo.UserView.MasterId, dbo.UserView.IndexId, dbo.UserView.UpdatesCount, dbo.UserView.Id, dbo.UserView.Image, dbo.UserView.Firstname, 
                         dbo.UserView.Lastname, dbo.PasswordSet.Value AS Password
FROM            dbo.UserView INNER JOIN
                         dbo.PasswordSet ON dbo.UserView.Id = dbo.PasswordSet.UserId

GO
/****** Object:  View [dbo].[AdminView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AdminView]
AS
SELECT        dbo.Logger.IndexId, dbo.Logger.MasterId, dbo.Logger.EventDateTime, dbo.Logger.IsDeleted
FROM            dbo.AdminSet INNER JOIN
                         dbo.Logger ON dbo.AdminSet.UserId = dbo.Logger.IndexId

GO
/****** Object:  View [dbo].[DocumentView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DocumentView]
AS
SELECT        dbo.Logger.*, dbo.DocumentSet.*
FROM            dbo.Logger INNER JOIN
                         dbo.DocumentSet ON dbo.Logger.IndexId = dbo.DocumentSet.Id

GO
/****** Object:  View [dbo].[EducationView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[EducationView]
AS
SELECT        dbo.Logger.*, dbo.EducationSet.*
FROM            dbo.EducationSet INNER JOIN
                         dbo.Logger ON dbo.EducationSet.Id = dbo.Logger.IndexId

GO
/****** Object:  View [dbo].[JobView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[JobView]
AS
SELECT        dbo.Logger.*, dbo.JobSet.*
FROM            dbo.JobSet INNER JOIN
                         dbo.Logger ON dbo.JobSet.Id = dbo.Logger.IndexId

GO
/****** Object:  View [dbo].[PasswordView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PasswordView]
AS
SELECT        dbo.Logger.*, dbo.PasswordSet.*
FROM            dbo.PasswordSet INNER JOIN
                         dbo.Logger ON dbo.PasswordSet.Id = dbo.Logger.IndexId

GO
/****** Object:  View [dbo].[ResumeView]    Script Date: 4/19/2017 10:52:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ResumeView]
AS
SELECT        dbo.ResumeSet.*, dbo.Logger.*
FROM            dbo.ResumeSet INNER JOIN
                         dbo.Logger ON dbo.ResumeSet.Id = dbo.Logger.IndexId

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ResumeSet]    Script Date: 4/19/2017 10:52:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_ResumeSet] ON [dbo].[ResumeSet]
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Logger] ADD  CONSTRAINT [DF_Logger_UniqueId]  DEFAULT (newid()) FOR [MasterId]
GO
ALTER TABLE [dbo].[Logger] ADD  CONSTRAINT [DF_Logger_EventDateTime]  DEFAULT (getdate()) FOR [EventDateTime]
GO
ALTER TABLE [dbo].[Logger] ADD  CONSTRAINT [DF_Logger_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[AdminSet]  WITH CHECK ADD  CONSTRAINT [FK_AdminSet_Logger] FOREIGN KEY([UserId])
REFERENCES [dbo].[Logger] ([IndexId])
GO
ALTER TABLE [dbo].[AdminSet] CHECK CONSTRAINT [FK_AdminSet_Logger]
GO
ALTER TABLE [dbo].[AdminSet]  WITH CHECK ADD  CONSTRAINT [FK_AdminSet_UserSet] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserSet] ([Id])
GO
ALTER TABLE [dbo].[AdminSet] CHECK CONSTRAINT [FK_AdminSet_UserSet]
GO
ALTER TABLE [dbo].[CitySet]  WITH CHECK ADD  CONSTRAINT [FK_CitySet_ProvinceSet] FOREIGN KEY([ProvinceId])
REFERENCES [dbo].[ProvinceSet] ([Id])
GO
ALTER TABLE [dbo].[CitySet] CHECK CONSTRAINT [FK_CitySet_ProvinceSet]
GO
ALTER TABLE [dbo].[DocumentSet]  WITH CHECK ADD  CONSTRAINT [FK_DocumentSet_Logger] FOREIGN KEY([Id])
REFERENCES [dbo].[Logger] ([IndexId])
GO
ALTER TABLE [dbo].[DocumentSet] CHECK CONSTRAINT [FK_DocumentSet_Logger]
GO
ALTER TABLE [dbo].[DocumentSet]  WITH CHECK ADD  CONSTRAINT [FK_DocumentSet_ResumeSet] FOREIGN KEY([ResumeId])
REFERENCES [dbo].[ResumeSet] ([Id])
GO
ALTER TABLE [dbo].[DocumentSet] CHECK CONSTRAINT [FK_DocumentSet_ResumeSet]
GO
ALTER TABLE [dbo].[EducationSet]  WITH CHECK ADD  CONSTRAINT [FK_EducationSet_Logger] FOREIGN KEY([Id])
REFERENCES [dbo].[Logger] ([IndexId])
GO
ALTER TABLE [dbo].[EducationSet] CHECK CONSTRAINT [FK_EducationSet_Logger]
GO
ALTER TABLE [dbo].[EducationSet]  WITH CHECK ADD  CONSTRAINT [FK_EducationSet_ResumeSet] FOREIGN KEY([Id])
REFERENCES [dbo].[ResumeSet] ([Id])
GO
ALTER TABLE [dbo].[EducationSet] CHECK CONSTRAINT [FK_EducationSet_ResumeSet]
GO
ALTER TABLE [dbo].[JobSet]  WITH CHECK ADD  CONSTRAINT [FK_JobSet_Logger] FOREIGN KEY([Id])
REFERENCES [dbo].[Logger] ([IndexId])
GO
ALTER TABLE [dbo].[JobSet] CHECK CONSTRAINT [FK_JobSet_Logger]
GO
ALTER TABLE [dbo].[JobSet]  WITH CHECK ADD  CONSTRAINT [FK_JobSet_ResumeSet] FOREIGN KEY([Id])
REFERENCES [dbo].[ResumeSet] ([Id])
GO
ALTER TABLE [dbo].[JobSet] CHECK CONSTRAINT [FK_JobSet_ResumeSet]
GO
ALTER TABLE [dbo].[PasswordSet]  WITH CHECK ADD  CONSTRAINT [FK_PasswordSet_UserSet] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserSet] ([Id])
GO
ALTER TABLE [dbo].[PasswordSet] CHECK CONSTRAINT [FK_PasswordSet_UserSet]
GO
ALTER TABLE [dbo].[ResumeSet]  WITH CHECK ADD  CONSTRAINT [FK_ResumeSet_Logger] FOREIGN KEY([Id])
REFERENCES [dbo].[Logger] ([IndexId])
GO
ALTER TABLE [dbo].[ResumeSet] CHECK CONSTRAINT [FK_ResumeSet_Logger]
GO
ALTER TABLE [dbo].[ResumeSet]  WITH CHECK ADD  CONSTRAINT [FK_ResumeSet_UserSet] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserSet] ([Id])
GO
ALTER TABLE [dbo].[ResumeSet] CHECK CONSTRAINT [FK_ResumeSet_UserSet]
GO
ALTER TABLE [dbo].[UserSet]  WITH CHECK ADD  CONSTRAINT [FK_UserSet_Logger] FOREIGN KEY([Id])
REFERENCES [dbo].[Logger] ([IndexId])
GO
ALTER TABLE [dbo].[UserSet] CHECK CONSTRAINT [FK_UserSet_Logger]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "AdminSet"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 84
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Logger"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AdminView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AdminView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -1054
      End
      Begin Tables = 
         Begin Table = "Logger"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DocumentSet"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DocumentView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DocumentView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "EducationSet"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 84
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Logger"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 135
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'EducationView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'EducationView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "JobSet"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 84
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Logger"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'JobView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'JobView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PasswordSet"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 118
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Logger"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PasswordView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PasswordView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ResumeSet"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Logger"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ResumeView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ResumeView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "UserView"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PasswordSet"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 118
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserPasswordView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserPasswordView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 118
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserView'
GO
USE [master]
GO
ALTER DATABASE [SigmaDb1] SET  READ_WRITE 
GO
