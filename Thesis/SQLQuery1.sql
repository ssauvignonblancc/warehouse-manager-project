use Арамей
create table Клиент
(
IDКлиента int identity not null,
IDАдресСклада int not null,
ФИО nvarchar(50) not null,
НомерТелефона int not null,
--constraint IDАдреса primary key (IDАдресСклада),
--constraint IDКлиента foreign key (IDКлиента) references Техника (IDТехника)
)

select * from Клиент
drop table Клиент
--------------------------------------------------------
create table АдресСклада
(
IDАдресСкладаВнеш int identity not null,
Улица nvarchar(50) not null,
НомерСклада Int not null
--constraint IDАдресСкладаВнеш foreign key (IDАдресСкладаВнеш) references Клиент (IDАдресСклада)
)

select * from АдресСклада
drop table АдресСклада
--------------------------------------------------------
create table Приемщик
(
IDПриемщик int identity not null,
ФИО nvarchar(50) not null,
ВремяРаботы int not null,
Должность nvarchar(50) not null,
СтажРаботы int not null
--constraint IDПриемщик foreign key (IDПриемщик) references Техника (IDТехника)
)

select * from Приемщик
drop table Приемщик
--------------------------------------------------------
create table Техника
(
IDТехника int identity not null,
Название nvarchar(50) not null,
Стоимость money not null,
ВремяЗаписи datetime default(getdate()) null,
Поставщик nvarchar(50) not null,
Количество int not null
--constraint IDМастераВнеш foreign key (IDПриемщикВнеш) references ИсторияПоставок (IDИсторияВнеш),
--constraint IDТехника primary key (IDТехника)
)

select * from Техника
drop table Техника
--------------------------------------------------------
create table ИсторияПоставок
(
IDИсторияВнеш int identity not null,
Название nvarchar(50) not null,
Стоимость money not null,
ВремяЗаписи datetime not null,
Поставщик nvarchar(50) not null,
Количество int not null
--constraint IDИсторияВнеш primary key (IDИсторияВнеш)
)

select * from ИсторияПоставок
drop table ИсторияПоставок

select * from ИсторияПоставок where ВремяЗаписи >= '2020-01-10' and ВремяЗаписи < '2022-09-02'
--------------------------------------------------------
create table Поставщик
(
IDПоставщик int identity not null,
Название nvarchar(50) not null,
ВидТехники nvarchar(50) not null,
Адрес nvarchar(50) not null,
НомерТелефона int not null 
--constraint IDИсторияВнеш primary key (IDИсторияВнеш)
)

select * from Поставщик
drop table Поставщик
--------------------------------------------------------
create table Sold
(
IDТовара int identity not null,
Название nvarchar(50) not null,
Стоимость money not null,
ВремяЗаписи datetime not null,
Поставщик nvarchar(50) not null,
Количество int not null
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
insert into Техника (IDПриемщикВнеш, IDКлиента, Название, Стоимость, ВремяЗаписи, Поставщик, Количество) values (1,1, 'Пылесос', 235.32, '2021/09/01', 'LG', 123)
insert into Приемщик (ФИО, ВремяРаботы, Должность, СтажРаботы) values ('Сачивко Максим Сергеевич', 10, 'Старший', 5)
insert into Поставщик(Название, ВидТехники, Адрес, НомерТелефона) values ('ASUS', 'Микроволновка', 'Тухачевского 43', 298659526)
--------------------------------------------------------

update Техника set Количество = Количество - 50 where Стоимость = 123.123

go
create procedure Product AS 
select Название as Стоимость, ВремяЗаписи
from Техника

go
create procedure Postav AS 
select Название as Название
from Поставщик

go
create procedure Priem AS 
select ФИО as ВремяРаботы, Должность, СтажРаботы
from Приемщик

exec Product
drop procedure Product

exec Postav
drop procedure Postav

exec Priem
drop procedure Priem