USE Pizza;

UPDATE dbo.usuarios
SET t_usuario = 'Gerente'
WHERE contrasena = 2111;


SELECT *FROM dbo.usuarios;