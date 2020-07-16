/******************************************************************
帐户密码表 

******************************************************************/

CREATE TABLE [dbo].[crypt]
(
	[id]	[BIGINT] IDENTITY(1,1) NOT NULL,	/**[Cryptography]表标识列，主键，自动递增**/
    [fk_sgid] [NVARCHAR](255) NOT NULL,		/**关联[Account] 唯一标识，外键关联**/
	[pswd]	[NVARCHAR](500) NOT NULL,	/**用户登录密码，注册时填写**/
	[fmat]	[INT] NOT NULL DEFAULT(0),	/**加密类型，0为MD5，1为DES，2为AES，3为SHA**/
	[key]	[NVARCHAR](255) NULL,	/**密钥**/
	[hashkey] [NVARCHAR](255) NULL,	/**摘要签名**/

	CONSTRAINT [PK_CRYPTOGRAPHY] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	), 
	CONSTRAINT [AK_CRYPTOGRAPHY] UNIQUE NONCLUSTERED 
	(
		[fk_sgid] ASC
	) 
	WITH 
	(
		PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON
	) ON [PRIMARY]
) ON [PRIMARY]

GO