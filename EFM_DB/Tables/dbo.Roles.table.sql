/******************************************************************
角色表 

******************************************************************/

CREATE TABLE [dbo].[roles]
(
	[id]	[BIGINT] IDENTITY(1,1) NOT NULL,	/**[Roles]表标识列，主键，自动递增**/
	[rid]	[NVARCHAR](255) NOT NULL DEFAULT ABS(CHECKSUM(NEWID())),			/**角色唯一标识**/
	[name]	[NVARCHAR](255) NOT NULL,			/**角色名称**/
	[desc]	[NVARCHAR](255) NULL,				/**描述**/
	[state]	[INT] NOT NULL DEFAULT 0,			/**启用状态，0：禁用，1：启用**/
	[isdel] [BIT] NOT NULL DEFAULT 0,			/**删除标记**/

	CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	), 
	CONSTRAINT [AK_ROLES_RID] UNIQUE NONCLUSTERED 
	(
		[rid] ASC
	), 
	CONSTRAINT [AK_ROLES_NAME] UNIQUE NONCLUSTERED 
	(
		[name] ASC
	)  
	WITH 
	(
		PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON
	) ON [PRIMARY]
) ON [PRIMARY]

GO