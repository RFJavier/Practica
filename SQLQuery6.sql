
create database pruebat21
go
use pruebat21

go

create table [dbo].[usuario](
[Id] [int] PRIMARY KEY IDENTITY (1,1) NOT NULL,
[IdRol][int] NOT NULL,
[Nombre] [varchar] (30) NOT NULL,
[Apellido] [varchar] (30) NOT NULL,
[Login] [varchar] (25) NOT NULL,
[Password] [varchar] (32) NOT NULL,
[Estatus] [tinyint] NOT NULL,
[FechaRegistro] [datetime] NOT NULL,
CONSTRAINT FK1_Rol_Usuario FOREIGN KEY (Id) REFERENCES Usuario (Id)
);

CREATE TABLE [dbo].[Rol](
[Id] [int] PRIMARY KEY IDENTITY (1,1) NOT NULL,
[Nombre] [varchar] (30) NOT NULL,
CONSTRAINT FK1_Usuario_Rol FOREIGN KEY (Id) REFERENCES Rol (Id)
);






