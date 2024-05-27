SELECT name 
FROM sys.databases;

USE AcademicAssistant;
GO

SELECT * 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE';

SELECT 
    *
FROM 
    INFORMATION_SCHEMA.COLUMNS
WHERE 
    TABLE_SCHEMA = 'dbo';


-- SELECT TOP 100 * FROM YourTableName;
DECLARE @TableName NVARCHAR(MAX)
DECLARE @SQLQuery NVARCHAR(MAX)

DECLARE table_cursor CURSOR FOR 
    SELECT TABLE_NAME
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_TYPE = 'BASE TABLE'

OPEN table_cursor
FETCH NEXT FROM table_cursor INTO @TableName

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @SQLQuery = 'SELECT * FROM ' + QUOTENAME(@TableName)
    EXEC sp_executesql @SQLQuery

    FETCH NEXT FROM table_cursor INTO @TableName
END

CLOSE table_cursor
DEALLOCATE table_cursor

