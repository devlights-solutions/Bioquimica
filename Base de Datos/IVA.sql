ALTER TABLE Prepaga
ADD DiscriminaIVA bit NOT NULL DEFAULT(0)
GO

ALTER TABLE Prepaga
ADD PorcentajeIVA decimal(18, 2) NULL
GO

ALTER TABLE Orden
ADD DiscriminaIVA bit NOT NULL DEFAULT(0)
GO


ALTER PROCEDURE [dbo].[Facturacion]
	@FechaDesde date,
	@FechaHasta date,
	@PrepagaId int
AS
BEGIN
	SELECT 
		O.OrdenId,
		O.PacienteNombre,
		O.FechaAtencion,
		Prepaga = P.Nombre,
		PR.Codigo,
		Subtotal = P.NBU * PR.UB
	FROM Orden O 
		INNER JOIN PracticasOrden PO
			ON O.OrdenId = PO.OrdenId 
		INNER JOIN Prepaga P
			ON O.PrepagaId = P.PrepagaId 
		INNER JOIN Practica PR
			ON PO.PracticaId = PR.PracticaId
	WHERE O.PrepagaId = @PrepagaId 
		AND (@FechaDesde < O.FechaAtencion) 
		AND (@FechaHasta > O.FechaAtencion) 
		AND (P.DiscriminaIVA = 0 OR (P.DiscriminaIVA = 1 AND O.DiscriminaIVA = 0))	
END
GO


CREATE PROCEDURE [dbo].[FacturacionConIVA]
	@FechaDesde date,
	@FechaHasta date,
	@PrepagaId int
AS
BEGIN
	SELECT 
		O.OrdenId,
		O.PacienteNombre,
		O.FechaAtencion,
		Prepaga = P.Nombre,
		PR.Codigo,
		SinIVA = (P.NBU * PR.UB) * (1 - (P.PorcentajeIVA / 100)),
		IVA = (P.NBU * PR.UB) - ((P.NBU * PR.UB) * (1 - (P.PorcentajeIVA / 100))),
		Subtotal = P.NBU * PR.UB
	FROM Orden O 
		INNER JOIN PracticasOrden PO
			ON O.OrdenId = PO.OrdenId 
		INNER JOIN Prepaga P
			ON O.PrepagaId = P.PrepagaId 
		INNER JOIN Practica PR
			ON PO.PracticaId = PR.PracticaId
	WHERE O.PrepagaId = @PrepagaId 
		AND (@FechaDesde < O.FechaAtencion) 
		AND (@FechaHasta > O.FechaAtencion) 
		AND (P.DiscriminaIVA = 1 AND O.DiscriminaIVA = 1)	
END
GO


ALTER PROCEDURE [dbo].[PieFacturacion]
	@FechaDesde date,
	@FechaHasta date,
	@PrepagaId int
AS
BEGIN
	DECLARE @CantidadOrdenes int
	SET @CantidadOrdenes = (SELECT COUNT(OrdenId)
							FROM Orden O
							WHERE O.PrepagaId = @PrepagaId 
							AND (@FechaDesde < O.FechaAtencion) 
							AND (@FechaHasta > O.FechaAtencion))
	
	DECLARE @TotalSinIVA money
	SET @TotalSinIVA = (SELECT SUM(P.NBU * PR.UB)
						FROM Orden O 
							INNER JOIN PracticasOrden PO
								ON O.OrdenId = PO.OrdenId 
							INNER JOIN Prepaga P
								ON O.PrepagaId = P.PrepagaId 
							INNER JOIN Practica PR
								ON PO.PracticaId = PR.PracticaId
						WHERE O.PrepagaId = @PrepagaId 
							AND (@FechaDesde < O.FechaAtencion) 
							AND (@FechaHasta > O.FechaAtencion) 
							AND (P.DiscriminaIVA = 0 OR (P.DiscriminaIVA = 1 AND O.DiscriminaIVA = 0)))
							
	DECLARE @TotalSinIVA2 money
	SET @TotalSinIVA2 = (SELECT SUM((P.NBU * PR.UB) * (1 - (P.PorcentajeIVA / 100)))
						FROM Orden O 
							INNER JOIN PracticasOrden PO
								ON O.OrdenId = PO.OrdenId 
							INNER JOIN Prepaga P
								ON O.PrepagaId = P.PrepagaId 
							INNER JOIN Practica PR
								ON PO.PracticaId = PR.PracticaId
						WHERE O.PrepagaId = @PrepagaId 
							AND (@FechaDesde < O.FechaAtencion) 
							AND (@FechaHasta > O.FechaAtencion) 
							AND (P.DiscriminaIVA = 1 AND O.DiscriminaIVA = 1))
							
	DECLARE @TotalIVA money
	SET @TotalIVA = (SELECT SUM((P.NBU * PR.UB) - ((P.NBU * PR.UB) * (1 - (P.PorcentajeIVA / 100))))
						FROM Orden O 
							INNER JOIN PracticasOrden PO
								ON O.OrdenId = PO.OrdenId 
							INNER JOIN Prepaga P
								ON O.PrepagaId = P.PrepagaId 
							INNER JOIN Practica PR
								ON PO.PracticaId = PR.PracticaId
						WHERE O.PrepagaId = @PrepagaId 
							AND (@FechaDesde < O.FechaAtencion) 
							AND (@FechaHasta > O.FechaAtencion) 
							AND (P.DiscriminaIVA = 1 AND O.DiscriminaIVA = 1))

	SELECT CantidadOrdenes = CAST(@CantidadOrdenes as varchar(10)) + ' (' + dbo.Cadena_ConvertirNumeroEnLetra(CAST(@CantidadOrdenes as varchar(10)),1,',') + ')',
			TotalSinIVA = ISNULL(@TotalSinIVA, 0) + ISNULL(@TotalSinIVA2, 0),
			TotalIVA = ISNULL(@TotalIVA, 0)
END
GO