CREATE DATABASE LibrosDb
GO
USE LibrosDb
GO
CREATE TaBLE Libros
(
Id int primary key identity,
Nombre varchar (30),
Descricion varchar (40),
Siglas varchar(10),
Tipo varchar (20)
)

