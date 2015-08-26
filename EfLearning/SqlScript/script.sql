/****  Please Create database with name EfLearning ****/
USE [EfLearning]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 08/26/2015 17:41:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Department] ON
INSERT [dbo].[Department] ([Id], [Name]) VALUES (1, N'IT')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (2, N'Admin')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (3, N'HR')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (4, N'Account')
SET IDENTITY_INSERT [dbo].[Department] OFF
/****** Object:  Table [dbo].[Employee]    Script Date: 08/26/2015 17:41:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Email] [varchar](20) NOT NULL,
	[DepartmentId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([ID], [Name], [Email], [DepartmentId]) VALUES (1, N'Aslam', N'aslam@gmail.com', 1)
INSERT [dbo].[Employee] ([ID], [Name], [Email], [DepartmentId]) VALUES (2, N'Sanjay', N'sanjay@gmail.com', 1)
INSERT [dbo].[Employee] ([ID], [Name], [Email], [DepartmentId]) VALUES (3, N'Adil', N'adil@gmail.com', 1)
INSERT [dbo].[Employee] ([ID], [Name], [Email], [DepartmentId]) VALUES (4, N'Sameer', N'sameer@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  ForeignKey [FK__Employee__Depart__0519C6AF]    Script Date: 08/26/2015 17:41:47 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
