

USE [efmdb]
GO
SET IDENTITY_INSERT [dbo].[uac] ON 
GO

DECLARE @sgid NVARCHAR(255)

DECLARE @TableVar TABLE(
  sgid     NVARCHAR(255) NULL
);

INSERT [dbo].[uac] ([id], [suid])
OUTPUT Inserted.sgid
INTO @TableVar
VALUES (-1024, N'admin')

SELECT @sgid=sgid FROM @TableVar

INSERT [dbo].[userrole] ([fk_sgid], [fk_rid]) VALUES (@sgid, ABS(CHECKSUM(N'SUPPER_ADMIN')))

SET IDENTITY_INSERT [dbo].[uac] OFF
GO
