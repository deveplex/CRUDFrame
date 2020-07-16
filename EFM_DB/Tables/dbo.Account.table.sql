/******************************************************************
帐户表 

******************************************************************/

CREATE TABLE [dbo].[uac]
(
	[id]	[BIGINT] IDENTITY(1,1) NOT NULL,	/**[Account]表标识列，主键，自动递增**/
	[sgid]	[NVARCHAR](255) NOT NULL DEFAULT REPLACE(LTRIM(RTRIM(NEWID())),'-',''),	/**Account唯一标识**/
	[suid]	[NVARCHAR](255) NULL,		/**用户登录标识，注册时填写**/
	[veml]	[NVARCHAR](255) NULL,		/**绑定邮箱地址，用于身份验证，不对外公开，默认为空值**/
	[vmbl]	[NVARCHAR](255) NULL,		/**绑定手机号码，用于身份验证，不对外公开，默认为空值**/
	[type]	[INT] NOT NULL DEFAULT(0),	/**用户类型，0为个人，1为企业**/
	[state]  [INT] NOT NULL DEFAULT(0),	/**帐户启用状态，0为正常，1为禁用**/
	[crdt]	[DATETIME] NOT NULL DEFAULT(GETDATE()),/**帐户注册时间**/
	[hashkey] [NVARCHAR](255) NULL,	/**摘要签名**/
	[isdel] [BIT] NOT NULL DEFAULT(0),	/**删除标记**/

	CONSTRAINT [PK_ACCOUNT] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	), 
	CONSTRAINT [AK_ACCOUNT_SGID] UNIQUE NONCLUSTERED 
	(
		[sgid] ASC
	), 
	CONSTRAINT [AK_ACCOUNT_SUID] UNIQUE NONCLUSTERED 
	(
		[suid] ASC
	)  
	WITH 
	(
		PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON
	) ON [PRIMARY]
) ON [PRIMARY]

GO