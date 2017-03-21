USE ComputersDb

GO

CREATE PROCEDURE GetComputersWithGpuAndRamBetween
	@gpuID int,
	@minRAM int,
	@maxRAM int
AS
BEGIN
	SELECT *
	FROM dbo.Computers c
	INNER JOIN ComputerGPUs g
	ON c.Id = g.ComputerId
	WHERE c.RAM >= @minRAM AND c.RAM <= @maxRAM
	AND g.GPUId = @gpuID
END;