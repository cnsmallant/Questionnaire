USE [QuestionnaireDB]
GO
/****** Object:  Table [dbo].[AdminInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdminInfo](
	[AdminId] [varchar](50) NOT NULL,
	[AdminName] [varchar](50) NULL,
	[AdminPwd] [varchar](50) NULL,
	[AdminType] [int] NULL,
	[AdminDate] [datetime] NULL,
 CONSTRAINT [PK_AdminInfo] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CommentInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CommentInfo](
	[CommentId] [int] IDENTITY(10000000,1) NOT NULL,
	[CommentDepict] [text] NULL,
	[UserId] [varchar](50) NULL,
	[PapersId] [int] NULL,
	[CommentDate] [datetime] NULL,
 CONSTRAINT [PK_CommentInfo] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LaudInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LaudInfo](
	[LaudId] [int] IDENTITY(1,1) NOT NULL,
	[CommentId] [int] NULL,
	[IPAddress] [varchar](255) NULL,
	[City] [varchar](50) NULL,
	[LaudDate] [datetime] NULL,
	[PapersId] [int] NULL,
 CONSTRAINT [PK_LaudInfo] PRIMARY KEY CLUSTERED 
(
	[LaudId] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OptionInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OptionInfo](
	[OptionId] [varchar](50) NOT NULL,
	[OptionContent] [varchar](225) NULL,
	[SubjectId] [int] NULL,
	[OptionDate] [datetime] NULL,
	[AdminId] [varchar](50) NULL,
 CONSTRAINT [PK_OptionInfo] PRIMARY KEY CLUSTERED 
(
	[OptionId] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PapersInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PapersInfo](
	[PapersId] [int] IDENTITY(10000,1) NOT NULL,
	[PapersTitle] [varchar](225) NULL,
	[PapersDepict] [text] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[PapersDate] [datetime] NULL,
	[AdminId] [varchar](50) NULL,
 CONSTRAINT [PK_ContentInfo] PRIMARY KEY CLUSTERED 
(
	[PapersId] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubjectInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubjectInfo](
	[SubjectId] [int] IDENTITY(100000,1) NOT NULL,
	[SubjectDepict] [text] NULL,
	[PapersId] [int] NULL,
	[SubjectType] [int] NULL,
	[SubjectDate] [datetime] NULL,
	[AdminId] [varchar](50) NULL,
 CONSTRAINT [PK_SubjectInfo] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [varchar](50) NOT NULL,
	[UserName] [varchar](225) NULL,
	[UserPhone] [varchar](50) NULL,
	[UserDate] [datetime] NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VoteInfo]    Script Date: 2017/6/19 14:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VoteInfo](
	[VoteId] [int] IDENTITY(1,1) NOT NULL,
	[PapersId] [int] NULL,
	[SubjectId] [int] NULL,
	[OptionId] [varchar](50) NULL,
	[VoteDepict] [text] NULL,
	[IPAddress] [varchar](50) NULL,
	[VoteDate] [datetime] NULL,
 CONSTRAINT [PK_VoteInfo] PRIMARY KEY CLUSTERED 
(
	[VoteId] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[AdminInfo] ([AdminId], [AdminName], [AdminPwd], [AdminType], [AdminDate]) VALUES (CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'), CONVERT(TEXT, N'admin'), CONVERT(TEXT, N'qsJDEJn+oo8='), 0, CAST(0x0000A78D00EBDFBF AS DateTime))
SET IDENTITY_INSERT [dbo].[CommentInfo] ON 

INSERT [dbo].[CommentInfo] ([CommentId], [CommentDepict], [UserId], [PapersId], [CommentDate]) VALUES (10000001, CONVERT(TEXT, N'你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港'), CONVERT(TEXT, N'dfb54634e86f4c12854e5eb9f7ad148d'), 10000, CAST(0x0000A79200F22CE0 AS DateTime))
INSERT [dbo].[CommentInfo] ([CommentId], [CommentDepict], [UserId], [PapersId], [CommentDate]) VALUES (10000002, CONVERT(TEXT, N'你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港'), CONVERT(TEXT, N'c53738a76ee5481aab2d6bd581aa1427'), 10000, CAST(0x0000A79200F26E80 AS DateTime))
INSERT [dbo].[CommentInfo] ([CommentId], [CommentDepict], [UserId], [PapersId], [CommentDate]) VALUES (10000003, CONVERT(TEXT, N'你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！你好！威海信息港！'), CONVERT(TEXT, N'5975298346e54ac9a211f8854c90dad8'), 10000, CAST(0x0000A79200F33A68 AS DateTime))
INSERT [dbo].[CommentInfo] ([CommentId], [CommentDepict], [UserId], [PapersId], [CommentDate]) VALUES (10000004, CONVERT(TEXT, N'你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！你好！'), CONVERT(TEXT, N'4073a9b2ebc3492ea06ac590a53dd622'), 10000, CAST(0x0000A797009BEFEC AS DateTime))
SET IDENTITY_INSERT [dbo].[CommentInfo] OFF
SET IDENTITY_INSERT [dbo].[LaudInfo] ON 

INSERT [dbo].[LaudInfo] ([LaudId], [CommentId], [IPAddress], [City], [LaudDate], [PapersId]) VALUES (1, 10000001, CONVERT(TEXT, N'::1'), CONVERT(TEXT, N''), CAST(0x0000A792010CA124 AS DateTime), 10000)
INSERT [dbo].[LaudInfo] ([LaudId], [CommentId], [IPAddress], [City], [LaudDate], [PapersId]) VALUES (2, 10000000, CONVERT(TEXT, N'::1'), CONVERT(TEXT, N''), CAST(0x0000A792010E83F4 AS DateTime), 10000)
INSERT [dbo].[LaudInfo] ([LaudId], [CommentId], [IPAddress], [City], [LaudDate], [PapersId]) VALUES (3, 10000002, CONVERT(TEXT, N'::1'), CONVERT(TEXT, N''), CAST(0x0000A792010F4B2C AS DateTime), 10000)
INSERT [dbo].[LaudInfo] ([LaudId], [CommentId], [IPAddress], [City], [LaudDate], [PapersId]) VALUES (4, 10000003, CONVERT(TEXT, N'::1'), CONVERT(TEXT, N''), CAST(0x0000A797008DF180 AS DateTime), 10000)
SET IDENTITY_INSERT [dbo].[LaudInfo] OFF
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'038b2793699148ad963865c40849971e'), CONVERT(TEXT, N'不能'), 100011, CAST(0x0000A79000F49A90 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'052bac93b913452897e915a270462dfb'), CONVERT(TEXT, N'家里'), 100008, CAST(0x0000A79000F34E98 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'0cd6253ca53c4753aa628994961a3098'), CONVERT(TEXT, N'威海相关新闻、实用信息'), 100009, CAST(0x0000A79000F394C7 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'1491b762233b450483731dcff348a164'), CONVERT(TEXT, N'能'), 100011, CAST(0x0000A79000F495AD AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'19655cb2a4b94ed79d87961c3a59dea3'), CONVERT(TEXT, N'时政、国际、社会、财经类硬新闻'), 100009, CAST(0x0000A79000F39B1B AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'1ccd514684c94a2a8895667bff397efd'), CONVERT(TEXT, N'文本'), 100012, CAST(0x0000A79000F4E955 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'339030878618458ba60dd33f94576f03'), CONVERT(TEXT, N'45岁以上'), 100002, CAST(0x0000A79000ED2DF8 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'48605f5c3f504396a15c8980672f345f'), CONVERT(TEXT, N'一天阅读3次以上'), 100007, CAST(0x0000A79000F2D060 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'4eeb5c16f5684867930b19970374222d'), CONVERT(TEXT, N'认可'), 100010, CAST(0x0000A79000F433E2 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'5315c22f851c4d3ca439a17ecfa7d1cf'), CONVERT(TEXT, N'一天阅读1-3次'), 100007, CAST(0x0000A79000F2C9C3 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'54457353ab574f419521430965599e7a'), CONVERT(TEXT, N'使用生活助手（如二手房、招聘、供求等）'), 100005, CAST(0x0000A79000F1D161 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'726bc04302484090b8e55189ae0fc17d'), CONVERT(TEXT, N'10年以上'), 100004, CAST(0x0000A79000F070B5 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'752d9c17b3294917859faf142a3dec65'), CONVERT(TEXT, N'15——25岁'), 100002, CAST(0x0000A79000ED0663 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'77518414904c4284915b5ca2e034f74f'), CONVERT(TEXT, N'学校'), 100008, CAST(0x0000A79000F35519 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'784e636ab7874e93906277301b129a9a'), CONVERT(TEXT, N'1-3年'), 100004, CAST(0x0000A79000F056D4 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'7af83676279847fe92c1dfba5d964f85'), CONVERT(TEXT, N'事业单位员工'), 100003, CAST(0x0000A79000EDE85C AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'7b02d4fdf09c483aa94ef28eda983460'), CONVERT(TEXT, N'35——45岁'), 100002, CAST(0x0000A79000ED14F2 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'906f6e33de07464f8b51dcb339e59060'), CONVERT(TEXT, N'视频、图片类内容'), 100009, CAST(0x0000A79000F3A8D2 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'91033d404ed34dda9580c520a0b6e0fc'), CONVERT(TEXT, N'7-10年'), 100004, CAST(0x0000A79000F067A9 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'9580939e28b64bd99bd6f111d6a0e616'), CONVERT(TEXT, N'晚上'), 100006, CAST(0x0000A79000F2A168 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'9a574fc551f146f686eded7c6f769a70'), CONVERT(TEXT, N'不认可'), 100010, CAST(0x0000A79000F438FE AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'9acfc16a7fde4770a59901c875f5d5b2'), CONVERT(TEXT, N'男'), 100000, CAST(0x0000A79000E71BBF AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'9ced14b288bb4b97bc5b656734647a19'), CONVERT(TEXT, N'25——35岁'), 100002, CAST(0x0000A79000ED0DBE AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'9f2bc0047c9f4d9a9d41619b61f38eb4'), CONVERT(TEXT, N'其他目的'), 100005, CAST(0x0000A79000F1F014 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'a26f5730e6f8445ba189c2d8d751a640'), CONVERT(TEXT, N'阅读资讯（文字、图片、视频）'), 100005, CAST(0x0000A79000F1C6D6 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'a8162d5eed1643649801de57b344efcd'), CONVERT(TEXT, N'早晨'), 100006, CAST(0x0000A79000F2901E AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'afdf880a914b47c49af52650937c9545'), CONVERT(TEXT, N'办公地'), 100008, CAST(0x0000A79000F35E4C AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'b057fba920654bf2b7115f417f9b7db9'), CONVERT(TEXT, N'企业员工'), 100003, CAST(0x0000A79000EDE1F3 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'c239964138d04da889ee0b40884d494d'), CONVERT(TEXT, N'泡论坛（威海社区）'), 100005, CAST(0x0000A79000F1E708 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'c58a8b93fc8d4459946b714dfc9fe034'), CONVERT(TEXT, N'自由职业'), 100003, CAST(0x0000A79000EDF599 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'd16583836a6e442283570a03415bc05a'), CONVERT(TEXT, N'女'), 100000, CAST(0x0000A79000E72337 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'd81d49cec2454b43ab10002a6f76d849'), CONVERT(TEXT, N'查询信息（如社保、公积金、违章等）'), 100005, CAST(0x0000A79000F1DC24 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'dbfb48c89b494fa4acc86710bdb33811'), CONVERT(TEXT, N'其他类型内容'), 100009, CAST(0x0000A79000F3B118 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'e487d05464e54c509b585bc1a577be7a'), CONVERT(TEXT, N'娱乐、体育、时尚、科技类软新闻'), 100009, CAST(0x0000A79000F3A1B4 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'e6efee84437445daa13a320ac7ec8d32'), CONVERT(TEXT, N'其他'), 100003, CAST(0x0000A79000EDFCD1 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'e847b8aa9e2145f38d45f8281a0081a5'), CONVERT(TEXT, N'户外'), 100008, CAST(0x0000A79000F36480 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'e8a53a03b06c426396d7c308350eaffd'), CONVERT(TEXT, N'15岁以下'), 100002, CAST(0x0000A79000ECFF76 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'e989bed3d6314ed2b1edc0e404e0b598'), CONVERT(TEXT, N'学生'), 100003, CAST(0x0000A79000EDDBB0 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'eb41201527c042f2be05fee53235af60'), CONVERT(TEXT, N'4-6年'), 100004, CAST(0x0000A79000F05E90 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'ed12b201479442dc8b03e02cffcdf666'), CONVERT(TEXT, N'中午'), 100006, CAST(0x0000A79000F293B8 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'f908076cacb3486ca7c0683989eaa39f'), CONVERT(TEXT, N'不定期阅读'), 100007, CAST(0x0000A79000F2D6B8 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[OptionInfo] ([OptionId], [OptionContent], [SubjectId], [OptionDate], [AdminId]) VALUES (CONVERT(TEXT, N'fca206f3a75d46ed8938ff111e35b611'), CONVERT(TEXT, N'下午'), 100006, CAST(0x0000A79000F29B79 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
SET IDENTITY_INSERT [dbo].[PapersInfo] ON 

INSERT [dbo].[PapersInfo] ([PapersId], [PapersTitle], [PapersDepict], [StartDate], [EndDate], [PapersDate], [AdminId]) VALUES (10000, CONVERT(TEXT, N'威海信息港'), CONVERT(TEXT, N'信息港的20年，是伴随威海成长的20年，是见证威海人生活变迁的20年，我们一直秉持服务威海的态度和与时俱进的心，本次改版，希望得到大家的认可，同时，也希望大家提出宝贵的意见和建议，以引导我们更好发展。'), CAST(0x0000A79000000000 AS DateTime), CAST(0x0000A7A200000000 AS DateTime), CAST(0x0000A7900095F336 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
SET IDENTITY_INSERT [dbo].[PapersInfo] OFF
SET IDENTITY_INSERT [dbo].[SubjectInfo] ON 

INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100000, CONVERT(TEXT, N'您的性别是？'), 10000, 1, CAST(0x0000A79000A82B1C AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100002, CONVERT(TEXT, N'您的年龄是？'), 10000, 1, CAST(0x0000A79000ECF2D3 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100003, CONVERT(TEXT, N'您的职业是？'), 10000, 1, CAST(0x0000A79000EDC583 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100004, CONVERT(TEXT, N'您使用威海信息港有多长时间了？'), 10000, 1, CAST(0x0000A79000EFFBE5 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100005, CONVERT(TEXT, N'您使用威海信息港的目的是？'), 10000, 2, CAST(0x0000A79000F1AEC3 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100006, CONVERT(TEXT, N'您习惯什么时间阅读新闻？'), 10000, 2, CAST(0x0000A79000F26FF0 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100007, CONVERT(TEXT, N'您阅读新闻的频率是？'), 10000, 1, CAST(0x0000A79000F2C078 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100008, CONVERT(TEXT, N'您通常阅读新闻的地点是？'), 10000, 2, CAST(0x0000A79000F34666 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100009, CONVERT(TEXT, N'您喜欢的新闻类型是什么？'), 10000, 2, CAST(0x0000A79000F386C4 AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100010, CONVERT(TEXT, N'您对新版威海信息港在布局、排版上的调整，是否认可？'), 10000, 1, CAST(0x0000A79000F429CA AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
INSERT [dbo].[SubjectInfo] ([SubjectId], [SubjectDepict], [PapersId], [SubjectType], [SubjectDate], [AdminId]) VALUES (100011, CONVERT(TEXT, N'您认为新版威海信息港首页是否能满足您阅读新闻的要求？'), 10000, 1, CAST(0x0000A79000F48C9B AS DateTime), CONVERT(TEXT, N'23e8164bbd6847b79142c10f0c3c936f'))
SET IDENTITY_INSERT [dbo].[SubjectInfo] OFF
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserPhone], [UserDate]) VALUES (CONVERT(TEXT, N'4073a9b2ebc3492ea06ac590a53dd622'), CONVERT(TEXT, N'王老五'), CONVERT(TEXT, N'13512345678'), CAST(0x0000A797009BEFEC AS DateTime))
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserPhone], [UserDate]) VALUES (CONVERT(TEXT, N'5975298346e54ac9a211f8854c90dad8'), CONVERT(TEXT, N'乔峰'), CONVERT(TEXT, N'13412345678'), CAST(0x0000A79200F33A68 AS DateTime))
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserPhone], [UserDate]) VALUES (CONVERT(TEXT, N'c53738a76ee5481aab2d6bd581aa1427'), CONVERT(TEXT, N'张无忌'), CONVERT(TEXT, N'13312345678'), CAST(0x0000A79200F26E80 AS DateTime))
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserPhone], [UserDate]) VALUES (CONVERT(TEXT, N'dfb54634e86f4c12854e5eb9f7ad148d'), CONVERT(TEXT, N'李四'), CONVERT(TEXT, N'13212345676'), CAST(0x0000A79200F22CE0 AS DateTime))
SET IDENTITY_INSERT [dbo].[VoteInfo] ON 

INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (328, NULL, 100000, CONVERT(TEXT, N'9acfc16a7fde4770a59901c875f5d5b2'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (329, NULL, 100002, CONVERT(TEXT, N'752d9c17b3294917859faf142a3dec65'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (330, NULL, 100003, CONVERT(TEXT, N'b057fba920654bf2b7115f417f9b7db9'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (331, NULL, 100004, CONVERT(TEXT, N'91033d404ed34dda9580c520a0b6e0fc'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (332, NULL, 100005, CONVERT(TEXT, N'd81d49cec2454b43ab10002a6f76d849'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (333, NULL, 100005, CONVERT(TEXT, N'9f2bc0047c9f4d9a9d41619b61f38eb4'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (334, NULL, 100005, CONVERT(TEXT, N'c239964138d04da889ee0b40884d494d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (335, NULL, 100006, CONVERT(TEXT, N'a8162d5eed1643649801de57b344efcd'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (336, NULL, 100006, CONVERT(TEXT, N'ed12b201479442dc8b03e02cffcdf666'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (337, NULL, 100007, CONVERT(TEXT, N'5315c22f851c4d3ca439a17ecfa7d1cf'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (338, NULL, 100007, CONVERT(TEXT, N'48605f5c3f504396a15c8980672f345f'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (339, NULL, 100008, CONVERT(TEXT, N'afdf880a914b47c49af52650937c9545'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (340, NULL, 100009, CONVERT(TEXT, N'19655cb2a4b94ed79d87961c3a59dea3'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (341, NULL, 100009, CONVERT(TEXT, N'e487d05464e54c509b585bc1a577be7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (342, NULL, 100009, CONVERT(TEXT, N'906f6e33de07464f8b51dcb339e59060'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (343, NULL, 100009, CONVERT(TEXT, N'dbfb48c89b494fa4acc86710bdb33811'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (344, NULL, 100010, CONVERT(TEXT, N'4eeb5c16f5684867930b19970374222d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (345, NULL, 100011, CONVERT(TEXT, N'038b2793699148ad963865c40849971e'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A577C4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (346, NULL, 100000, CONVERT(TEXT, N'd16583836a6e442283570a03415bc05a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5D32C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (347, NULL, 100002, CONVERT(TEXT, N'752d9c17b3294917859faf142a3dec65'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5D6B0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (348, NULL, 100004, CONVERT(TEXT, N'eb41201527c042f2be05fee53235af60'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5DB60 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (349, NULL, 100003, CONVERT(TEXT, N'c58a8b93fc8d4459946b714dfc9fe034'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5DDB8 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (350, NULL, 100005, CONVERT(TEXT, N'54457353ab574f419521430965599e7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5E010 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (351, NULL, 100005, CONVERT(TEXT, N'd81d49cec2454b43ab10002a6f76d849'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5E394 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (352, NULL, 100005, CONVERT(TEXT, N'c239964138d04da889ee0b40884d494d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5E5EC AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (353, NULL, 100006, CONVERT(TEXT, N'9580939e28b64bd99bd6f111d6a0e616'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5E844 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (354, NULL, 100006, CONVERT(TEXT, N'fca206f3a75d46ed8938ff111e35b611'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5EBC8 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (355, NULL, 100007, CONVERT(TEXT, N'48605f5c3f504396a15c8980672f345f'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5EE20 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (356, NULL, 100008, CONVERT(TEXT, N'e847b8aa9e2145f38d45f8281a0081a5'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5F078 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (357, NULL, 100008, CONVERT(TEXT, N'afdf880a914b47c49af52650937c9545'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5F2D0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (358, NULL, 100009, CONVERT(TEXT, N'e487d05464e54c509b585bc1a577be7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5F528 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (359, NULL, 100009, CONVERT(TEXT, N'0cd6253ca53c4753aa628994961a3098'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5F8AC AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (360, NULL, 100010, CONVERT(TEXT, N'4eeb5c16f5684867930b19970374222d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5FC30 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (361, NULL, 100011, CONVERT(TEXT, N'1491b762233b450483731dcff348a164'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A5FE88 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (362, NULL, 100000, CONVERT(TEXT, N'9acfc16a7fde4770a59901c875f5d5b2'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (363, NULL, 100002, CONVERT(TEXT, N'339030878618458ba60dd33f94576f03'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (364, NULL, 100003, CONVERT(TEXT, N'e6efee84437445daa13a320ac7ec8d32'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (365, NULL, 100004, CONVERT(TEXT, N'726bc04302484090b8e55189ae0fc17d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (366, NULL, 100005, CONVERT(TEXT, N'd81d49cec2454b43ab10002a6f76d849'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (367, NULL, 100005, CONVERT(TEXT, N'c239964138d04da889ee0b40884d494d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (368, NULL, 100005, CONVERT(TEXT, N'9f2bc0047c9f4d9a9d41619b61f38eb4'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (369, NULL, 100006, CONVERT(TEXT, N'9580939e28b64bd99bd6f111d6a0e616'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (370, NULL, 100007, CONVERT(TEXT, N'f908076cacb3486ca7c0683989eaa39f'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (371, NULL, 100008, CONVERT(TEXT, N'e847b8aa9e2145f38d45f8281a0081a5'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (372, NULL, 100008, CONVERT(TEXT, N'afdf880a914b47c49af52650937c9545'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (373, NULL, 100009, CONVERT(TEXT, N'dbfb48c89b494fa4acc86710bdb33811'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (374, NULL, 100009, CONVERT(TEXT, N'906f6e33de07464f8b51dcb339e59060'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (375, NULL, 100010, CONVERT(TEXT, N'9a574fc551f146f686eded7c6f769a70'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (376, NULL, 100011, CONVERT(TEXT, N'1491b762233b450483731dcff348a164'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200A75F44 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (377, NULL, 100000, CONVERT(TEXT, N'd16583836a6e442283570a03415bc05a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (378, NULL, 100002, CONVERT(TEXT, N'9ced14b288bb4b97bc5b656734647a19'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (379, NULL, 100003, CONVERT(TEXT, N'e6efee84437445daa13a320ac7ec8d32'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (380, NULL, 100004, CONVERT(TEXT, N'726bc04302484090b8e55189ae0fc17d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (381, NULL, 100005, CONVERT(TEXT, N'9f2bc0047c9f4d9a9d41619b61f38eb4'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (382, NULL, 100006, CONVERT(TEXT, N'fca206f3a75d46ed8938ff111e35b611'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (383, NULL, 100007, CONVERT(TEXT, N'f908076cacb3486ca7c0683989eaa39f'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (384, NULL, 100009, CONVERT(TEXT, N'0cd6253ca53c4753aa628994961a3098'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (385, NULL, 100004, CONVERT(TEXT, N'784e636ab7874e93906277301b129a9a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (386, NULL, 100009, CONVERT(TEXT, N'e487d05464e54c509b585bc1a577be7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (387, NULL, 100011, CONVERT(TEXT, N'1491b762233b450483731dcff348a164'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (388, NULL, 100010, CONVERT(TEXT, N'9a574fc551f146f686eded7c6f769a70'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200ADF214 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (389, NULL, 100008, CONVERT(TEXT, N'052bac93b913452897e915a270462dfb'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AE25A4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (390, NULL, 100008, CONVERT(TEXT, N'77518414904c4284915b5ca2e034f74f'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AE25A4 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (391, NULL, 100006, CONVERT(TEXT, N'a8162d5eed1643649801de57b344efcd'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF23F0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (392, NULL, 100009, CONVERT(TEXT, N'19655cb2a4b94ed79d87961c3a59dea3'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF23F0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (393, NULL, 100009, CONVERT(TEXT, N'906f6e33de07464f8b51dcb339e59060'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF23F0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (394, NULL, 100003, CONVERT(TEXT, N'e989bed3d6314ed2b1edc0e404e0b598'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF3458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (395, NULL, 100004, CONVERT(TEXT, N'eb41201527c042f2be05fee53235af60'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF3458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (396, NULL, 100005, CONVERT(TEXT, N'54457353ab574f419521430965599e7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF3458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (397, NULL, 100005, CONVERT(TEXT, N'd81d49cec2454b43ab10002a6f76d849'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF3458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (398, NULL, 100005, CONVERT(TEXT, N'c239964138d04da889ee0b40884d494d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200AF3458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (399, NULL, 100000, CONVERT(TEXT, N'9acfc16a7fde4770a59901c875f5d5b2'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (400, NULL, 100002, CONVERT(TEXT, N'752d9c17b3294917859faf142a3dec65'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (401, NULL, 100003, CONVERT(TEXT, N'e989bed3d6314ed2b1edc0e404e0b598'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (402, NULL, 100004, CONVERT(TEXT, N'784e636ab7874e93906277301b129a9a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (403, NULL, 100005, CONVERT(TEXT, N'a26f5730e6f8445ba189c2d8d751a640'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (404, NULL, 100006, CONVERT(TEXT, N'9580939e28b64bd99bd6f111d6a0e616'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (405, NULL, 100007, CONVERT(TEXT, N'5315c22f851c4d3ca439a17ecfa7d1cf'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (406, NULL, 100008, CONVERT(TEXT, N'052bac93b913452897e915a270462dfb'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (407, NULL, 100009, CONVERT(TEXT, N'19655cb2a4b94ed79d87961c3a59dea3'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (408, NULL, 100009, CONVERT(TEXT, N'e487d05464e54c509b585bc1a577be7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (409, NULL, 100009, CONVERT(TEXT, N'906f6e33de07464f8b51dcb339e59060'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (410, NULL, 100009, CONVERT(TEXT, N'dbfb48c89b494fa4acc86710bdb33811'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (411, NULL, 100010, CONVERT(TEXT, N'4eeb5c16f5684867930b19970374222d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (412, NULL, 100011, CONVERT(TEXT, N'038b2793699148ad963865c40849971e'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B4A6E0 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (413, NULL, 100000, CONVERT(TEXT, N'd16583836a6e442283570a03415bc05a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (414, NULL, 100002, CONVERT(TEXT, N'e8a53a03b06c426396d7c308350eaffd'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (415, NULL, 100003, CONVERT(TEXT, N'e989bed3d6314ed2b1edc0e404e0b598'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (416, NULL, 100004, CONVERT(TEXT, N'eb41201527c042f2be05fee53235af60'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (417, NULL, 100005, CONVERT(TEXT, N'54457353ab574f419521430965599e7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (418, NULL, 100006, CONVERT(TEXT, N'ed12b201479442dc8b03e02cffcdf666'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (419, NULL, 100006, CONVERT(TEXT, N'fca206f3a75d46ed8938ff111e35b611'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (420, NULL, 100007, CONVERT(TEXT, N'f908076cacb3486ca7c0683989eaa39f'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (421, NULL, 100008, CONVERT(TEXT, N'052bac93b913452897e915a270462dfb'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (422, NULL, 100009, CONVERT(TEXT, N'0cd6253ca53c4753aa628994961a3098'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (423, NULL, 100009, CONVERT(TEXT, N'19655cb2a4b94ed79d87961c3a59dea3'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (424, NULL, 100010, CONVERT(TEXT, N'9a574fc551f146f686eded7c6f769a70'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (425, NULL, 100011, CONVERT(TEXT, N'038b2793699148ad963865c40849971e'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A79200B52B4C AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (426, NULL, 100000, CONVERT(TEXT, N'9acfc16a7fde4770a59901c875f5d5b2'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
GO
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (427, NULL, 100002, CONVERT(TEXT, N'752d9c17b3294917859faf142a3dec65'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (428, NULL, 100003, CONVERT(TEXT, N'7af83676279847fe92c1dfba5d964f85'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (429, NULL, 100004, CONVERT(TEXT, N'726bc04302484090b8e55189ae0fc17d'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (430, NULL, 100005, CONVERT(TEXT, N'54457353ab574f419521430965599e7a'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (431, NULL, 100005, CONVERT(TEXT, N'd81d49cec2454b43ab10002a6f76d849'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (432, NULL, 100006, CONVERT(TEXT, N'ed12b201479442dc8b03e02cffcdf666'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (433, NULL, 100006, CONVERT(TEXT, N'fca206f3a75d46ed8938ff111e35b611'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (434, NULL, 100008, CONVERT(TEXT, N'052bac93b913452897e915a270462dfb'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (435, NULL, 100008, CONVERT(TEXT, N'77518414904c4284915b5ca2e034f74f'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (436, NULL, 100009, CONVERT(TEXT, N'dbfb48c89b494fa4acc86710bdb33811'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (437, NULL, 100010, CONVERT(TEXT, N'9a574fc551f146f686eded7c6f769a70'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
INSERT [dbo].[VoteInfo] ([VoteId], [PapersId], [SubjectId], [OptionId], [VoteDepict], [IPAddress], [VoteDate]) VALUES (438, NULL, 100011, CONVERT(TEXT, N'038b2793699148ad963865c40849971e'), NULL, CONVERT(TEXT, N'::1'), CAST(0x0000A797009C7458 AS DateTime))
SET IDENTITY_INSERT [dbo].[VoteInfo] OFF
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'1-单选 2-多选 3-文本' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubjectInfo', @level2type=N'COLUMN',@level2name=N'SubjectType'
GO
