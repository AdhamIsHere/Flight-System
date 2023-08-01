/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/22/2023 12:14:59 AM                        */
/*==============================================================*/


if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_AIRCRAFT')
          and type = 'TR')
   drop trigger CLR_TRIGGER_AIRCRAFT
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_AIRPORT')
          and type = 'TR')
   drop trigger CLR_TRIGGER_AIRPORT
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_FLIGHT')
          and type = 'TR')
   drop trigger CLR_TRIGGER_FLIGHT
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_RESERVATION')
          and type = 'TR')
   drop trigger CLR_TRIGGER_RESERVATION
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_TICKET')
          and type = 'TR')
   drop trigger CLR_TRIGGER_TICKET
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_USER')
          and type = 'TR')
   drop trigger CLR_TRIGGER_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_DONE_BY_AIRCRAFT')
alter table FLIGHT
   drop constraint FK_FLIGHT_DONE_BY_AIRCRAFT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_FROM_AIRPORT')
alter table FLIGHT
   drop constraint FK_FLIGHT_FROM_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_TO_AIRPORT')
alter table FLIGHT
   drop constraint FK_FLIGHT_TO_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVATION') and o.name = 'FK_RESERVAT_SYSTEM_RE_TICKET')
alter table RESERVATION
   drop constraint FK_RESERVAT_SYSTEM_RE_TICKET
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVATION') and o.name = 'FK_RESERVAT_USER_RESE_USER')
alter table RESERVATION
   drop constraint FK_RESERVAT_USER_RESE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_TICKET_FO_FLIGHT')
alter table TICKET
   drop constraint FK_TICKET_TICKET_FO_FLIGHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFT')
            and   type = 'U')
   drop table AIRCRAFT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRPORT')
            and   type = 'U')
   drop table AIRPORT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHT')
            and   type = 'U')
   drop table FLIGHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVATION')
            and   type = 'U')
   drop table RESERVATION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TICKET')
            and   type = 'U')
   drop table TICKET
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

/*==============================================================*/
/* Table: AIRCRAFT                                              */
/*==============================================================*/
create table AIRCRAFT (
   ID                   int                  identity(1,1) not for replication,
   TYPE                 varchar(50)          null,
   MODEL                varchar(50)          null,
   CAPACITY             int                  null,
   constraint PK_AIRCRAFT primary key (ID)
)
go

/*==============================================================*/
/* Table: AIRPORT                                               */
/*==============================================================*/
create table AIRPORT (
   ID                   int                  identity(1,1) not for replication,
   NAME                 varchar(50)          null,
   COUNTRY              varchar(50)          null,
   CITY                 varchar(50)          null,
   constraint PK_AIRPORT primary key (ID)
)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table FLIGHT (
   ID                   int                  identity(1,1) not for replication,
   AIRPORT_SOURCE       int                  null,
   AIRPORT_DESTINATION  int                  null,
   AIRCRAFT_ID          int                  null,
   ARRIVAL              datetime             null,
   DEPARTURE            datetime             null,
   constraint PK_FLIGHT primary key (ID)
)
go

/*==============================================================*/
/* Table: RESERVATION                                           */
/*==============================================================*/
create table RESERVATION (
   TICKET_ID            int                  not null,
   USER_ID              int                  not null,
   constraint PK_RESERVATION primary key (TICKET_ID, USER_ID)
)
go

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET (
   ID                   int                  identity(1,1) not for replication,
   FLIGHT_ID            int                  null,
   CLASS                varchar(20)          null,
   PRICE                float                null,
   constraint PK_TICKET primary key (ID)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   ID                   int                  identity(1,1) not for replication,
   NAME                 varchar(50)          not null,
   COUNTRY              varchar(50)          not null,
   CITY                 varchar(50)          not null,
   STREET               varchar(50)          not null,
   EMAIL                varchar(50)          not null,
   PASSWORD             varchar(50)          not null,
   PHONE                varchar(50)          not null,
   ADMIN                bit                  null default 0,
   constraint PK_USER primary key (ID)
)
go

alter table FLIGHT
   add constraint FK_FLIGHT_DONE_BY_AIRCRAFT foreign key (AIRCRAFT_ID)
      references AIRCRAFT (ID)
go

alter table FLIGHT
   add constraint FK_FLIGHT_FROM_AIRPORT foreign key (AIRPORT_SOURCE)
      references AIRPORT (ID)
go

alter table FLIGHT
   add constraint FK_FLIGHT_TO_AIRPORT foreign key (AIRPORT_DESTINATION)
      references AIRPORT (ID)
go

alter table RESERVATION
   add constraint FK_RESERVAT_SYSTEM_RE_TICKET foreign key (TICKET_ID)
      references TICKET (ID)
go

alter table RESERVATION
   add constraint FK_RESERVAT_USER_RESE_USER foreign key (USER_ID)
      references "USER" (ID)
go

alter table TICKET
   add constraint FK_TICKET_TICKET_FO_FLIGHT foreign key (FLIGHT_ID)
      references FLIGHT (ID)

-- Populating USER table
INSERT INTO "USER" (NAME, COUNTRY, CITY, STREET, EMAIL, PASSWORD, PHONE, ADMIN)
VALUES 
   ('John Doe', 'United States', 'New York', '123 Main St', 'johndoe@example.com', 'pass123', '1234567890', 0),
   ('Jane Smith', 'United Kingdom', 'London', '456 Park Ave', 'janesmith@example.com', 'pass456', '0987654321', 0),
   ('David Lee', 'Singapore', 'Singapore', '789 Orchard Rd', 'davidlee@example.com', 'pass789', '9876543210', 1),
   ('Michael Johnson', 'Canada', 'Toronto', '567 Maple St', 'michaeljohnson@example.com', 'pass567', '8765432109', 0),
   ('Emily Wilson', 'Australia', 'Sydney', '890 Oak Ave', 'emilywilson@example.com', 'pass890', '7654321098', 0),
   ('Alexandra Brown', 'Germany', 'Berlin', '345 Pine St', 'alexandrabrown@example.com', 'pass345', '6543210987', 0),
   ('Daniel Kim', 'South Korea', 'Seoul', '678 Elm Ave', 'danielkim@example.com', 'pass678', '5432109876', 0),
   ('Sophia Chen', 'China', 'Shanghai', '901 Cedar St', 'sophiachen@example.com', 'pass901', '4321098765', 0),
   ('Benjamin Liu', 'Japan', 'Tokyo', '234 Spruce St', 'benjaminliu@example.com', 'pass234', '3210987654', 0),
   ('Olivia Garcia', 'Brazil', 'Rio de Janeiro', '567 Birch Ave', 'oliviagarcia@example.com', 'pass567', '2109876543', 0);

-- Populating AIRCRAFT table
INSERT INTO AIRCRAFT (TYPE, MODEL, CAPACITY)
VALUES 
   ('Boeing 747', '747-400', 416),
   ('Airbus A320', 'A320-200', 180),
   ('Embraer E175', 'E175', 76),
   ('Boeing 777', '777-300ER', 396),
   ('Airbus A380', 'A380-800', 853),
   ('Cessna 172', '172 Skyhawk', 4),
   ('Bombardier Challenger 300', 'CL-30', 9),
   ('Gulfstream G650', 'G650', 19),
   ('Dassault Falcon 7X', 'Falcon 7X', 14),
   ('Cessna Citation CJ4', 'CJ4', 10);

-- Populating AIRPORT table
INSERT INTO AIRPORT (NAME, COUNTRY, CITY)
VALUES 
   ('John F. Kennedy International Airport', 'United States', 'New York'),
   ('Heathrow Airport', 'United Kingdom', 'London'),
   ('Changi Airport', 'Singapore', 'Singapore'),
   ('Toronto Pearson International Airport', 'Canada', 'Toronto'),
   ('Sydney Airport', 'Australia', 'Sydney'),
   ('Berlin Brandenburg Airport', 'Germany', 'Berlin'),
   ('Incheon International Airport', 'South Korea', 'Seoul'),
   ('Shanghai Pudong International Airport', 'China', 'Shanghai'),
   ('Tokyo Haneda Airport', 'Japan', 'Tokyo'),
   ('Galeão International Airport', 'Brazil', 'Rio de Janeiro');

-- Populating FLIGHT table
INSERT INTO FLIGHT (AIRPORT_SOURCE, AIRPORT_DESTINATION, AIRCRAFT_ID, ARRIVAL, DEPARTURE)
VALUES 
   (1, 2, 1, '2023-05-22 08:00:00', '2023-05-22 10:00:00'),
   (2, 3, 2, '2023-05-22 11:00:00', '2023-05-22 13:00:00'),
   (1, 3, 3, '2023-05-22 14:00:00', '2023-05-22 16:00:00'),
   (3, 4, 4, '2023-05-22 17:00:00', '2023-05-22 19:00:00'),
   (4, 5, 5, '2023-05-22 20:00:00', '2023-05-22 22:00:00'),
   (5, 6, 6, '2023-05-22 09:00:00', '2023-05-22 11:00:00'),
   (6, 7, 7, '2023-05-22 12:00:00', '2023-05-22 14:00:00'),
   (7, 8, 8, '2023-05-22 15:00:00', '2023-05-22 17:00:00'),
   (8, 9, 9, '2023-05-22 18:00:00', '2023-05-22 20:00:00'),
   (9, 10, 10, '2023-05-22 21:00:00', '2023-05-22 23:00:00');

-- Populating TICKET table
INSERT INTO TICKET (FLIGHT_ID, CLASS, PRICE)
VALUES 
   (1, 'Economy', 249.99),
   (2, 'Business', 599.99),
   (3, 'First Class', 899.99),
   (4, 'Economy', 199.99),
   (5, 'Business', 549.99),
   (6, 'First Class', 999.99),
   (7, 'Economy', 149.99),
   (8, 'Business', 699.99),
   (9, 'First Class', 1099.99),
   (10, 'Economy', 179.99);

-- Populating RESERVATION table
INSERT INTO RESERVATION (TICKET_ID, USER_ID)
VALUES 
   (1, 1),
   (2, 2),
   (3, 3),
   (4, 4),
   (5, 5),
   (6, 6),
   (7, 7),
   (8, 8),
   (9, 9),
   (10, 10);


