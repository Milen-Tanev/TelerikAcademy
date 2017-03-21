USE ComputersDb

GO

CREATE PROCEDURE usp_GetComputersWithRamBetween
	@minRAM int,
	@maxRAM int
AS
BEGIN
	SELECT c.Vendor, c.Model, c.Id
	FROM dbo.Computers c
	WHERE c.RAM >= @minRAM AND c.RAM <= @maxRAM
END;