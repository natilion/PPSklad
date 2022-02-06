create database [Sklad]
go

use [Sklad] 
go

create table [dbo].[Item]
(
	[ID_Item] [int] not null identity (1,1),
	[Name_Item] [varchar] (50) not null,
	[Specification_Item] [varchar] (max) not null,
	[About_Item] [varchar] (max) not null,
	constraint [PK_Item] primary key clustered
	([ID_Item] ASC) on [PRIMARY],

	[User_ID] [int] null, 
	constraint [FK_Item_User] foreign key ([User_ID])
	references [dbo].[User] ([ID_User])
)
go

create table [dbo].[User]
(
	[ID_User] [int] not null identity (1,1),
	[Name_User] [varchar] (30) not null,
	[Last_Name_User] [varchar] (30) not null,
	[Login] [varchar] (30) not null,
	[Password] [varchar] (max) not null,
	[Role] [int] not null,
	constraint [PK_User] primary key clustered
	([ID_User] ASC) on [PRIMARY]
)
go

insert into [dbo].[User]([Name_User],[Last_Name_User],[Login],[Password],[Role])
values('Фамилия', 'Имя', 'Admin', 'Admin', 1)

insert into [dbo].[Item]([Name_Item],[Specification_Item],[About_Item],[User_ID])
values('jfoew', 'vjiejvioerjvieorjvioejvoier', 'vewvewhvueirhvioeiovrjeiuvhueirhvuievre', 1)
select * from dbo.[Item]

insert into [dbo].[User]([Name_User],[Last_Name_User],[Login],[Password],[Role])
values('Кирилл', 'Кириллин', 'Kir', 'Kir', 1)

update [dbo].[User] set [Name_User]='Михаил',[Last_Name_User]='Малов',[Login]='Admin',[Password]='Admin',[Role]=0
	where 
		[ID_User] = 2

select * from dbo.[User]

select [Name_User], [Last_Name_User], [Login], [Password], [Role] from dbo.[User] 
where [Name_User] LIKE '%М%' or 
[Last_Name_User] LIKE '%М%' or
[Login] LIKE '%М%' or
[Password] LIKE '%М%' or
[Role] LIKE '%М%'