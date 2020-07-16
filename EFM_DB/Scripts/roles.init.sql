

USE [efmdb]
GO
SET IDENTITY_INSERT [dbo].[roles] ON 
GO

INSERT [dbo].[roles] ([id], [rid], [name], [desc], [state]) VALUES (0, ABS(CHECKSUM(N'DEFAULT_USER')), N'普通用户', N'普通用户，系统创建', 1)
GO

SET IDENTITY_INSERT [dbo].[roles] OFF
GO
