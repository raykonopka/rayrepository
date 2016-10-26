USE MASTER;
GO

IF (DB_ID(N'MonsterDB') is not null)
BEGIN
	DROP DATABASE MonsterDB;
END;
GO

CREATE DATABASE MonsterDB;
GO

USE MonsterDB;
GO

IF (SCHEMA_ID(N'Monster') is not null)
BEGIN
	DROP SCHEMA Monster;
END;
GO


