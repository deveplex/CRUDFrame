﻿/*
后期部署脚本模板							
--------------------------------------------------------------------------------------
 此文件包含将附加到生成脚本中的 SQL 语句。		
 使用 SQLCMD 语法将文件包含到后期部署脚本中。			
 示例:      :r .\myfile.sql								
 使用 SQLCMD 语法引用后期部署脚本中的变量。		
 示例:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
/*********************************************************************************************
*******注意：除非第一次新建数据库，否则请避免IDE直接部署，推荐注释":r"开头语句避免误操作******
**********************************************************************************************/

--:setvar UADB USSAID

----:setvar serverName VIDEO-PC

SET NOCOUNT ON

PRINT '正在初始化数据库，请稍后...'
--:r .\init.usergrant.sql

PRINT '正在初始化角色数据，请稍后...'
:r .\roles.init.sql

PRINT '正在初始化角色数据，请稍后...'
:r .\accounts.init.sql

SET NOCOUNT OFF
