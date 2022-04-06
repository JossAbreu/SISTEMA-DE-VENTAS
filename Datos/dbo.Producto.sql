CREATE TABLE [dbo].[Producto] (
    [IdProducto]  INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]      VARCHAR (20)  NOT NULL,
    [Modelo]      VARCHAR (20)  NOT NULL,
    [Marca]       VARCHAR (50)  NOT NULL,
    [Imei]        INT           NULL,
    [Descripcion] VARCHAR (MAX) NOT NULL,
    [Precio]      DECIMAL (18)  NOT NULL,
    [Costo]       DECIMAL (18)  NOT NULL,
    [Color]       VARCHAR (20)  NOT NULL,
    [Estado] VARCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([IdProducto] ASC)
);

