CREATE TABLE [dbo].[userrole]
(
	[id]	[BIGINT] IDENTITY(1,1) NOT NULL,	/**[AccountToRole]表标识列，主键，自动递增**/
    [fk_sgid] [NVARCHAR](255) NOT NULL,		/**关联[Account] 唯一标识，外键关联**/
    [fk_rid] [NVARCHAR](255) NOT NULL,		/**关联[Roles] 角色唯一标识，外键关联**/

	CONSTRAINT [PK_USERROLE] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	), 
	CONSTRAINT [AK_USERROLE] UNIQUE NONCLUSTERED 
	(
		[fk_sgid] ASC
	)  
	WITH 
	(
		PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON
	) ON [PRIMARY]
) ON [PRIMARY]

GO