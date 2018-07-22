create database I_M_S;
create table Items (I_ID int identity(1,1),I_name varchar (50),I_QTY int,ITP numeric,IRT numeric,primary key(I_ID));
insert into Items(I_name,I_QTY,ITP,IRT)values('Chocolate ice cream','10','500','600');
insert into Items(I_name,I_QTY,ITP,IRT)values('Vanilla ice cream','10','500','600');
insert into Items(I_name,I_QTY,ITP,IRT)values('Stawberry ice cream','09','550','600');
insert into Items(I_name,I_QTY,ITP,IRT)values('Pista ice cream','15','600','650');
insert into Items(I_name,I_QTY,ITP,IRT)values('Kulfa ice cream','10','400','500');
select * from Items;
create table vendors(VID int identity (1,1),VName varchar(50),VPNO int,VCMP varchar(50),VAdd varchar (50),VEmail varchar(50),primary key(VID));
insert into vendors (VName,VPNO,VCMP,VAdd,VEmail)values ('Ali','051643876','Alis Ice Cream Parlor','Islamabad','Ali@gmail.com');
insert into vendors (VName,VPNO,VCMP,VAdd,VEmail)values ('Usman','042875454','Usmans Ice Cream Parlor','Lahore','Usman@gmail.com');
insert into vendors (VName,VPNO,VCMP,VAdd,VEmail)values ('Zain','021357640','Zains Ice Cream Parlor','Karachi','Zain@gmail.com');
insert into vendors (VName,VPNO,VCMP,VAdd,VEmail)values ('Usama','032615288','Usamas Ice Cream Parlor','Multan','Usama@gmail.com');
insert into vendors (VName,VPNO,VCMP,VAdd,VEmail)values ('Razzak','030287352','Razzaks Ice Cream Parlor','Hunza','Razzak@gmail.com');
select * from vendors;

create table Cutomer(CID int identity (1,1),CName varchar(50),CPNO int,CAdd varchar (50),CEmail varchar(50),primary key(CID));
insert into Cutomer(CName,CPNO,CAdd,CEmail)values ('Waqar','051643876','Islamabad','Waqar@gmail.com');
insert into Cutomer(CName,CPNO,CAdd,CEmail)values ('Qasim','042875454','Lahore','Qasim@gmail.com');
insert into Cutomer(CName,CPNO,CAdd,CEmail)values ('Asma','021357640','Karachi','Asma@gmail.com');
insert into Cutomer(CName,CPNO,CAdd,CEmail)values ('Ishrat','032615288','Multan','Ishrat@gmail.com');
insert into Cutomer(CName,CPNO,CAdd,CEmail)values ('Naila','030287352','Hunza','Naila@gmail.com');
select * from Cutomer;

create table Purchase (PID int identity(1,1),PR_ID int,VID int,QTY int,Price numeric);
insert into Purchase();
select * from Purchase;