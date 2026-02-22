create database llamdaRemota;
use llamdaRemota;

DROP TABLE cliente;
DROP TABLE fondosCredito;

CREATE TABLE cliente (
    idCliente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    correo VARCHAR(100) NOT NULL UNIQUE,
    celular VARCHAR(20) NOT NULL,
    direccion VARCHAR(150)
) ENGINE=InnoDB;

CREATE TABLE fondosCredito (
    idFondosCredito INT NOT NULL PRIMARY KEY,
    dineroDisponible DECIMAL(15,2) NOT NULL,
    fechaModificacion DATETIME NOT NULL
) ENGINE=InnoDB;

CREATE TABLE creditosRealizado (
    idCreditosRealizado INT AUTO_INCREMENT PRIMARY KEY,
    idCliente INT NOT NULL,
    idFondosCredito INT NOT NULL,
    fechaCredito DATETIME NOT NULL,
    valorPrestado DECIMAL(15,2) NOT NULL,
    noCuotas INT NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES cliente(idCliente),
    FOREIGN KEY (idFondosCredito) REFERENCES fondosCredito(idFondosCredito)
) ENGINE=InnoDB;

INSERT INTO fondosCredito
value (1, 100000000, '20260221');

insert into cliente 
values(null, "Oscar", "Ortiz", "oscaortiz10@gmail.com", "3223496849", "Calle 33");

select * from cliente;
SElect * from fondosCredito;
SElect * from creditosRealizado;



