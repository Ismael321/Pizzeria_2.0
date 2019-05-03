use Pizza;

CREATE TABLE [dbo].[Empleados](
    [Nombre] [varchar](25) NULL DEFAULT (NULL),
    [Apellido_Paterno] [varchar](25) NULL DEFAULT (NULL),
    [Apellido_Materno] [varchar](25) NULL DEFAULT (NULL),
    [Id_Empleado] [int] IDENTITY(100,1) NOT NULL primary key,
    [Telefono] [bigint] NULL DEFAULT (NULL),
    [CURP] [varchar](25) NULL DEFAULT (NULL),
    [NSS] [bigint] NULL DEFAULT (NULL),
    [Salario] [int] NULL DEFAULT (NULL),
    [Fecha_Ingreso] [date] NULL DEFAULT (NULL)
    );

	SELECT *FROM dbo.Empleados;