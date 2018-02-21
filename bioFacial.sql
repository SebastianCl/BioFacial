CREATE DATABASE bioFacial
GO
USE bioFacial
GO

CREATE TABLE usuario(
codigo int IDENTITY(1,1) PRIMARY KEY,
nombre varchar(50),
rostro image,
cedula varchar(15),
rol varchar(1) CHECK (rol IN('U','A'))
)
GO
CREATE TABLE admon(
cedula varchar(15) PRIMARY KEY,
pregunta varchar(50),
respuesta varchar(50),
clave varchar(5) not null
)

