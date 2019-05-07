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

create Table Pedidos(
TipoPizza varchar(40),
NumeroPedido integer identity(1,1) primary key,
TamanoPizza varchar(40),
Ingrediente1 varchar(40),
Ingrediente2 varchar(40),
Ingrediente3 varchar(40),
Ingrediente4 varchar(40),
SaborRefresco varchar(40),
TamanoRefresco varchar(40),
CantidadRefresco varchar(40)
);

create table Factura(
Nombre varchar(40),
IdFactura integer identity (110,1) primary key,
Domicilio varchar(45),
Num_Dom varchar(15),
Calle1 varchar(40),
Calle2 varchar(40),
Comentarios varchar(120),
CostoTotal integer
);