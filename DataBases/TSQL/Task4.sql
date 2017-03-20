USE AccountsDB
GO

CREATE PROC CalculateInterest
	@accountID int,
	@interestRate money
AS
	DECLARE @monthsNum money = 1,
		@sumMoney money = 
			(SELECT a.Balance
				FROM Accounts a
				WHERE a.Id = @accountID);
	UPDATE Accounts
	SET Balance = dbo.ufn_CalcInterest(@sumMoney , @interestRate, @monthsNum)
	WHERE Id = @accountID
GO

EXEC CalculateInterest 2, 10

SELECT * FROM Accounts a