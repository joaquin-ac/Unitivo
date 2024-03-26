create database Unitivo;

USE Unitivo;
GO

-- Tabla Empleados
CREATE TABLE empleados (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    apellido VARCHAR(255) NOT NULL,
    dni INT UNIQUE NOT NULL,
    telefono VARCHAR(20) UNIQUE NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    correo VARCHAR(255) UNIQUE NOT NULL,
    estado BIT NOT NULL,
    FechaModificacion DATETIME2 DEFAULT GETDATE(),
    FechaCreacion DATETIME2 NOT NULL DEFAULT GETDATE(),
    edad DATETIME2 NOT NULL, 

    CONSTRAINT CHK_TYPE_ESTADO_EMPLEADOS CHECK(estado IN(0,1)),
    CONSTRAINT CHK_CORREO_EMPLEADOS CHECK(correo LIKE '%@%.%'),
    CONSTRAINT CHK_FECHACREACION_EMPLEADOS CHECK(FechaCreacion IS NOT NULL),
    CONSTRAINT CHK_EDAD_EMPLEADOS CHECK(edad IS NOT NULL)
);
GO



-- Tabla Perfiles
CREATE TABLE perfiles (
    id INT IDENTITY(1,1) PRIMARY KEY,
    descripcion_perfil VARCHAR(255) NOT NULL,
    estado_perfil BIT NOT NULL
);
GO

-- Tabla Usuarios
CREATE TABLE usuarios (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre_usuario VARCHAR,
    password VARCHAR(255) NOT NULL,
    estado BIT NOT NULL,
    FechaModificacion DATETIME2 DEFAULT GETDATE(),
    FechaCreacion DATETIME2 NOT NULL DEFAULT GETDATE(),
    id_perfil INT NOT NULL,
    id_empleado INT NOT NULL,

    CONSTRAINT FK_id_perfil_USUARIOS FOREIGN KEY (id_perfil) REFERENCES perfiles(id),
    CONSTRAINT FK_id_empleado_USUARIOS FOREIGN KEY (id_empleado) REFERENCES empleados(id)
);
GO


-- Tabla Clientes
CREATE TABLE clientes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    apellido VARCHAR(255) NOT NULL,
    dni INT UNIQUE NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    direccion VARCHAR(255),
    correo VARCHAR(255) UNIQUE NOT NULL,
    estado BIT NOT NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT GETDATE(),
    FechaModificacion DATETIME2 DEFAULT GETDATE(),
    UsuarioCreacion INT,
    UsuarioModificacion INT,

    CONSTRAINT CHK_CORREO_CLIENTES CHECK(correo LIKE '%@%.%'),
    CONSTRAINT CHK_ESTADO_CLIENTES CHECK(estado IN(0,1))
);
GO
    

CREATE TABLE facturas (
    id INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATE NOT NULL,
    estado BIT NOT NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT GETDATE(),
    id_usuario INT NOT NULL,
    id_cliente INT NOT NULL, -- Agregado el campo id_cliente

    CONSTRAINT FK_id_usuario_FACTURAS FOREIGN KEY (id_usuario) REFERENCES usuarios(id),
    CONSTRAINT FK_id_cliente_FACTURAS FOREIGN KEY (id_cliente) REFERENCES clientes(id)
);
GO
 
-- Tabla Talle
CREATE TABLE talles (
    id INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL,
    estado BIT NOT NULL,

    CONSTRAINT CHK_TYPE_ESTADO_talle_TYPES CHECK(estado IN(0,1))
);
GO

-- Tabla Categoría
CREATE TABLE categorias (
    id INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(255) NOT NULL,
    estado BIT NOT NULL,

    CONSTRAINT CHK_TYPE_ESTADO_categoria_TYPES CHECK(estado IN(0,1))
);
GO

-- Tabla Productos
CREATE TABLE productos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    precio FLOAT NOT NULL,
    stock INT NOT NULL,
    estado BIT NOT NULL,
    imagen VARCHAR(255) NOT NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT GETDATE(),
    FechaModificacion DATETIME2 DEFAULT GETDATE(),
    id_categoria INT NOT NULL, 
    id_talle INT NOT NULL,

    CONSTRAINT CHK_TYPE_ESTADO_PRODUCTOS CHECK(estado IN(0,1)),
    CONSTRAINT CHK_STOCK_PRODUCTOS CHECK(stock >= 0),
    CONSTRAINT CHK_PRECIO_PRODUCTOS CHECK(precio >= 0),
    CONSTRAINT FK_id_categoria_PRODUCTOS FOREIGN KEY (id_categoria) REFERENCES categorias(id),
    CONSTRAINT FK_id_talle_PRODUCTOS FOREIGN KEY (id_talle) REFERENCES talles(id)
);
GO

-- Tabla Detalle Factura
CREATE TABLE detalle_facturas (
    id INT IDENTITY(1,1) PRIMARY KEY,
    cantidad INT NOT NULL,
    precio DECIMAL(10, 2) NOT NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT GETDATE(),
    id_factura INT,
    id_producto INT,

    CONSTRAINT CHK_CANTIDAD_DETALLE_FACTURAS CHECK(cantidad > 0),
    CONSTRAINT CHK_PRECIO_DETALLE_FACTURAS CHECK(precio > 0),
    CONSTRAINT FK_id_factura_DETALLE_FACTURAS FOREIGN KEY (id_factura) REFERENCES facturas(id),
    CONSTRAINT FK_id_productos_DETALLE_FACTURAS FOREIGN KEY (id_producto) REFERENCES productos(id)
);
GO