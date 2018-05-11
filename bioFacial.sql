CREATE DATABASE bioFacial
GO
USE bioFacial
GO
CREATE TABLE usuario(
codigo int IDENTITY(1,1) PRIMARY KEY,
nombre varchar(50) NOT NULL,
rostro image,
cedula varchar(15) NOT NULL,
rol varchar(1) CHECK (rol IN('U','A'))
)
GO
CREATE TABLE admon(
cedula varchar(15) PRIMARY KEY,
pregunta varchar(50),
respuesta varchar(50),
clave varchar(5) NOT NULL
)
GO

CREATE PROCEDURE SP_datosUsuarios
AS
BEGIN
	SELECT rostro,cedula
	FROM usuario
END	
GO

CREATE PROCEDURE SP_rostroDetectado
@cedula varchar(15)
AS
BEGIN
	SELECT nombre,rol
	FROM usuario
	WHERE cedula = @cedula
END	
GO

CREATE PROCEDURE SP_loginAdmin
@cedula varchar(15)
AS
BEGIN
	SELECT clave FROM admon 
	WHERE cedula = @cedula
END
GO

CREATE VIEW VW_Usuarios
	AS
	SELECT cedula,rostro 
	FROM usuario
GO

SELECT * FROM usuario