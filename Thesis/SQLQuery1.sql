use ������
create table ������
(
ID������� int identity not null,
ID����������� int not null,
��� nvarchar(50) not null,
������������� int not null,
--constraint ID������ primary key (ID�����������),
--constraint ID������� foreign key (ID�������) references ������� (ID�������)
)

select * from ������
drop table ������
--------------------------------------------------------
create table �����������
(
ID��������������� int identity not null,
����� nvarchar(50) not null,
����������� Int not null
--constraint ID��������������� foreign key (ID���������������) references ������ (ID�����������)
)

select * from �����������
drop table �����������
--------------------------------------------------------
create table ��������
(
ID�������� int identity not null,
��� nvarchar(50) not null,
����������� int not null,
��������� nvarchar(50) not null,
���������� int not null
--constraint ID�������� foreign key (ID��������) references ������� (ID�������)
)

select * from ��������
drop table ��������
--------------------------------------------------------
create table �������
(
ID������� int identity not null,
�������� nvarchar(50) not null,
��������� money not null,
����������� datetime default(getdate()) null,
��������� nvarchar(50) not null,
���������� int not null
--constraint ID����������� foreign key (ID������������) references ��������������� (ID�����������),
--constraint ID������� primary key (ID�������)
)

select * from �������
drop table �������
--------------------------------------------------------
create table ���������������
(
ID����������� int identity not null,
�������� nvarchar(50) not null,
��������� money not null,
����������� datetime not null,
��������� nvarchar(50) not null,
���������� int not null
--constraint ID����������� primary key (ID�����������)
)

select * from ���������������
drop table ���������������

select * from ��������������� where ����������� >= '2020-01-10' and ����������� < '2022-09-02'
--------------------------------------------------------
create table ���������
(
ID��������� int identity not null,
�������� nvarchar(50) not null,
���������� nvarchar(50) not null,
����� nvarchar(50) not null,
������������� int not null 
--constraint ID����������� primary key (ID�����������)
)

select * from ���������
drop table ���������
--------------------------------------------------------
create table Sold
(
ID������ int identity not null,
�������� nvarchar(50) not null,
��������� money not null,
����������� datetime not null,
��������� nvarchar(50) not null,
���������� int not null
)

select * from Sold
drop table Sold
--------------------------------------------------------
create table register
(
id_user int identity(1,1) not null,
login_user varchar(50) not null,
password_user varchar(50) not null
);

insert into register (login_user, password_user) values ('admin', 'admin')

select * from register
drop table register

--------------------------------------------------------
insert into ������� (ID������������, ID�������, ��������, ���������, �����������, ���������, ����������) values (1,1, '�������', 235.32, '2021/09/01', 'LG', 123)
insert into �������� (���, �����������, ���������, ����������) values ('������� ������ ���������', 10, '�������', 5)
insert into ���������(��������, ����������, �����, �������������) values ('ASUS', '�������������', '������������ 43', 298659526)
--------------------------------------------------------

update ������� set ���������� = ���������� - 50 where ��������� = 123.123

go
create procedure Product AS 
select �������� as ���������, �����������
from �������

go
create procedure Postav AS 
select �������� as ��������
from ���������

go
create procedure Priem AS 
select ��� as �����������, ���������, ����������
from ��������

exec Product
drop procedure Product

exec Postav
drop procedure Postav

exec Priem
drop procedure Priem