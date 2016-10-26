CREATE SCHEMA Monster;
GO

CREATE TABLE Monster.Monster
(
    MonsterId int not null IDENTITY(1,1)
    ,GenderId int null 
    ,TitleId int null
    ,TypeId int not null
    ,Name nvarchar(250) not null
    ,Picture nvarchar(256) null
    ,Active bit not null 
);
GO

CREATE TABLE Monster.MonsterType
(
    MonsterTypeId int not null IDENTITY(1,1) primary key
    ,TypeName nvarchar(250) not null
    ,Active bit not null
);
GO

CREATE TABLE Monster.Gender
(
    GenderId int not null IDENTITY(1,1) primary key
    ,GenderName nvarchar(250) not null
    ,Active bit not null
);
GO

CREATE TABLE Monster.Title
(
    TitleId int not null IDENTITY(1,1) primary key
    ,TitleName nvarchar(250) not null
    ,Active bit not null
);
GO


ALTER TABLE Monster.Monster
    ADD CONSTRAINT pk_monster_monsterid primary key clustered (MonsterId);
GO

ALTER TABLE Monster.Monster
    ADD CONSTRAINT fk_monster_genderid FOREIGN KEY (GenderId) references Monster.Gender (GenderId); 
GO

ALTER TABLE Monster.Monster
    ADD CONSTRAINT fk_monster_titleid FOREIGN KEY (TitleId) references Monster.Title (TitleId);
GO

ALTER TABLE Monster.Monster
    ADD CONSTRAINT fk_monster_typeid FOREIGN KEY (TypeId) references Monster.MonsterType (MonsterTypeId); 
GO
