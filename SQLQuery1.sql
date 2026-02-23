-- Crear base de datos

CREATE DATABASE llamdaRemota;
GO

USE llamdaRemota;
GO

-- Eliminar tablas si existen (evita error si no están creadas)
IF OBJECT_ID('creditosRealizado', 'U') IS NOT NULL DROP TABLE creditosRealizado;
IF OBJECT_ID('cliente', 'U') IS NOT NULL DROP TABLE cliente;
IF OBJECT_ID('fondosCredito', 'U') IS NOT NULL DROP TABLE fondosCredito;
GO

-- Tabla cliente
CREATE TABLE cliente (
    idCliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    correo VARCHAR(100) NOT NULL UNIQUE,
    celular VARCHAR(20) NOT NULL,
    direccion VARCHAR(150)
);
GO

-- Tabla fondosCredito
CREATE TABLE fondosCredito (
    idFondosCredito INT PRIMARY KEY,
    dineroDisponible DECIMAL(15,2) NOT NULL,
    fechaModificacion DATETIME NOT NULL
);
GO

-- Tabla creditosRealizado
CREATE TABLE creditosRealizado (
    idCreditosRealizado INT IDENTITY(1,1) PRIMARY KEY,
    idCliente INT NOT NULL,
    idFondosCredito INT NOT NULL,
    fechaCredito DATETIME NOT NULL,
    valorPrestado DECIMAL(15,2) NOT NULL,
    noCuotas INT NOT NULL,
    CONSTRAINT FK_credito_cliente FOREIGN KEY (idCliente) 
        REFERENCES cliente(idCliente),
    CONSTRAINT FK_credito_fondos FOREIGN KEY (idFondosCredito) 
        REFERENCES fondosCredito(idFondosCredito)
);
GO

-- Insertar datos
INSERT INTO fondosCredito (idFondosCredito, dineroDisponible, fechaModificacion)
VALUES (1, 100000000, '2026-02-21');

INSERT INTO cliente (nombre, apellido, correo, celular, direccion)
VALUES ('Oscar', 'Ortiz', 'oscaortiz10@gmail.com', '3223496849', 'Calle 33');

-- Consultas
SELECT * FROM cliente;
SELECT * FROM fondosCredito;
SELECT * FROM creditosRealizado;


SELECT DB_NAME();

SELECT name 
FROM sys.tables;


SELECT TABLE_SCHEMA, TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'creditosRealizado';


USE llamdaRemota;
GO

SELECT 
    s.name AS SchemaName,
    t.name AS TableName
FROM sys.tables t
INNER JOIN sys.schemas s 
    ON t.schema_id = s.schema_id
WHERE t.name = 'creditosRealizado';


SELECT @@SERVERNAME