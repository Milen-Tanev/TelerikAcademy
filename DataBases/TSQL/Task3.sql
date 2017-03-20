USE AccountsDB
GO

CREATE FUNCTION ufn_CalcInterest(@sumMoney money, @yearlyInterest money, @monthsNum int)
	RETURNS money
AS
BEGIN
	 DECLARE @interest money = @sumMoney + (@sumMoney * (@yearlyInterest / 12 * @monthsNum)) / 100
	RETURN @interest;
END

GO

SELECT dbo.ufn_CalcInterest(1000, 10, 12) AS 'Sum with interest'