CREATE DATABASE CRUD;
GO

USE CRUD;
GO

CREATE TABLE Conductores (
	IdConductor INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nombre NVARCHAR(60) NOT NULL,
	Apellido NVARCHAR(40) NOT NULL,
	Documento BIGINT NOT NULL,
	NumeroCelular BIGINT NOT NULL
)

CREATE TABLE Vehiculos (
	IdVehiculo INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Placa NVARCHAR(8) NOT NULL,
	Marca NVARCHAR(50) NOT NULL,
	Modelo INT NOT NULL
)

CREATE TABLE Trayectos (
	IdTrayecto INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	CiudadOrigen NVARCHAR(50) NOT NULL,
	CiudadDestino NVARCHAR(50) NOT NULL,
	IdConductor INT FOREIGN KEY (IdConductor) REFERENCES Conductores (IdConductor) NOT NULL,
	IdVehiculo INT FOREIGN KEY (IdVehiculo) REFERENCES Vehiculos (IdVehiculo) NOT NULL,
	ValorReal INT NOT NULL,
	ValorCobrado INT NOT NULL,
	Fecha DATETIME NOT NULL DEFAULT GETDATE()
)

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Andres Garcia
-- Create date: 31/07/2024
-- Description:	Agregar un nuevo conductor
-- =============================================
CREATE PROCEDURE GuardarConductor
	-- Add the parameters for the stored procedure here
	@Nombre NVARCHAR(MAX),
	@Apellido NVARCHAR(MAX),
	@Documento BIGINT,
	@NumeroDocumento BIGINT
AS
BEGIN
	INSERT INTO Conductores (
		Nombre, 
		Apellido, 
		Documento, 
		NumeroCelular
	) 
	VALUES(
		@Nombre, 
		@Apellido, 
		@Documento, 
		@NumeroDocumento
	)
	SELECT * FROM Conductores WHERE IdConductor = SCOPE_IDENTITY()
END
GO

USE [CRUD]
GO

/****** Object:  View [dbo].[VIEW_TRAYECTOS]    Script Date: 4/08/2024 9:12:59 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VIEW_TRAYECTOS]
AS
SELECT        t.IdTrayecto, c.Nombre, c.Apellido, v.Placa, v.Modelo, t.ValorReal, t.ValorCobrado, t.Fecha, t.CiudadOrigen, t.CiudadDestino
FROM            dbo.Trayectos AS t INNER JOIN
                         dbo.Vehiculos AS v ON v.IdVehiculo = t.IdVehiculo INNER JOIN
                         dbo.Conductores AS c ON c.IdConductor = t.IdConductor
GO
GO