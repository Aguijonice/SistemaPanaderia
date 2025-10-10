DROP SCHEMA IF EXISTS Panaderia;
-- -----------------------------------------------------
-- Schema hospital
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Panaderia` DEFAULT CHARACTER SET utf8mb3 ;
USE `Panaderia` ;

-- Crear la tabla de PAN
CREATE TABLE PAN (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    stock INT NOT NULL
);

-- Insertar datos en la tabla de helados
INSERT INTO helados (nombre, categoria, stock) VALUES
('Pan Concha', 'Clásico', 50),
('Pan Ajo', 'Clásico', 30),
('Pan Simita alta', 'Piña', 20),
('Pan peperecha', 'Clásico', 15),
('Pan Quesadilla', 'clasico', 25);

-- Crear la tabla de ventas
CREATE TABLE Ventas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    subtotal DECIMAL(10, 2) NOT NULL,
    iva DECIMAL(10, 2) NOT NULL,
    total DECIMAL(10, 2) NOT NULL
);

-- Insertar datos en la tabla de ventas
INSERT INTO Ventas (subtotal, iva, total) VALUES
(100.00, 16.00, 116.00),
(50.00, 8.00, 58.00),
(75.00, 12.00, 87.00);

-- Crear la tabla de empleados
CREATE TABLE empleados (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    a_materno VARCHAR(100) NOT NULL,
    a_paterno VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    contraseña VARCHAR(255) NOT NULL
);

-- Insertar datos en la tabla de empleados
INSERT INTO empleados (nombre, a_materno, a_paterno, usuario, contraseña) VALUES
('Juan', 'Pérez', 'Gómez', 'juanp', 'contraseña123'),
('María', 'López', 'Martínez', 'marial', 'contraseña456'),
('Carlos', 'Sánchez', 'Torres', 'carlost', 'contraseña789');

-- Crear la tabla de comprobanteVenta
CREATE TABLE comprobanteVenta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    pan_id INT NOT NULL,
    venta_id INT NOT NULL,
    empleado_id INT NOT NULL,
    fecha_hora DATETIME NOT NULL,
    FOREIGN KEY (pan_id) REFERENCES pan(id),
    FOREIGN KEY (venta_id) REFERENCES Ventas(id),
    FOREIGN KEY (empleado_id) REFERENCES empleados(id)
);

-- Insertar datos en la tabla de comprobanteVenta
INSERT INTO comprobanteVenta (pan_id, venta_id, empleado_id, fecha_hora) VALUES
(1, 1, 1, NOW()),
(2, 2, 2, NOW()),
(3, 3, 1, NOW());
