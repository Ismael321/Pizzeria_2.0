create database Pizza;

use Pizza;

create table usuarios(
			id_cliente int not null primary key identity(1,1),
			nombre varchar(30),
			contrasena varchar(30),
			t_usuario varchar(15)
			)

insert usuarios(nombre , contrasena ,t_usuario )
values('Ismael' , '2111' ,'administrador' )
insert usuarios(nombre , contrasena ,t_usuario )
values('Jose' , '2116' ,'usuario' )


select *from usuarios;
drop table usuarios;

CREATE TABLE Empleados(
    Nombre varchar(25) NULL DEFAULT (NULL),
    Apellido_Paterno varchar(25) NULL DEFAULT (NULL),
    Apellido_Materno varchar(25) NULL DEFAULT (NULL),
    Id_Empleado int IDENTITY(100,1) NOT NULL primary key,
    Telefono bigint NULL DEFAULT (NULL),
    CURP varchar(25) NULL DEFAULT (NULL),
    NSS bigint NULL DEFAULT (NULL),
    Salario int NULL DEFAULT (NULL),
    Fecha_Ingreso date NULL DEFAULT (NULL)
    );

	SELECT *FROM Empleados;