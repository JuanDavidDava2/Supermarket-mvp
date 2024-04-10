use Supermarker

create table PayMode

(
Pay_Mode_id int identity (100000, 1) primary key,
Pay_Mode_Name nvarchar (50) not null,
Pay_mode_Observation nvarchar (50) not null,
)

go
insert into PayMode values ('Cash', 'Cash mode')
insert into PayMode values ('Credit card','Credit card mode')