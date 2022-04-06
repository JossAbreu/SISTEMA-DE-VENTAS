CREATE TABLE [dbo].[Compra_Cabecera
]
(
	[IdCompra_Cabecera] INT NOT NULL PRIMARY KEY, 
    [IdEmpleado] NCHAR(10) NOT NULL, 
    [IdProveedor] NCHAR(10) NOT NULL, 
    [Descripcion] NCHAR(10) NOT NULL
)
