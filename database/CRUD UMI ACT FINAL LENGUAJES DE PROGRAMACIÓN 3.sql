use CRUDUMI 



CREATE TABLE CLIENTES (
dni varchar ( 12)  PRIMARY KEY,
nombre varchar (20) NOT NULL,
apellidos varchar (20) NOT NULL,
fechaNac date NOT NULL,
telefono varchar (20) NOT NULL,
)

CREATE TABLE PRODUCTOS (
codigo VARCHAR(20) PRIMARY KEY,
nombre VARCHAR(20) NOT NULL,
precio DECIMAL(10,2) NOT NULL,
nifProveedor VARCHAR(20) NOT NULL
)

CREATE TABLE PROVEEDORES (
nif varchar (20) PRIMARY KEY,
nombre varchar (20) NOT NULL,
direccion varchar (30) NOT NULL,
)

CREATE TABLE COMPRAS (
dniCliente varchar (30) NOT NULL,
codProducto varchar (30) NOT NULL)

alter table COMPRAS 
alter column dniCliente varchar (12) NOT NULL /*Modifique porque no tenian el mimso espacio de datos*/

alter table COMPRAS 
alter column codProducto varchar (20) NOT NULL /*Modifique porque no tenian el mimso espacio de datos*/

SELECT * FROM CLIENTES
SELECT * FROM PRODUCTOS
SELECT * FROM PROVEEDORES
SELECT * FROM COMPRAS

ALTER TABLE COMPRAS /*VAMOS A HACER UNA FK */
ADD CONSTRAINT FK_DNI_CLIENTE --Se agrega restriccion y el nombre de ella
FOREIGN KEY (dniCliente) REFERENCES CLIENTES (dni) -- Tipo y a quien convertiras en FK y referencia (de donde viene tabla y columna a convertir)
ON UPDATE CASCADE   --Cuando se modifica se actualiza en ambas tablas con CASCADE
ON DELETE CASCADE  --IGUAL SOLO QUE AL ELIMINAR

ALTER TABLE COMPRAS /*VAMOS A HACER UNA FK */
ADD CONSTRAINT FK_COD_COMPRAS --Se agrega restriccion y el nombre de ella
FOREIGN KEY (codProducto) REFERENCES PRODUCTOS (codigo) -- Tipo y a quien convertiras en FK y referencia (de donde viene tabla y columna a convertir)
ON UPDATE CASCADE   --Cuando se modifica se actualiza en ambas tablas con CASCADE
ON DELETE CASCADE  --IGUAL SOLO QUE AL ELIMINAR


INSERT INTO CLIENTES(dni,nombre,apellidos,fechaNac,telefono)
VALUES
('QTRS920715HS', 'Carlos', 'Ramírez Gutiérrez', '1992-05-14', '6671234589'),
('LMNV990301GT', 'Fernanda', 'López Hernández', '1988-11-23', '6671452390'),
('PRBD940828HJ', 'Alejandro', 'Torres Mendoza', '1995-03-07', '6671984573'),
('WVCK880519MS', 'Mariana', 'Sánchez Delgado', '1999-08-19', '6671765942'),
('XZLP850412MK', 'Ricardo', 'Vargas Morales', '1990-01-30', '6671843025');


INSERT INTO PRODUCTOS(codigo, nombre,precio,nifProveedor)
VALUES 
(2,'Run Leggins', 3500.64, 1),
(8,'Shorts para correr', 6000.78, 2),
(3,'Gorra', 2099.99, 3),
(5,'Blusa dry fit', 9234.50, 1),
(7,'Sudadera', 45.30, 5),
(4,'Pants', 2699.99, 4),
(6,'Calcetas', 320.98, 5)


INSERT INTO PROVEEDORES(nif, nombre, direccion)
VALUES
('Deportenis', 'Calle Juareaz, 234', '6671123456'),
('Innova', 'Calle Escobedo, 542', '6671542865'),
('Calzapato', 'Calle Hidalgo, 1234', '6641588995'),
('Bhermanos', 'Calle Obregon, 755', '661588859'),
('Canada', 'Calle Joseda, 294', '6671252365');


INSERT INTO COMPRAS (dniCliente, codProducto)
VALUES
('QTRS920715HS',2),
('LMNV990301GT',8),
('PRBD940828HJ',3),
('WVCK880519MS',5),
('XZLP850412MK',7);



ALTER TABLE CLIENTES
ADD email varchar(30) 

INSERT INTO CLIENTES(dni,nombre,apellidos,fechaNac,telefono,email)
VALUES
('MMRS800715HS', 'Carlos', 'Ramírez Gutiérrez', '1992-05-14', '6671234589','dark_god@gmail.com');
