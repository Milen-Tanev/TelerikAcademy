USE ComputersDb

GO
-- each computer has 2 GPUs, this procedure returns the GPUs, as the task demands --
CREATE PROCEDURE usp_GetGpusForComputerType
	@computerType nvarchar(20)
AS
BEGIN
	SELECT DISTINCT *
	FROM GPUs g
	INNER JOIN ComputerGPUs cg
	ON g.Id = cg.GPUId
		INNER JOIN Computers c
		ON cg.ComputerId = c.Id
		WHERE c.Type = @computerType
END;