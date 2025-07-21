CREATE DATABASE PapeleriaBD;
GO

USE papeleriaBD;
GO

CREATE TABLE Producto(
	idProducto INT IDENTITY(1,1) PRIMARY KEY,
	nombreProducto VARCHAR(20) NOT NULL,
	marcaProducto VARCHAR(20) NOT NULL,
	detalleProducto VARCHAR(20) Null,
	precioProducto DECIMAL(10,2)
);
GO

CREATE TABLE Venta(
	idVenta INT IDENTITY(1,1) PRIMARY KEY,
	fechaVenta DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE DetalleVenta (
	idDetalleVenta INT IDENTITY(1,1) PRIMARY KEY,
	idVenta INT NOT NULL,
	idProducto INT NOT NULL,
	cantidad INT NOT NULL CHECK (cantidad > 0),
	precioUnitario DECIMAL(10,2) NOT NULL CHECK (precioUnitario >= 0)
);
GO

-- Sección CONSTRAINTS (para llaves foráneas)
ALTER TABLE DetalleVenta
ADD CONSTRAINT FK_DetalleVenta_Venta
FOREIGN KEY (idVenta) REFERENCES Venta(idVenta);
GO

ALTER TABLE DetalleVenta
ADD CONSTRAINT FK_DetalleVenta_Producto
FOREIGN KEY (idProducto) REFERENCES Producto(idProducto);
GO

-- Procedimientos 

CREATE PROCEDURE AgregarProducto(
	@nombreProducto VARCHAR(20), 
	@marcaProducto VARCHAR(20),
	@detalleProducto VARCHAR(20),
	@precioProducto DECIMAL(10,2),
	@mensajeDeRespuesta VARCHAR(100) OUTPUT
)
AS
BEGIN
	IF EXISTS (
		SELECT 1 FROM Producto
		WHERE nombreProducto = @nombreProducto 
		AND marcaProducto = @marcaProducto 
		AND detalleProducto = @detalleProducto
	)
	BEGIN
		SET @mensajeDeRespuesta = 'El producto existe';
		RETURN 1;
	END
	
	INSERT INTO Producto (nombreProducto, marcaProducto, detalleProducto, precioProducto) 
	VALUES (@nombreProducto, @marcaProducto, @detalleProducto, @precioProducto)
	
	SET @mensajeDeRespuesta = 'Producto agregado exitosamente';
	RETURN 0;
END;
GO

CREATE PROCEDURE RegistrarVenta
(
	@idVenta INT OUTPUT,
	@mensajeDeRespuesta NVARCHAR(100) OUTPUT
)
AS
BEGIN
	INSERT INTO Venta DEFAULT VALUES;

	SET @idVenta = SCOPE_IDENTITY(); -- Obtiene el ID recién generado
	SET @mensajeDeRespuesta = 'Venta registrada correctamente.';
	RETURN 0;
END;
GO

CREATE PROCEDURE AgregarDetalleVenta
(
	@idVenta INT,
	@idProducto INT,
	@cantidad INT,
	@precioUnitario DECIMAL(10,2),
	@mensajeDeRespuesta NVARCHAR(100) OUTPUT
)
AS
BEGIN

	IF NOT EXISTS (SELECT 1 FROM Venta WHERE idVenta = @idVenta)
	BEGIN
		SET @mensajeDeRespuesta = 'La venta no existe.';
		RETURN 1;
	END

	IF NOT EXISTS (SELECT 1 FROM Producto WHERE idProducto = @idProducto)
	BEGIN
		SET @mensajeDeRespuesta = 'El producto no existe.';
		RETURN 2;
	END

	INSERT INTO DetalleVenta (idVenta, idProducto, cantidad, precioUnitario)
	VALUES (@idVenta, @idProducto, @cantidad, @precioUnitario);

	SET @mensajeDeRespuesta = 'Detalle agregado correctamente.';
	RETURN 0;
END;
GO

CREATE PROCEDURE MostrarProductos 
AS
BEGIN
	SELECT 
		idProducto AS [ID],
		nombreProducto AS [Nombre],
		marcaProducto AS [Marca],
		detalleProducto AS [Infomracion Adicional],
		REPLACE(FORMAT(precioProducto, 'C', 'es-MX'), '$', '$ ') AS [Precio]
	FROM Producto;
END;
GO

CREATE PROCEDURE BuscarProductos
	@busqueda NVARCHAR(50)
AS
BEGIN
	SELECT 
		idProducto AS [ID],
		nombreProducto AS [Nombre],
		marcaProducto AS [Marca],
		detalleProducto AS [Infomracion Adicional],
		REPLACE(FORMAT(precioProducto, 'C', 'es-MX'), '$', '$ ') AS [Precio]
	FROM Producto
	WHERE nombreProducto LIKE '%' + @busqueda + '%'
	OR marcaProducto LIKE '%' + @busqueda + '%'
	or detalleProducto LIKE '%' + @busqueda + '%'
END;
GO