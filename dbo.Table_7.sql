CREATE TABLE [dbo].[Pago a Docentes]
(
	[IdPago] INT NOT NULL PRIMARY KEY, 
    [Iddocente] INT NULL, 
    [Sueldo Base] DECIMAL(10, 2) NULL, 
    [Total a Pagar] DECIMAL(10, 2) NULL, 
    CONSTRAINT [Iddocente] FOREIGN KEY ([Iddocente]) REFERENCES [dbo].[Docentes]([IdDocente])
)
