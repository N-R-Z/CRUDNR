CREATE DATABASE CRUDNR
USE CRUDNR		

CREATE TABLE usuarios(
Id int identity(1,1) primary key,
Nombre varchar(50),
Fecha date,
Clave varchar(50)
)

select * from usuarios