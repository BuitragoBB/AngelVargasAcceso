CREATE TABLE cliente
(
 Cliente_id int NOT NULL PRIMARY KEY,
 Nombre_Cliente Nvarchar(50) NOT NULL,
 Apellido_Cliente Nvarchar(50) NOT NULL,
 Cedula INT NOT NULL,
 Tel_cliente INT NULL
)
GO

CREATE TABLE venta
(
 Venta_id int NOT NULL PRIMARY KEY,
 Cantidad int NOT NULL,
 TotalVenta INT NOT NULL
 CONSTRAINT Productoid_CFK FOREIGN KEY (Producto_id) REFERENCES producto (Producto_id)
 CONSTRAINT Clienteid_FK FOREIGN KEY (Cliente_id) REFERENCES cliente (Cliente_id)
 )
GO

CREATE TABLE producto
(
 Producto_id int NOT NULL PRIMARY KEY,
 Nombre_producto nvarchar(50) NOT NULL,
 Cantidad INT NOT NULL,
 Precio INT NOT NULL
)
GO

