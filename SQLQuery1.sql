use Supermarker

create table PayMode

(
Pay_Mode_Id int identity (100000, 1) primary key,
Pay_Mode_Name nvarchar (50) not null,
Pay_mode_Observation nvarchar (50) not null,
)

go
insert into PayMode values ('Cash', 'Cash mode')
insert into PayMode values ('Credit card','Credit card mode')




SELECT * FROM PayMode WHERE 
Pay_Mode_id=@id or 
Pay_Mode_Name LIKE @name+ '%' 

ORDER By Pay_Mode_id DESC