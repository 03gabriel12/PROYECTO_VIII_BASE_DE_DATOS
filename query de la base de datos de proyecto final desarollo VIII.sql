CREATE DATABASE Empresa;

USE Empresa;

CREATE TABLE CLIENTE (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(30) NOT NULL,
    Apellido VARCHAR(30) NOT NULL,
    Direccion VARCHAR(50),
    Celular VARCHAR(9) CHECK (Celular LIKE '____-____'),
    Correo VARCHAR(50) CHECK (Correo LIKE '%@%.%'),
    Sexo CHAR(1) CHECK (Sexo IN ('M', 'F')),
    Estatus CHAR(1) CHECK (Estatus IN ('A', 'I'))
);

CREATE TABLE PRODUCTO (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CodigoBarra VARCHAR(12) NOT NULL UNIQUE,
    Descripcion VARCHAR(50) NOT NULL,
    Costo DECIMAL(7,2),
    Precio DECIMAL(7,2),
    ITBMS INT,
    Existencia INT,
    PuntoReorden INT,
    Estatus CHAR(1) CHECK (Estatus IN ('A', 'I'))
);


CREATE PROCEDURE BuscarCliente
    @Cedula VARCHAR(15)
AS
BEGIN
    SELECT * 
    FROM CLIENTE 
    WHERE Cedula = @Cedula;
END;
GO

CREATE PROCEDURE AgregarCliente
    @Cedula VARCHAR(15),
    @Nombre VARCHAR(30),
    @Apellido VARCHAR(30),
    @Direccion VARCHAR(50),
    @Celular VARCHAR(9),
    @Correo VARCHAR(50),
    @Sexo CHAR(1),
    @Estatus CHAR(1)
AS
BEGIN
    INSERT INTO CLIENTE (Cedula, Nombre, Apellido, Direccion, Celular, Correo, Sexo, Estatus)
    VALUES (@Cedula, @Nombre, @Apellido, @Direccion, @Celular, @Correo, @Sexo, @Estatus);
END;
GO

CREATE PROCEDURE ModificarCliente
    @Cedula VARCHAR(15),
    @Nombre VARCHAR(30),
    @Apellido VARCHAR(30),
    @Direccion VARCHAR(50),
    @Celular VARCHAR(9),
    @Correo VARCHAR(50),
    @Sexo CHAR(1),
    @Estatus CHAR(1)
AS
BEGIN
    UPDATE CLIENTE
    SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion,
        Celular = @Celular, Correo = @Correo, Sexo = @Sexo, Estatus = @Estatus
    WHERE Cedula = @Cedula;
END;
GO

CREATE PROCEDURE EliminarCliente
    @Cedula VARCHAR(15)
AS
BEGIN
    DELETE FROM CLIENTE WHERE Cedula = @Cedula;
END;
GO

CREATE PROCEDURE ListarClientes
    @OrdenarPor VARCHAR(30)
AS
BEGIN
    DECLARE @Query NVARCHAR(MAX);
    SET @Query = 'SELECT * FROM CLIENTE ORDER BY ' + @OrdenarPor;
    EXEC sp_executesql @Query;
END;
GO





CREATE PROCEDURE ListarProductos
    @OrdenarPor NVARCHAR(50) -- Parámetro para especificar la columna de ordenamiento
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar que el parámetro corresponde a columnas válidas
    IF @OrdenarPor NOT IN ('CodigoBarra','Descripcion', 'Costo', 'Precio', 'ITBMS', 'Existencia', 'PuntoReorden', 'Estatus')
    BEGIN
        RAISERROR ('El parámetro de ordenamiento no es válido.', 16, 1);
        RETURN;
    END;

    -- Construir y ejecutar la consulta dinámica
    DECLARE @Query NVARCHAR(MAX);
    SET @Query = 'SELECT * FROM PRODUCTO ORDER BY ' + @OrdenarPor;

    EXEC sp_executesql @Query;
END;
GO



CREATE PROCEDURE BuscarProducto
    @CodigoBarra VARCHAR(12) -- Parámetro para buscar el producto por su código de barra
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si existe un producto con el código de barra proporcionado
    IF NOT EXISTS (SELECT 1 FROM PRODUCTO WHERE CodigoBarra = @CodigoBarra)
    BEGIN
        PRINT 'No se encontró ningún producto con el código de barra proporcionado.';
        RETURN;
    END;

    -- Consultar el producto por su código de barra
    SELECT * 
    FROM PRODUCTO 
    WHERE CodigoBarra = @CodigoBarra;
END;
GO



CREATE PROCEDURE EliminarProducto
    @CodigoBarra VARCHAR(12) -- Parámetro para identificar el producto a eliminar
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si existe un producto con el CodigoBarra proporcionado
    IF NOT EXISTS (SELECT 1 FROM PRODUCTO WHERE CodigoBarra = @CodigoBarra)
    BEGIN
        PRINT 'No se encontró ningún producto con el código de barra proporcionado.';
        RETURN;
    END;

    -- Eliminar el producto
    DELETE FROM PRODUCTO
    WHERE CodigoBarra = @CodigoBarra;

    PRINT 'El producto ha sido eliminado exitosamente.';
END;
GO


CREATE PROCEDURE ModificarProducto
    @CodigoBarra VARCHAR(12),
    @Descripcion VARCHAR(50),
    @Costo DECIMAL(7,2),
    @Precio DECIMAL(7,2),
    @ITBMS INT,
    @Existencia INT,
    @PuntoReorden INT,
    @Estatus CHAR(1)
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el producto con el CodigoBarra existe
    IF NOT EXISTS (SELECT 1 FROM PRODUCTO WHERE CodigoBarra = @CodigoBarra)
    BEGIN
        PRINT 'No se encontró el producto con el código de barra proporcionado.';
        RETURN;
    END;

    -- Actualizar el producto
    UPDATE PRODUCTO
    SET
        Descripcion = @Descripcion,
        Costo = @Costo,
        Precio = @Precio,
        ITBMS = @ITBMS,
        Existencia = @Existencia,
        PuntoReorden = @PuntoReorden,
        Estatus = @Estatus
    WHERE CodigoBarra = @CodigoBarra;

    PRINT 'El producto ha sido modificado exitosamente.';
END;
GO


CREATE PROCEDURE AgregarProducto
    @CodigoBarra VARCHAR(12),
    @Descripcion VARCHAR(50),
    @Costo DECIMAL(7,2),
    @Precio DECIMAL(7,2),
    @ITBMS INT,
    @Existencia INT,
    @PuntoReorden INT,
    @Estatus CHAR(1)
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el CodigoBarra ya existe
    IF EXISTS (SELECT 1 FROM PRODUCTO WHERE CodigoBarra = @CodigoBarra)
    BEGIN
        PRINT 'Ya existe un producto con este código de barra.';
        RETURN;
    END;

    -- Insertar el nuevo producto
    INSERT INTO PRODUCTO (CodigoBarra, Descripcion, Costo, Precio, ITBMS, Existencia, PuntoReorden, Estatus)
    VALUES (@CodigoBarra, @Descripcion, @Costo, @Precio, @ITBMS, @Existencia, @PuntoReorden, @Estatus);

    PRINT 'El producto ha sido agregado exitosamente.';
END;
GO





-- Insertar datos en la tabla CLIENTE
INSERT INTO CLIENTE (Cedula, Nombre, Apellido, Direccion, Celular, Correo, Sexo, Estatus)
VALUES 
('AA-1234-567890', 'Juan', 'Pérez', 'Calle 123, Ciudad', '9999-9999', 'juan.perez@correo.com', 'M', 'A'),
('BB-2345-678901', 'Ana', 'Gómez', 'Avenida 456, Ciudad', '9888-8888', 'ana.gomez@correo.com', 'F', 'A'),
('CC-3456-789012', 'Carlos', 'López', 'Calle 789, Ciudad', '9777-7777', 'carlos.lopez@correo.com', 'M', 'A'),
('DD-4567-890123', 'María', 'Fernández', 'Calle 101, Ciudad', '9666-6666', 'maria.fernandez@correo.com', 'F', 'A'),
('EE-5678-901234', 'Pedro', 'Martínez', 'Calle 202, Ciudad', '9555-5555', 'pedro.martinez@correo.com', 'M', 'A'),
('FF-6789-012345', 'Laura', 'Hernández', 'Calle 303, Ciudad', '9444-4444', 'laura.hernandez@correo.com', 'F', 'A'),
('GG-7890-123456', 'Luis', 'Rodríguez', 'Calle 404, Ciudad', '9333-3333', 'luis.rodriguez@correo.com', 'M', 'A'),
('HH-8901-234567', 'Isabel', 'García', 'Calle 505, Ciudad', '9222-2222', 'isabel.garcia@correo.com', 'F', 'A'),
('II-9012-345678', 'José', 'Martínez', 'Calle 606, Ciudad', '9111-1111', 'jose.martinez@correo.com', 'M', 'A'),
('JJ-0123-456789', 'Patricia', 'Díaz', 'Calle 707, Ciudad', '9000-0000', 'patricia.diaz@correo.com', 'F', 'A');


-- Insertar datos en la tabla PRODUCTO
INSERT INTO PRODUCTO (Codigobarra, Descripcion, Costo, Precio, Itbms, Existencia, PuntoReorden, Estatus)
VALUES 
('123456789012', 'Producto A', 100.00, 150.00, 7, 50, 10, 'A'),
('234567890123', 'Producto B', 200.00, 250.00, 7, 30, 15, 'A'),
('345678901234', 'Producto C', 150.00, 200.00, 7, 40, 20, 'A'),
('456789012345', 'Producto D', 80.00, 120.00, 7, 60, 25, 'A'),
('567890123456', 'Producto E', 50.00, 80.00, 7, 70, 30, 'A'),
('678901234567', 'Producto F', 120.00, 180.00, 7, 20, 5, 'A'),
('789012345678', 'Producto G', 180.00, 230.00, 7, 80, 40, 'A'),
('890123456789', 'Producto H', 90.00, 130.00, 7, 15, 10, 'A'),
('901234567890', 'Producto I', 130.00, 190.00, 7, 25, 15, 'A'),
('012345678901', 'Producto J', 200.00, 270.00, 7, 35, 20, 'A');
